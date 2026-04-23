using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption")]
    public interface IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption
    {
        /// <summary>sse_kms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#sse_kms S3ControlStorageLensConfiguration#sse_kms}
        /// </remarks>
        [JsiiProperty(name: "sseKms", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms? SseKms
        {
            get
            {
                return null;
            }
        }

        /// <summary>sse_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#sse_s3 S3ControlStorageLensConfiguration#sse_s3}
        /// </remarks>
        [JsiiProperty(name: "sseS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SseS3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sse_kms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#sse_kms S3ControlStorageLensConfiguration#sse_kms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sseKms", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms\"}", isOptional: true)]
            public aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms? SseKms
            {
                get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseKms?>();
            }

            /// <summary>sse_s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#sse_s3 S3ControlStorageLensConfiguration#sse_s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sseS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportStorageLensTableDestinationEncryptionSseS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SseS3
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
