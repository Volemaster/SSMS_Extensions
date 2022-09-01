using Microsoft.VisualStudio.Text.Editor;
using System;

namespace SSMS
{
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
}
