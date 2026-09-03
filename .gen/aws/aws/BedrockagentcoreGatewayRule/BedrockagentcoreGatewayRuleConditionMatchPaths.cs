using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPaths")]
    public class BedrockagentcoreGatewayRuleConditionMatchPaths : aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPaths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#any_of BedrockagentcoreGatewayRule#any_of}.</summary>
        [JsiiProperty(name: "anyOf", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AnyOf
        {
            get;
            set;
        }
    }
}
