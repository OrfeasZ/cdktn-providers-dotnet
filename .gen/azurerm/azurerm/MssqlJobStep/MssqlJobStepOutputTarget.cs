using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlJobStep
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlJobStep.MssqlJobStepOutputTarget")]
    public class MssqlJobStepOutputTarget : azurerm.MssqlJobStep.IMssqlJobStepOutputTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_job_step#mssql_database_id MssqlJobStep#mssql_database_id}.</summary>
        [JsiiProperty(name: "mssqlDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string MssqlDatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_job_step#table_name MssqlJobStep#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public string TableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_job_step#job_credential_id MssqlJobStep#job_credential_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobCredentialId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_job_step#schema_name MssqlJobStep#schema_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchemaName
        {
            get;
            set;
        }
    }
}
