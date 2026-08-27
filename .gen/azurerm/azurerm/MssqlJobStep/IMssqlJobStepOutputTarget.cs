using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlJobStep
{
    [JsiiInterface(nativeType: typeof(IMssqlJobStepOutputTarget), fullyQualifiedName: "azurerm.mssqlJobStep.MssqlJobStepOutputTarget")]
    public interface IMssqlJobStepOutputTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#mssql_database_id MssqlJobStep#mssql_database_id}.</summary>
        [JsiiProperty(name: "mssqlDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string MssqlDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#table_name MssqlJobStep#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#job_credential_id MssqlJobStep#job_credential_id}.</summary>
        [JsiiProperty(name: "jobCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobCredentialId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#schema_name MssqlJobStep#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchemaName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlJobStepOutputTarget), fullyQualifiedName: "azurerm.mssqlJobStep.MssqlJobStepOutputTarget")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlJobStep.IMssqlJobStepOutputTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#mssql_database_id MssqlJobStep#mssql_database_id}.</summary>
            [JsiiProperty(name: "mssqlDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string MssqlDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#table_name MssqlJobStep#table_name}.</summary>
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#job_credential_id MssqlJobStep#job_credential_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobCredentialId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/mssql_job_step#schema_name MssqlJobStep#schema_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchemaName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
