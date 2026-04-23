using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketMetadataConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration")]
    public interface IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#sse_algorithm S3BucketMetadataConfiguration#sse_algorithm}.</summary>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string SseAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#kms_key_arn S3BucketMetadataConfiguration#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.s3BucketMetadataConfiguration.S3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketMetadataConfiguration.IS3BucketMetadataConfigurationMetadataConfigurationInventoryTableConfigurationEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#sse_algorithm S3BucketMetadataConfiguration#sse_algorithm}.</summary>
            [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string SseAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3_bucket_metadata_configuration#kms_key_arn S3BucketMetadataConfiguration#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
