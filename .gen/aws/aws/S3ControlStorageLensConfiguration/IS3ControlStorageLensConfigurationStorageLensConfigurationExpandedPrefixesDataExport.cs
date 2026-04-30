using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport")]
    public interface IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport
    {
        /// <summary>s3_bucket_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3control_storage_lens_configuration#s3_bucket_destination S3ControlStorageLensConfiguration#s3_bucket_destination}
        /// </remarks>
        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination? S3BucketDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_lens_table_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3control_storage_lens_configuration#storage_lens_table_destination S3ControlStorageLensConfiguration#storage_lens_table_destination}
        /// </remarks>
        [JsiiProperty(name: "storageLensTableDestination", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination? StorageLensTableDestination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport")]
        internal sealed class _Proxy : DeputyBase, aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_bucket_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3control_storage_lens_configuration#s3_bucket_destination S3ControlStorageLensConfiguration#s3_bucket_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination\"}", isOptional: true)]
            public aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination? S3BucketDestination
            {
                get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination?>();
            }

            /// <summary>storage_lens_table_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3control_storage_lens_configuration#storage_lens_table_destination S3ControlStorageLensConfiguration#storage_lens_table_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageLensTableDestination", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination\"}", isOptional: true)]
            public aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination? StorageLensTableDestination
            {
                get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination?>();
            }
        }
    }
}
