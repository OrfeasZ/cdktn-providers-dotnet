using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3 : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#bucket_owner_account_id BedrockagentcoreGatewayTarget#bucket_owner_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketOwnerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketOwnerAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#uri BedrockagentcoreGatewayTarget#uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uri
        {
            get;
            set;
        }
    }
}
