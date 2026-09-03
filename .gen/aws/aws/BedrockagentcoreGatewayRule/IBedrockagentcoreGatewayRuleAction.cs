using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayRule
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayRuleAction), fullyQualifiedName: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleAction")]
    public interface IBedrockagentcoreGatewayRuleAction
    {
        /// <summary>configuration_bundle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#configuration_bundle BedrockagentcoreGatewayRule#configuration_bundle}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleActionConfigurationBundle" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "configurationBundle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionConfigurationBundle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfigurationBundle
        {
            get
            {
                return null;
            }
        }

        /// <summary>route_to_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#route_to_target BedrockagentcoreGatewayRule#route_to_target}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleActionRouteToTarget" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "routeToTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionRouteToTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RouteToTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayRuleAction), fullyQualifiedName: "aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>configuration_bundle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#configuration_bundle BedrockagentcoreGatewayRule#configuration_bundle}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleActionConfigurationBundle" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configurationBundle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionConfigurationBundle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConfigurationBundle
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>route_to_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_rule#route_to_target BedrockagentcoreGatewayRule#route_to_target}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayRule.IBedrockagentcoreGatewayRuleActionRouteToTarget" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeToTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayRule.BedrockagentcoreGatewayRuleActionRouteToTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RouteToTarget
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
