using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseDbHome.DatabaseDbHomeDatabaseEncryptionKeyLocationDetails")]
    public class DatabaseDbHomeDatabaseEncryptionKeyLocationDetails : oci.DatabaseDbHome.IDatabaseDbHomeDatabaseEncryptionKeyLocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#provider_type DatabaseDbHome#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProviderType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#azure_encryption_key_id DatabaseDbHome#azure_encryption_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzureEncryptionKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#hsm_password DatabaseDbHome#hsm_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HsmPassword
        {
            get;
            set;
        }
    }
}
