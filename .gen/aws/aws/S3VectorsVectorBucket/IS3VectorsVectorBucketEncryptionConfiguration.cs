using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3VectorsVectorBucket
{
    [JsiiInterface(nativeType: typeof(IS3VectorsVectorBucketEncryptionConfiguration), fullyQualifiedName: "aws.s3VectorsVectorBucket.S3VectorsVectorBucketEncryptionConfiguration")]
    public interface IS3VectorsVectorBucketEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3vectors_vector_bucket#kms_key_arn S3VectorsVectorBucket#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3vectors_vector_bucket#sse_type S3VectorsVectorBucket#sse_type}.</summary>
        [JsiiProperty(name: "sseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SseType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3VectorsVectorBucketEncryptionConfiguration), fullyQualifiedName: "aws.s3VectorsVectorBucket.S3VectorsVectorBucketEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3VectorsVectorBucket.IS3VectorsVectorBucketEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3vectors_vector_bucket#kms_key_arn S3VectorsVectorBucket#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3vectors_vector_bucket#sse_type S3VectorsVectorBucket#sse_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SseType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
