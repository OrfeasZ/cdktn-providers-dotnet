using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayRule
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayRuleConditionMatchPaths), fullyQualifiedName: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPaths")]
    public interface IBedrockagentcoreGatewayRuleConditionMatchPaths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_gateway_rule#any_of BedrockagentcoreGatewayRule#any_of}.</summary>
        [JsiiProperty(name: "anyOf", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AnyOf
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayRuleConditionMatchPaths), fullyQualifiedName: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleConditionMatchPaths")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleConditionMatchPaths
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_gateway_rule#any_of BedrockagentcoreGatewayRule#any_of}.</summary>
            [JsiiProperty(name: "anyOf", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AnyOf
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
