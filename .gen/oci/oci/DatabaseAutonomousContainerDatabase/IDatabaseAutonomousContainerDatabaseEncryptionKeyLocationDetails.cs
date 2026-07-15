using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails), fullyQualifiedName: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails")]
    public interface IDatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_container_database#provider_type DatabaseAutonomousContainerDatabase#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_container_database#aws_encryption_key_id DatabaseAutonomousContainerDatabase#aws_encryption_key_id}.</summary>
        [JsiiProperty(name: "awsEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_container_database#azure_encryption_key_id DatabaseAutonomousContainerDatabase#azure_encryption_key_id}.</summary>
        [JsiiProperty(name: "azureEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzureEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_container_database#hsm_password DatabaseAutonomousContainerDatabase#hsm_password}.</summary>
        [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HsmPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails), fullyQualifiedName: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseEncryptionKeyLocationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_container_database#provider_type DatabaseAutonomousContainerDatabase#provider_type}.</summary>
            [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_container_database#aws_encryption_key_id DatabaseAutonomousContainerDatabase#aws_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_container_database#azure_encryption_key_id DatabaseAutonomousContainerDatabase#azure_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzureEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_autonomous_container_database#hsm_password DatabaseAutonomousContainerDatabase#hsm_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HsmPassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
