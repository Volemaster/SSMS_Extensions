using Microsoft.SqlServer.TransactSql.ScriptDom;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace SSMS
{
    public static class IServiceProviderExtensions
    {
        public static T GetService<T>(this IServiceProvider serviceProvider) => (T)serviceProvider.GetService(typeof(T));
        public static T GetService<T>(this IServiceProvider serviceProvider, Type serviceType) => (T)serviceProvider.GetService(serviceType);
    }
    public static class ParseErrorsExtension
    {
        public static IList<string> ToStringList(this IList<ParseError> parseErrors)
        {
            var results = new List<String>();
            foreach (var p in parseErrors)
            {
                results.Add($"***Error: {p.Number} at Line/Column {p.Line}/{p.Column}:\r\n   {p.Message}***");
            }
            return results;
        }
    }
    public static class AsyncPackageExtensions
    {
        public static IWpfTextView GetWpfTextView(this IServiceProvider serviceProvider)
        {
            var textManager = (IVsTextManager)serviceProvider.GetService(typeof(SVsTextManager));
            var componentModel = (IComponentModel)serviceProvider.GetService(typeof(SComponentModel));
            var editor = componentModel.GetService<IVsEditorAdaptersFactoryService>();
            textManager.GetActiveView(1, null, out var textView);
            return editor.GetWpfTextView(textView);
        }
        //public static IWpfTextView GetWpfTextView(this AsyncPackage package)
        //{

        //    package.TryGetActiveView(out var textView);
        //    VsShellUtilities.ShowMessageBox(
        //        package,
        //        "GetWpfTextView",
        //        "Test",
        //        OLEMSGICON.OLEMSGICON_INFO,
        //        OLEMSGBUTTON.OLEMSGBUTTON_OK,
        //        OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        //    var componentModel = (package as IServiceProvider).GetService<IComponentModel>(typeof(SComponentModel));
        //    var editor = componentModel.GetService<IVsEditorAdaptersFactoryService>();
        //    VsShellUtilities.ShowMessageBox(
        //        package,
        //        "GetWpfTextView-2",
        //        "Test",
        //        OLEMSGICON.OLEMSGICON_INFO,
        //        OLEMSGBUTTON.OLEMSGBUTTON_OK,
        //        OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        //    return editor.GetWpfTextView(textView);
        //}
        //public static bool TryGetActiveView(this AsyncPackage package, out IVsTextView view)
        //{
        //    VsShellUtilities.ShowMessageBox(
        //        package,
        //        "TryGetActiveView",
        //        "Test",
        //        OLEMSGICON.OLEMSGICON_INFO,
        //        OLEMSGBUTTON.OLEMSGBUTTON_OK,
        //        OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        //    var textManager = (package as IServiceProvider).GetService<IVsTextManager>();
        //    return (textManager.GetActiveView(1, null, out view)==0);
        //}
    }

    public static class IWpfTextViewExtensions
    {
        public static string GetTextSnapshot(this IWpfTextView view)
        {
            try
            {
                return view.TextBuffer.CurrentSnapshot.GetText();
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error in GetTextSnapshot", e);
            }
        }
    }
    
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendLines(this StringBuilder stringBuilder, IEnumerable<string> strings)
        {
            foreach (var s in strings)
            {
                stringBuilder.AppendLine(s);
            }
            return stringBuilder;
        }
    }


    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class GenerateDropScript
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("11cc92fc-2313-462c-9e14-748ced1d8738");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage package;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDropScript"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private GenerateDropScript(AsyncPackage package, OleMenuCommandService commandService)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandID = new CommandID(CommandSet, CommandId);
            var menuItem = new MenuCommand(this.Execute, menuCommandID);
            commandService.AddCommand(menuItem);
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static GenerateDropScript Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in GenerateDropScript's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new GenerateDropScript(package, commandService);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void Execute(object sender, EventArgs e)
        {
            // Show a message box to prove we were here
            ThreadHelper.ThrowIfNotOnUIThread();

            var textView = package.GetWpfTextView();
            if (textView == null) return;

            var allSql = new StringReader(textView.GetTextSnapshot());
            var sqlParser = new TSql160Parser(true, SqlEngineType.Standalone);
            var options = new SqlScriptGeneratorOptions()
            {
                IndentationSize = 2,
                IncludeSemicolons = true
            };
            var generator = new Sql160ScriptGenerator(options);
            var aggregator = new SqlAggregator(generator);
            var visitor = new DropObjectVisitor(() => new DropObjectList());

            var fragments = sqlParser.Parse(allSql, out var parseErrors);

            if (parseErrors.Count > 0)
            {
                string message = new StringBuilder().AppendLines(parseErrors.ToStringList()).ToString();
                string title = "Parsing Errors";
                // Show a message box to prove we were here
                VsShellUtilities.ShowMessageBox(
                    this.package,
                    message,
                    title,
                    OLEMSGICON.OLEMSGICON_INFO,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
            }

            fragments.Accept(visitor);
            var edit = textView.TextBuffer.CreateEdit();
            var sql = aggregator.BuildSql(visitor,true);
            edit.Insert(0, sql);
            edit.Apply();
        }
    }
}
