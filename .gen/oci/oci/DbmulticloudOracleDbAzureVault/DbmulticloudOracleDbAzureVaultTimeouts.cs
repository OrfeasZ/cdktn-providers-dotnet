using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAzureVault
{
    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbAzureVault.DbmulticloudOracleDbAzureVaultTimeouts")]
    public class DbmulticloudOracleDbAzureVaultTimeouts : oci.DbmulticloudOracleDbAzureVault.IDbmulticloudOracleDbAzureVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_vault#create DbmulticloudOracleDbAzureVault#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_vault#delete DbmulticloudOracleDbAzureVault#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_vault#update DbmulticloudOracleDbAzureVault#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
