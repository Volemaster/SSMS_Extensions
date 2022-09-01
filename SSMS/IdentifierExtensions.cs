using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SSMS
{
    public static class IdentifierExtensions
    {
        public static QuoteType DefaultQuoteType { get; set; } = QuoteType.DoubleQuote;
        public static string QuoteName(this Identifier identifier) => identifier.QuoteName(DefaultQuoteType);
        public static string QuoteName(this Identifier identifier, QuoteType quoteType) => Identifier.EncodeIdentifier(identifier.Value, quoteType);
    }
}
