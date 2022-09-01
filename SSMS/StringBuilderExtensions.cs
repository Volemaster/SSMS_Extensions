using System.Collections.Generic;
using System.Text;

namespace SSMS
{
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
}
