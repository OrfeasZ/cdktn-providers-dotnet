using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3VectorsVectorBucket
{
    [JsiiByValue(fqn: "aws.s3VectorsVectorBucket.S3VectorsVectorBucketEncryptionConfiguration")]
    public class S3VectorsVectorBucketEncryptionConfiguration : aws.S3VectorsVectorBucket.IS3VectorsVectorBucketEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3vectors_vector_bucket#kms_key_arn S3VectorsVectorBucket#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3vectors_vector_bucket#sse_type S3VectorsVectorBucket#sse_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SseType
        {
            get;
            set;
        }
    }
}
