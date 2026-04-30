using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3VectorsIndex
{
    [JsiiInterface(nativeType: typeof(IS3VectorsIndexEncryptionConfiguration), fullyQualifiedName: "aws.s3VectorsIndex.S3VectorsIndexEncryptionConfiguration")]
    public interface IS3VectorsIndexEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3vectors_index#kms_key_arn S3VectorsIndex#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3vectors_index#sse_type S3VectorsIndex#sse_type}.</summary>
        [JsiiProperty(name: "sseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SseType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3VectorsIndexEncryptionConfiguration), fullyQualifiedName: "aws.s3VectorsIndex.S3VectorsIndexEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3VectorsIndex.IS3VectorsIndexEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3vectors_index#kms_key_arn S3VectorsIndex#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/s3vectors_index#sse_type S3VectorsIndex#sse_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SseType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
