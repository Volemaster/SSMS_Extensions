using System;
using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.Collections;

namespace SSMS
{

    public class DropObjectVisitor : TSqlConcreteFragmentVisitor, IFragmentProvider
    {
        IList<TSqlFragment> _DropStatements;
        public IList<TSqlFragment> SqlFragments { get => _DropStatements; }
        //protected SqlScriptGenerator ScriptGenerator { get; private set; }
        //public DropObjectVisitor(Func<IList<TSqlFragment>> listFactory, SqlScriptGenerator scriptGenerator)
        public DropObjectVisitor(Func<IList<TSqlFragment>> listFactory)
        {
            _DropStatements = listFactory();
            //ScriptGenerator = scriptGenerator;
        }
        //public string GetDropSql()
        //{
        //    var result = new StringBuilder();
        //    foreach (TSqlFragment f in DropStatements.Reverse())
        //    {
        //        ScriptGenerator.GenerateScript(f, out var script);
        //        result.Append(script).AppendLine(";");
        //    }
        //    return result.ToString();
        //}
        public override void Visit(CreateAggregateStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateApplicationRoleStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateAssemblyStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateAsymmetricKeyStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateAvailabilityGroupStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateBrokerPriorityStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateCertificateStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateColumnEncryptionKeyStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateColumnMasterKeyStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateColumnStoreIndexStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateContractStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateCredentialStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateCryptographicProviderStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateDatabaseAuditSpecificationStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateDatabaseEncryptionKeyStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateDatabaseStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateDefaultStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateEndpointStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateEventNotificationStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateEventSessionStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateExternalDataSourceStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateExternalFileFormatStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateExternalLanguageStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateExternalLibraryStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateExternalResourcePoolStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateExternalStreamingJobStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateExternalStreamStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateExternalTableStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateFederationStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateFullTextCatalogStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateFullTextIndexStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateFullTextStopListStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateFunctionStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateIndexStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateLoginStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateMasterKeyStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateMessageTypeStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateOrAlterFunctionStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateOrAlterProcedureStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateOrAlterTriggerStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateOrAlterViewStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreatePartitionFunctionStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreatePartitionSchemeStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateProcedureStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateQueueStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateRemoteServiceBindingStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateResourcePoolStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateRoleStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateRouteStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateRuleStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateSchemaStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateSearchPropertyListStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateSecurityPolicyStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateSelectiveXmlIndexStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateSequenceStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateServerAuditSpecificationStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateServerAuditStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateServerRoleStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateServiceStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateSpatialIndexStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateStatisticsStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateSymmetricKeyStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateSynonymStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateTableStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateTriggerStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateTypeTableStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateTypeUddtStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateTypeUdtStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateUserStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateViewStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateWorkloadClassifierStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateWorkloadGroupStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateXmlIndexStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
        public override void Visit(CreateXmlSchemaCollectionStatement statement) { base.Visit(statement); _DropStatements.Add(statement.GetDropStatement()); }
    }
}
