using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3VectorsIndex
{
    [JsiiByValue(fqn: "aws.s3VectorsIndex.S3VectorsIndexEncryptionConfiguration")]
    public class S3VectorsIndexEncryptionConfiguration : aws.S3VectorsIndex.IS3VectorsIndexEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3vectors_index#kms_key_arn S3VectorsIndex#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3vectors_index#sse_type S3VectorsIndex#sse_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SseType
        {
            get;
            set;
        }
    }
}
