using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms")]
    public interface IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#key_id S3ControlStorageLensConfiguration#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms")]
        internal sealed class _Proxy : DeputyBase, aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#key_id S3ControlStorageLensConfiguration#key_id}.</summary>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
