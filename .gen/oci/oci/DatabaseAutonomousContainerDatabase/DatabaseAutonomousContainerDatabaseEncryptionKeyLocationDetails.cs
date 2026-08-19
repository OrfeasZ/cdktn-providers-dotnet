using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails")]
    public class DatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails : oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_autonomous_container_database#provider_type DatabaseAutonomousContainerDatabase#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProviderType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_autonomous_container_database#aws_encryption_key_id DatabaseAutonomousContainerDatabase#aws_encryption_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AwsEncryptionKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_autonomous_container_database#azure_encryption_key_id DatabaseAutonomousContainerDatabase#azure_encryption_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzureEncryptionKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_autonomous_container_database#hsm_password DatabaseAutonomousContainerDatabase#hsm_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HsmPassword
        {
            get;
            set;
        }
    }
}
