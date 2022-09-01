using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;

namespace SSMS
{
    public class DisableTemporalTable : IfStatement
    {
        public DisableTemporalTable(SchemaObjectName mainTable)
        {
            Predicate = new BooleanExpressionSnippet()
            {
                Script = String.Format("EXISTS (SELECT 1/0 FROM sys.tables WHERE Object_Id = OBJECT_ID('{0}.{1}','U') AND Temporal_Type=2)"
                , mainTable.SchemaIdentifier.QuoteName()
                , mainTable.BaseIdentifier.QuoteName())
            };
            ThenStatement = new AlterTableSetStatement() { SchemaObjectName = mainTable, Options = { new SystemVersioningTableOption() { OptionState = OptionState.Off } } };
        }
    }
}
