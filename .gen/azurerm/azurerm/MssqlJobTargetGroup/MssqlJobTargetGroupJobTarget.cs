using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlJobTargetGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlJobTargetGroup.MssqlJobTargetGroupJobTarget")]
    public class MssqlJobTargetGroupJobTarget : azurerm.MssqlJobTargetGroup.IMssqlJobTargetGroupJobTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mssql_job_target_group#server_name MssqlJobTargetGroup#server_name}.</summary>
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mssql_job_target_group#database_name MssqlJobTargetGroup#database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mssql_job_target_group#elastic_pool_name MssqlJobTargetGroup#elastic_pool_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElasticPoolName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mssql_job_target_group#job_credential_id MssqlJobTargetGroup#job_credential_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobCredentialId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mssql_job_target_group#membership_type MssqlJobTargetGroup#membership_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "membershipType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MembershipType
        {
            get;
            set;
        }
    }
}
