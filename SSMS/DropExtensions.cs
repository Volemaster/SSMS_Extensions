﻿using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.IO;
using System.Text;

namespace SSMS
{
    public static class DropExtensions
    {
        public static DropAggregateStatement GetDropStatement(this CreateAggregateStatement statement) => statement.GetDropStatement(true);
        public static DropAggregateStatement GetDropStatement(this CreateAggregateStatement statement, bool ifExists) => new DropAggregateStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropAssemblyStatement GetDropStatement(this CreateAssemblyStatement statement) => statement.GetDropStatement(true);
        public static DropAssemblyStatement GetDropStatement(this CreateAssemblyStatement statement, bool ifExists) => new DropAssemblyStatement() { Objects = { new SchemaObjectNameSnippet() { Script = Identifier.EncodeIdentifier(statement.Name.Value, QuoteType.DoubleQuote) } }, IsIfExists = ifExists };
        public static DropDefaultStatement GetDropStatement(this CreateDefaultStatement statement) => statement.GetDropStatement(true);
        public static DropDefaultStatement GetDropStatement(this CreateDefaultStatement statement, bool ifExists) => new DropDefaultStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropExternalTableStatement GetDropStatement(this CreateExternalTableStatement statement) => statement.GetDropStatement(true);
        public static DropExternalTableStatement GetDropStatement(this CreateExternalTableStatement statement, bool ifExists) => new DropExternalTableStatement() { Objects = { statement.SchemaObjectName }, IsIfExists = ifExists };
        public static DropFunctionStatement GetDropStatement(this CreateFunctionStatement statement) => statement.GetDropStatement(true);
        public static DropFunctionStatement GetDropStatement(this CreateFunctionStatement statement, bool ifExists) => new DropFunctionStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropFunctionStatement GetDropStatement(this CreateOrAlterFunctionStatement statement) => statement.GetDropStatement(true);
        public static DropFunctionStatement GetDropStatement(this CreateOrAlterFunctionStatement statement, bool ifExists) => new DropFunctionStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropProcedureStatement GetDropStatement(this CreateProcedureStatement statement) => statement.GetDropStatement(true);
        public static DropProcedureStatement GetDropStatement(this CreateProcedureStatement statement, bool ifExists) => new DropProcedureStatement() { Objects = { statement.ProcedureReference.Name }, IsIfExists = ifExists };
        public static DropProcedureStatement GetDropStatement(this CreateOrAlterProcedureStatement statement) => statement.GetDropStatement(true);
        public static DropProcedureStatement GetDropStatement(this CreateOrAlterProcedureStatement statement, bool ifExists) => new DropProcedureStatement() { Objects = { statement.ProcedureReference.Name }, IsIfExists = ifExists };
        public static DropRuleStatement GetDropStatement(this CreateRuleStatement statement) => statement.GetDropStatement(true);
        public static DropRuleStatement GetDropStatement(this CreateRuleStatement statement, bool ifExists) => new DropRuleStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropSecurityPolicyStatement GetDropStatement(this CreateSecurityPolicyStatement statement) => statement.GetDropStatement(true);
        public static DropSecurityPolicyStatement GetDropStatement(this CreateSecurityPolicyStatement statement, bool ifExists) => new DropSecurityPolicyStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropSequenceStatement GetDropStatement(this CreateSequenceStatement statement) => statement.GetDropStatement(true);
        public static DropSequenceStatement GetDropStatement(this CreateSequenceStatement statement, bool ifExists) => new DropSequenceStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropSynonymStatement GetDropStatement(this CreateSynonymStatement statement) => statement.GetDropStatement(true);
        public static DropSynonymStatement GetDropStatement(this CreateSynonymStatement statement, bool ifExists) => new DropSynonymStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropTableStatement GetDropStatement(this CreateTableStatement statement) => statement.GetDropStatement(true);
        public static DropTableStatement GetDropStatement(this CreateTableStatement statement, bool ifExists) => new DropTableStatement() { Objects = { statement.SchemaObjectName }, IsIfExists = ifExists };
        public static DropTriggerStatement GetDropStatement(this CreateTriggerStatement statement) => statement.GetDropStatement(true);
        public static DropTriggerStatement GetDropStatement(this CreateTriggerStatement statement, bool ifExists) => new DropTriggerStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropTriggerStatement GetDropStatement(this CreateOrAlterTriggerStatement statement) => statement.GetDropStatement(true);
        public static DropTriggerStatement GetDropStatement(this CreateOrAlterTriggerStatement statement, bool ifExists) => new DropTriggerStatement() { Objects = { statement.Name }, IsIfExists = ifExists };
        public static DropViewStatement GetDropStatement(this CreateViewStatement statement) => statement.GetDropStatement(true);
        public static DropViewStatement GetDropStatement(this CreateViewStatement statement, bool ifExists) => new DropViewStatement() { Objects = { statement.SchemaObjectName }, IsIfExists = ifExists };
        public static DropViewStatement GetDropStatement(this CreateOrAlterViewStatement statement) => statement.GetDropStatement(true);
        public static DropViewStatement GetDropStatement(this CreateOrAlterViewStatement statement, bool ifExists) => new DropViewStatement() { Objects = { statement.SchemaObjectName }, IsIfExists = ifExists };

        public static DropApplicationRoleStatement GetDropStatement(this CreateApplicationRoleStatement statement) => statement.GetDropStatement(true);
        public static DropApplicationRoleStatement GetDropStatement(this CreateApplicationRoleStatement statement, bool ifExists) => new DropApplicationRoleStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropAsymmetricKeyStatement GetDropStatement(this CreateAsymmetricKeyStatement statement) => statement.GetDropStatement(true);
        public static DropAsymmetricKeyStatement GetDropStatement(this CreateAsymmetricKeyStatement statement, bool ifExists) => new DropAsymmetricKeyStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropAvailabilityGroupStatement GetDropStatement(this CreateAvailabilityGroupStatement statement) => statement.GetDropStatement(true);
        public static DropAvailabilityGroupStatement GetDropStatement(this CreateAvailabilityGroupStatement statement, bool ifExists) => new DropAvailabilityGroupStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropBrokerPriorityStatement GetDropStatement(this CreateBrokerPriorityStatement statement) => statement.GetDropStatement(true);
        public static DropBrokerPriorityStatement GetDropStatement(this CreateBrokerPriorityStatement statement, bool ifExists) => new DropBrokerPriorityStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropCertificateStatement GetDropStatement(this CreateCertificateStatement statement) => statement.GetDropStatement(true);
        public static DropCertificateStatement GetDropStatement(this CreateCertificateStatement statement, bool ifExists) => new DropCertificateStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropColumnEncryptionKeyStatement GetDropStatement(this CreateColumnEncryptionKeyStatement statement) => statement.GetDropStatement(true);
        public static DropColumnEncryptionKeyStatement GetDropStatement(this CreateColumnEncryptionKeyStatement statement, bool ifExists) => new DropColumnEncryptionKeyStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropColumnMasterKeyStatement GetDropStatement(this CreateColumnMasterKeyStatement statement) => statement.GetDropStatement(true);
        public static DropColumnMasterKeyStatement GetDropStatement(this CreateColumnMasterKeyStatement statement, bool ifExists) => new DropColumnMasterKeyStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropIndexStatement GetDropStatement(this CreateColumnStoreIndexStatement statement) => statement.GetDropStatement(true);
        public static DropIndexStatement GetDropStatement(this CreateColumnStoreIndexStatement statement, bool ifExists) => new DropIndexStatement() { DropIndexClauses = { new DropIndexClause() { Index = statement.Name, Object = statement.OnName } }, IsIfExists = ifExists };
        public static DropContractStatement GetDropStatement(this CreateContractStatement statement) => statement.GetDropStatement(true);
        public static DropContractStatement GetDropStatement(this CreateContractStatement statement, bool ifExists) => new DropContractStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropCredentialStatement GetDropStatement(this CreateCredentialStatement statement) => statement.GetDropStatement(true);
        public static DropCredentialStatement GetDropStatement(this CreateCredentialStatement statement, bool ifExists) => new DropCredentialStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropCryptographicProviderStatement GetDropStatement(this CreateCryptographicProviderStatement statement) => statement.GetDropStatement(true);
        public static DropCryptographicProviderStatement GetDropStatement(this CreateCryptographicProviderStatement statement, bool ifExists) => new DropCryptographicProviderStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropDatabaseAuditSpecificationStatement GetDropStatement(this CreateDatabaseAuditSpecificationStatement statement) => statement.GetDropStatement(true);
        public static DropDatabaseAuditSpecificationStatement GetDropStatement(this CreateDatabaseAuditSpecificationStatement statement, bool ifExists) => new DropDatabaseAuditSpecificationStatement() { Name = statement.SpecificationName, IsIfExists = ifExists };
        public static DropDatabaseEncryptionKeyStatement GetDropStatement(this CreateDatabaseEncryptionKeyStatement statement) => new DropDatabaseEncryptionKeyStatement();
        public static DropDatabaseStatement GetDropStatement(this CreateDatabaseStatement statement) => statement.GetDropStatement(true);
        public static DropDatabaseStatement GetDropStatement(this CreateDatabaseStatement statement, bool ifExists) => new DropDatabaseStatement() { Databases = { statement.DatabaseName }, IsIfExists = ifExists };
        public static DropEndpointStatement GetDropStatement(this CreateEndpointStatement statement) => statement.GetDropStatement(true);
        public static DropEndpointStatement GetDropStatement(this CreateEndpointStatement statement, bool ifExists) => new DropEndpointStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropEventNotificationStatement GetDropStatement(this CreateEventNotificationStatement statement) => statement.GetDropStatement(true);
        public static DropEventNotificationStatement GetDropStatement(this CreateEventNotificationStatement statement, bool ifExists) => new DropEventNotificationStatement() { Notifications = { statement.Name }};
        public static DropEventSessionStatement GetDropStatement(this CreateEventSessionStatement statement) => statement.GetDropStatement(true);
        public static DropEventSessionStatement GetDropStatement(this CreateEventSessionStatement statement, bool ifExists) => new DropEventSessionStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropExternalDataSourceStatement GetDropStatement(this CreateExternalDataSourceStatement statement) => statement.GetDropStatement(true);
        public static DropExternalDataSourceStatement GetDropStatement(this CreateExternalDataSourceStatement statement, bool ifExists) => new DropExternalDataSourceStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropExternalFileFormatStatement GetDropStatement(this CreateExternalFileFormatStatement statement) => statement.GetDropStatement(true);
        public static DropExternalFileFormatStatement GetDropStatement(this CreateExternalFileFormatStatement statement, bool ifExists) => new DropExternalFileFormatStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropExternalLanguageStatement GetDropStatement(this CreateExternalLanguageStatement statement) => statement.GetDropStatement(true);
        public static DropExternalLanguageStatement GetDropStatement(this CreateExternalLanguageStatement statement, bool ifExists) => new DropExternalLanguageStatement() { Name = statement.Name};
        public static DropExternalLibraryStatement GetDropStatement(this CreateExternalLibraryStatement statement) => statement.GetDropStatement(true);
        public static DropExternalLibraryStatement GetDropStatement(this CreateExternalLibraryStatement statement, bool ifExists) => new DropExternalLibraryStatement() { Name = statement.Name };
        public static DropExternalResourcePoolStatement GetDropStatement(this CreateExternalResourcePoolStatement statement) => statement.GetDropStatement(true);
        public static DropExternalResourcePoolStatement GetDropStatement(this CreateExternalResourcePoolStatement statement, bool ifExists) => new DropExternalResourcePoolStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropExternalStreamingJobStatement GetDropStatement(this CreateExternalStreamingJobStatement statement) => statement.GetDropStatement(true);
        public static DropExternalStreamingJobStatement GetDropStatement(this CreateExternalStreamingJobStatement statement, bool ifExists) => new DropExternalStreamingJobStatement() { Name = new Identifier() { Value = statement.Name.Value }, IsIfExists = ifExists };
        public static DropExternalStreamStatement GetDropStatement(this CreateExternalStreamStatement statement) => statement.GetDropStatement(true);
        public static DropExternalStreamStatement GetDropStatement(this CreateExternalStreamStatement statement, bool ifExists) => new DropExternalStreamStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropFederationStatement GetDropStatement(this CreateFederationStatement statement) => statement.GetDropStatement(true);
        public static DropFederationStatement GetDropStatement(this CreateFederationStatement statement, bool ifExists) => new DropFederationStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropFullTextCatalogStatement GetDropStatement(this CreateFullTextCatalogStatement statement) => statement.GetDropStatement(true);
        public static DropFullTextCatalogStatement GetDropStatement(this CreateFullTextCatalogStatement statement, bool ifExists) => new DropFullTextCatalogStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropFullTextIndexStatement GetDropStatement(this CreateFullTextIndexStatement statement) => statement.GetDropStatement(true);
        public static DropFullTextIndexStatement GetDropStatement(this CreateFullTextIndexStatement statement, bool ifExists) => new DropFullTextIndexStatement() { TableName = statement.OnName };
        public static DropFullTextStopListStatement GetDropStatement(this CreateFullTextStopListStatement statement) => statement.GetDropStatement(true);
        public static DropFullTextStopListStatement GetDropStatement(this CreateFullTextStopListStatement statement, bool ifExists) => new DropFullTextStopListStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropIndexStatement GetDropStatement(this CreateIndexStatement statement) => statement.GetDropStatement(true);
        public static DropIndexStatement GetDropStatement(this CreateIndexStatement statement, bool ifExists) => new DropIndexStatement() { DropIndexClauses = { new DropIndexClause { Index = statement.Name, Object = statement.OnName } }, IsIfExists = ifExists };
        public static DropLoginStatement GetDropStatement(this CreateLoginStatement statement) => statement.GetDropStatement(true);
        public static DropLoginStatement GetDropStatement(this CreateLoginStatement statement, bool ifExists) => new DropLoginStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropMasterKeyStatement GetDropStatement(this CreateMasterKeyStatement statement) => new DropMasterKeyStatement();
        public static DropMessageTypeStatement GetDropStatement(this CreateMessageTypeStatement statement) => statement.GetDropStatement(true);
        public static DropMessageTypeStatement GetDropStatement(this CreateMessageTypeStatement statement, bool ifExists) => new DropMessageTypeStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropPartitionFunctionStatement GetDropStatement(this CreatePartitionFunctionStatement statement) => statement.GetDropStatement(true);
        public static DropPartitionFunctionStatement GetDropStatement(this CreatePartitionFunctionStatement statement, bool ifExists) => new DropPartitionFunctionStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropPartitionSchemeStatement GetDropStatement(this CreatePartitionSchemeStatement statement) => statement.GetDropStatement(true);
        public static DropPartitionSchemeStatement GetDropStatement(this CreatePartitionSchemeStatement statement, bool ifExists) => new DropPartitionSchemeStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropQueueStatement GetDropStatement(this CreateQueueStatement statement) => statement.GetDropStatement(true);
        public static DropQueueStatement GetDropStatement(this CreateQueueStatement statement, bool ifExists) => new DropQueueStatement() { Name = statement.Name };
        public static DropRemoteServiceBindingStatement GetDropStatement(this CreateRemoteServiceBindingStatement statement) => statement.GetDropStatement(true);
        public static DropRemoteServiceBindingStatement GetDropStatement(this CreateRemoteServiceBindingStatement statement, bool ifExists) => new DropRemoteServiceBindingStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropResourcePoolStatement GetDropStatement(this CreateResourcePoolStatement statement) => statement.GetDropStatement(true);
        public static DropResourcePoolStatement GetDropStatement(this CreateResourcePoolStatement statement, bool ifExists) => new DropResourcePoolStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropRoleStatement GetDropStatement(this CreateRoleStatement statement) => statement.GetDropStatement(true);
        public static DropRoleStatement GetDropStatement(this CreateRoleStatement statement, bool ifExists) => new DropRoleStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropRouteStatement GetDropStatement(this CreateRouteStatement statement) => statement.GetDropStatement(true);
        public static DropRouteStatement GetDropStatement(this CreateRouteStatement statement, bool ifExists) => new DropRouteStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropSchemaStatement GetDropStatement(this CreateSchemaStatement statement) => statement.GetDropStatement(true);
        public static DropSchemaStatement GetDropStatement(this CreateSchemaStatement statement, bool ifExists) => new DropSchemaStatement() { Schema = new SchemaObjectNameSnippet() { Script = Identifier.EncodeIdentifier(statement.Name.Value, QuoteType.DoubleQuote) }, IsIfExists = ifExists };
        public static DropSearchPropertyListStatement GetDropStatement(this CreateSearchPropertyListStatement statement) => statement.GetDropStatement(true);
        public static DropSearchPropertyListStatement GetDropStatement(this CreateSearchPropertyListStatement statement, bool ifExists) => new DropSearchPropertyListStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropIndexStatement GetDropStatement(this CreateSelectiveXmlIndexStatement statement) => statement.GetDropStatement(true);
        public static DropIndexStatement GetDropStatement(this CreateSelectiveXmlIndexStatement statement, bool ifExists) => new DropIndexStatement() { DropIndexClauses = { new DropIndexClause() { Index = statement.Name, Object = statement.OnName } }, IsIfExists = ifExists };
        public static DropServerAuditSpecificationStatement GetDropStatement(this CreateServerAuditSpecificationStatement statement) => statement.GetDropStatement(true);
        public static DropServerAuditSpecificationStatement GetDropStatement(this CreateServerAuditSpecificationStatement statement, bool ifExists) => new DropServerAuditSpecificationStatement() { Name = statement.SpecificationName, IsIfExists = ifExists };
        public static DropServerAuditStatement GetDropStatement(this CreateServerAuditStatement statement) => statement.GetDropStatement(true);
        public static DropServerAuditStatement GetDropStatement(this CreateServerAuditStatement statement, bool ifExists) => new DropServerAuditStatement() { Name = statement.AuditName, IsIfExists = ifExists };
        public static DropServerRoleStatement GetDropStatement(this CreateServerRoleStatement statement) => statement.GetDropStatement(true);
        public static DropServerRoleStatement GetDropStatement(this CreateServerRoleStatement statement, bool ifExists) => new DropServerRoleStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropServiceStatement GetDropStatement(this CreateServiceStatement statement) => statement.GetDropStatement(true);
        public static DropServiceStatement GetDropStatement(this CreateServiceStatement statement, bool ifExists) => new DropServiceStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropIndexStatement GetDropStatement(this CreateSpatialIndexStatement statement) => statement.GetDropStatement(true);
        public static DropIndexStatement GetDropStatement(this CreateSpatialIndexStatement statement, bool ifExists) => new DropIndexStatement() { DropIndexClauses = { new DropIndexClause() { Index = statement.Name, Object = statement.Object } }, IsIfExists = ifExists };
        public static ChildObjectName GetChildIdentifier(this SchemaObjectName schemaObjectName, Identifier childIdentifier) => schemaObjectName.GetChildIdentifier(childIdentifier, new TSql160Parser(true, SqlEngineType.Standalone));
        public static ChildObjectName GetChildIdentifier(this SchemaObjectName schemaObjectName, Identifier childIdentifier, TSqlParser parser) => schemaObjectName.GetChildIdentifier(childIdentifier.Value, parser);
        public static ChildObjectName GetChildIdentifier(this SchemaObjectName schemaObjectName, string childIdentifier, TSqlParser parser)
        {
            var c = new CreateAggregateStatement();
            var sb = new StringBuilder();
            for (int i = 0; i < schemaObjectName.Identifiers.Count; i++)
            {
                if (i > 0) sb.Append(".");
                sb.Append(Identifier.EncodeIdentifier(schemaObjectName.Identifiers[i].Value, QuoteType.DoubleQuote));
            }
            sb.Append(".").Append(Identifier.EncodeIdentifier(childIdentifier, QuoteType.DoubleQuote));
            return parser.ParseChildObjectName(new StringReader(sb.ToString()), out var errors);
        }
        public static DropStatisticsStatement GetDropStatement(this CreateStatisticsStatement statement) => statement.GetDropStatement(true);
        public static DropStatisticsStatement GetDropStatement(this CreateStatisticsStatement statement, bool ifExists) => new DropStatisticsStatement() { Objects = { statement.OnName.GetChildIdentifier(statement.Name) } };

        public static DropSymmetricKeyStatement GetDropStatement(this CreateSymmetricKeyStatement statement) => statement.GetDropStatement(true);
        public static DropSymmetricKeyStatement GetDropStatement(this CreateSymmetricKeyStatement statement, bool ifExists) => new DropSymmetricKeyStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropTypeStatement GetDropStatement(this CreateTypeStatement statement) => statement.GetDropStatement(true);
        public static DropTypeStatement GetDropStatement(this CreateTypeStatement statement, bool ifExists) => new DropTypeStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropTypeStatement GetDropStatement(this CreateTypeTableStatement statement) => statement.GetDropStatement(true);
        public static DropTypeStatement GetDropStatement(this CreateTypeTableStatement statement, bool ifExists) => new DropTypeStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropTypeStatement GetDropStatement(this CreateTypeUddtStatement statement) => statement.GetDropStatement(true);
        public static DropTypeStatement GetDropStatement(this CreateTypeUddtStatement statement, bool ifExists) => new DropTypeStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropTypeStatement GetDropStatement(this CreateTypeUdtStatement statement) => statement.GetDropStatement(true);
        public static DropTypeStatement GetDropStatement(this CreateTypeUdtStatement statement, bool ifExists) => new DropTypeStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropUserStatement GetDropStatement(this CreateUserStatement statement) => statement.GetDropStatement(true);
        public static DropUserStatement GetDropStatement(this CreateUserStatement statement, bool ifExists) => new DropUserStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropWorkloadClassifierStatement GetDropStatement(this CreateWorkloadClassifierStatement statement) => statement.GetDropStatement(true);
        public static DropWorkloadClassifierStatement GetDropStatement(this CreateWorkloadClassifierStatement statement, bool ifExists) => new DropWorkloadClassifierStatement() { Name = statement.ClassifierName, IsIfExists = ifExists };
        public static DropWorkloadGroupStatement GetDropStatement(this CreateWorkloadGroupStatement statement) => statement.GetDropStatement(true);
        public static DropWorkloadGroupStatement GetDropStatement(this CreateWorkloadGroupStatement statement, bool ifExists) => new DropWorkloadGroupStatement() { Name = statement.Name, IsIfExists = ifExists };
        public static DropIndexStatement GetDropStatement(this CreateXmlIndexStatement statement) => statement.GetDropStatement(true);
        public static DropIndexStatement GetDropStatement(this CreateXmlIndexStatement statement, bool ifExists) => new DropIndexStatement() { DropIndexClauses = { new DropIndexClause() { Object = statement.OnName, Index = statement.Name } }, IsIfExists = ifExists };
        public static DropXmlSchemaCollectionStatement GetDropStatement(this CreateXmlSchemaCollectionStatement statement) => statement.GetDropStatement(true);
        public static DropXmlSchemaCollectionStatement GetDropStatement(this CreateXmlSchemaCollectionStatement statement, bool ifExists) => new DropXmlSchemaCollectionStatement() { Name = statement.Name };
    }
}
