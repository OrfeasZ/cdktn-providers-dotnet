using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobOutputDataConfigS3OutputDataConfig")]
    public class BedrockModelInvocationJobOutputDataConfigS3OutputDataConfig : aws.BedrockModelInvocationJob.IBedrockModelInvocationJobOutputDataConfigS3OutputDataConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_uri BedrockModelInvocationJob#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_bucket_owner BedrockModelInvocationJob#s3_bucket_owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BucketOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3BucketOwner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#s3_encryption_key_id BedrockModelInvocationJob#s3_encryption_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3EncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3EncryptionKeyId
        {
            get;
            set;
        }
    }
}
