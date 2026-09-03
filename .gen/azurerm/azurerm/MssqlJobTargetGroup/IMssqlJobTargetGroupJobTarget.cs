using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlJobTargetGroup
{
    [JsiiInterface(nativeType: typeof(IMssqlJobTargetGroupJobTarget), fullyQualifiedName: "azurerm.mssqlJobTargetGroup.MssqlJobTargetGroupJobTarget")]
    public interface IMssqlJobTargetGroupJobTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#server_name MssqlJobTargetGroup#server_name}.</summary>
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        string ServerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#database_name MssqlJobTargetGroup#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#elastic_pool_name MssqlJobTargetGroup#elastic_pool_name}.</summary>
        [JsiiProperty(name: "elasticPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElasticPoolName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#job_credential_id MssqlJobTargetGroup#job_credential_id}.</summary>
        [JsiiProperty(name: "jobCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobCredentialId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#membership_type MssqlJobTargetGroup#membership_type}.</summary>
        [JsiiProperty(name: "membershipType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MembershipType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlJobTargetGroupJobTarget), fullyQualifiedName: "azurerm.mssqlJobTargetGroup.MssqlJobTargetGroupJobTarget")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlJobTargetGroup.IMssqlJobTargetGroupJobTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#server_name MssqlJobTargetGroup#server_name}.</summary>
            [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#database_name MssqlJobTargetGroup#database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#elastic_pool_name MssqlJobTargetGroup#elastic_pool_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElasticPoolName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#job_credential_id MssqlJobTargetGroup#job_credential_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobCredentialId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_job_target_group#membership_type MssqlJobTargetGroup#membership_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "membershipType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MembershipType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
