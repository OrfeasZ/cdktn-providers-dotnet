using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes")]
    public interface INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#destination NetworkfirewallRuleGroup#destination}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Destination
        {
            get
            {
                return null;
            }
        }

        /// <summary>destination_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#destination_port NetworkfirewallRuleGroup#destination_port}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "destinationPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DestinationPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#protocols NetworkfirewallRuleGroup#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? Protocols
        {
            get
            {
                return null;
            }
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#source NetworkfirewallRuleGroup#source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#source_port NetworkfirewallRuleGroup#source_port}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sourcePort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourcePort
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_flag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#tcp_flag NetworkfirewallRuleGroup#tcp_flag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tcpFlag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TcpFlag
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#destination NetworkfirewallRuleGroup#destination}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Destination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>destination_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#destination_port NetworkfirewallRuleGroup#destination_port}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DestinationPort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#protocols NetworkfirewallRuleGroup#protocols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? Protocols
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#source NetworkfirewallRuleGroup#source}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Source
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#source_port NetworkfirewallRuleGroup#source_port}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourcePort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tcp_flag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_rule_group#tcp_flag NetworkfirewallRuleGroup#tcp_flag}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpFlag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TcpFlag
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
