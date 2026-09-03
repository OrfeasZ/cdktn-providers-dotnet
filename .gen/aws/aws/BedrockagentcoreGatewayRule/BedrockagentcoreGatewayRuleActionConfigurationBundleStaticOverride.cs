using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionConfigurationBundleStaticOverride")]
    public class BedrockagentcoreGatewayRuleActionConfigurationBundleStaticOverride : aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleActionConfigurationBundleStaticOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#bundle_arn BedrockagentcoreGatewayRule#bundle_arn}.</summary>
        [JsiiProperty(name: "bundleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BundleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#bundle_version BedrockagentcoreGatewayRule#bundle_version}.</summary>
        [JsiiProperty(name: "bundleVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string BundleVersion
        {
            get;
            set;
        }
    }
}
