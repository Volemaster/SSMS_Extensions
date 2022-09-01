using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;
using System;

namespace SSMS
{
    public static class AsyncPackageExtensions
    {
        public static IWpfTextView GetWpfTextView(this IServiceProvider serviceProvider)
        {
            var textManager = serviceProvider.GetService<IVsTextManager, SVsTextManager>();
            var componentModel = serviceProvider.GetService<IComponentModel, SComponentModel>();
            var editor = componentModel.GetService<IVsEditorAdaptersFactoryService>();
            textManager.GetActiveView(1, null, out var textView);
            return editor.GetWpfTextView(textView);
        }
    }
}
