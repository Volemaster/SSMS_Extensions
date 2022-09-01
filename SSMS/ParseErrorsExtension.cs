using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;

namespace SSMS
{
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
}
