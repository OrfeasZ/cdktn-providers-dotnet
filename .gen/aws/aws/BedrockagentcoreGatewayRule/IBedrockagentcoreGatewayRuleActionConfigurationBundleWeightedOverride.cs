using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayRule
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverride), fullyQualifiedName: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverride")]
    public interface IBedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverride
    {
        /// <summary>traffic_split block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#traffic_split BedrockagentcoreGatewayRule#traffic_split}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverrideTrafficSplit" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "trafficSplit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverrideTrafficSplit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrafficSplit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverride), fullyQualifiedName: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverride")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>traffic_split block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#traffic_split BedrockagentcoreGatewayRule#traffic_split}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverrideTrafficSplit" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficSplit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionConfigurationBundleWeightedOverrideTrafficSplit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrafficSplit
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
