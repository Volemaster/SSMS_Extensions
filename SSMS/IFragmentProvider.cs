using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SSMS
{
    public interface IFragmentProvider
    {
        IList<TSqlFragment> SqlFragments { get; }
    }
}
