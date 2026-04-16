using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessCollection
{
    [JsiiInterface(nativeType: typeof(IOpensearchserverlessCollectionEncryptionConfig), fullyQualifiedName: "aws.opensearchserverlessCollection.OpensearchserverlessCollectionEncryptionConfig")]
    public interface IOpensearchserverlessCollectionEncryptionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection#aws_owned_key OpensearchserverlessCollection#aws_owned_key}.</summary>
        [JsiiProperty(name: "awsOwnedKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsOwnedKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection#kms_key_arn OpensearchserverlessCollection#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchserverlessCollectionEncryptionConfig), fullyQualifiedName: "aws.opensearchserverlessCollection.OpensearchserverlessCollectionEncryptionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchserverlessCollection.IOpensearchserverlessCollectionEncryptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection#aws_owned_key OpensearchserverlessCollection#aws_owned_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsOwnedKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AwsOwnedKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection#kms_key_arn OpensearchserverlessCollection#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
