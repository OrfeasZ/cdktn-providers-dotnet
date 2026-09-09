using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockModelInvocationJobInputDataConfigS3InputDataConfig), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfigS3InputDataConfig")]
    public interface IBedrockModelInvocationJobInputDataConfigS3InputDataConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_uri BedrockModelInvocationJob#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string S3Uri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_bucket_owner BedrockModelInvocationJob#s3_bucket_owner}.</summary>
        [JsiiProperty(name: "s3BucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BucketOwner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_input_format BedrockModelInvocationJob#s3_input_format}.</summary>
        [JsiiProperty(name: "s3InputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3InputFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockModelInvocationJobInputDataConfigS3InputDataConfig), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobInputDataConfigS3InputDataConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockModelInvocationJob.IBedrockModelInvocationJobInputDataConfigS3InputDataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_uri BedrockModelInvocationJob#s3_uri}.</summary>
            [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_bucket_owner BedrockModelInvocationJob#s3_bucket_owner}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3BucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BucketOwner
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_input_format BedrockModelInvocationJob#s3_input_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3InputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3InputFormat
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
