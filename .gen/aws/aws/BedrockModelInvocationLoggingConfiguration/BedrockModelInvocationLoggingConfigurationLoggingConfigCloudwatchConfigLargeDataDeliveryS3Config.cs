using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationLoggingConfigCloudwatchConfigLargeDataDeliveryS3Config")]
    public class BedrockModelInvocationLoggingConfigurationLoggingConfigCloudwatchConfigLargeDataDeliveryS3Config : aws.BedrockModelInvocationLoggingConfiguration.IBedrockModelInvocationLoggingConfigurationLoggingConfigCloudwatchConfigLargeDataDeliveryS3Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#bucket_name BedrockModelInvocationLoggingConfiguration#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#key_prefix BedrockModelInvocationLoggingConfiguration#key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyPrefix
        {
            get;
            set;
        }
    }
}
