using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.Text;

namespace SSMS
{
    public static class SchemaObjectNameExtensions
    {
        public static string QuoteName(this SchemaObjectName objectName)
        {
            var c = new CreateAggregateStatement();
            var sb = new StringBuilder();
            for (int i = 0; i < objectName.Identifiers.Count; i++)
            {
                if (i > 0) sb.Append(".");
                sb.Append(Identifier.EncodeIdentifier(objectName.Identifiers[i].Value, QuoteType.DoubleQuote));
            }
            return sb.ToString();
        }
    }
}
