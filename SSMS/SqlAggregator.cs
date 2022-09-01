using System;
using System.Text;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.Linq;

namespace SSMS
{
    public class SqlAggregator
    {
        private SqlScriptGenerator _ScriptGenerator;
        protected SqlScriptGenerator ScriptGenerator => _ScriptGenerator;
        public SqlAggregator(SqlScriptGenerator scriptGenerator)
        {
            _ScriptGenerator = scriptGenerator;
        }
        public string BuildSql(IFragmentProvider fragmentProvider, bool ReverseOrder)
        {
            var result = new StringBuilder();
            foreach (TSqlFragment f in ReverseOrder ? fragmentProvider.SqlFragments.Reverse() : fragmentProvider.SqlFragments)
            {
                ScriptGenerator.GenerateScript(f, out var script);
                result.Append(script).AppendLine(";");
            }
            return result.ToString();
        }

    }
}
