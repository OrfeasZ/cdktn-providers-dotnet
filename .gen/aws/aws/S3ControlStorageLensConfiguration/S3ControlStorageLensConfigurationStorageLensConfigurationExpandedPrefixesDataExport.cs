using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    [JsiiByValue(fqn: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport")]
    public class S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport : aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport
    {
        /// <summary>s3_bucket_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#s3_bucket_destination S3ControlStorageLensConfiguration#s3_bucket_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination\"}", isOptional: true)]
        public aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportS3BucketDestination? S3BucketDestination
        {
            get;
            set;
        }

        /// <summary>storage_lens_table_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_storage_lens_configuration#storage_lens_table_destination S3ControlStorageLensConfiguration#storage_lens_table_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageLensTableDestination", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination\"}", isOptional: true)]
        public aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportStorageLensTableDestination? StorageLensTableDestination
        {
            get;
            set;
        }
    }
}
