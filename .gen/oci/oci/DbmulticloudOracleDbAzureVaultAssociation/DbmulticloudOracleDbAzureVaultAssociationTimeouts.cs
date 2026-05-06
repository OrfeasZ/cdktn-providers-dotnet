using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAzureVaultAssociation
{
    [JsiiByValue(fqn: "oci.dbmulticloudOracleDbAzureVaultAssociation.DbmulticloudOracleDbAzureVaultAssociationTimeouts")]
    public class DbmulticloudOracleDbAzureVaultAssociationTimeouts : oci.DbmulticloudOracleDbAzureVaultAssociation.IDbmulticloudOracleDbAzureVaultAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_vault_association#create DbmulticloudOracleDbAzureVaultAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_vault_association#delete DbmulticloudOracleDbAzureVaultAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_vault_association#update DbmulticloudOracleDbAzureVaultAssociation#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
