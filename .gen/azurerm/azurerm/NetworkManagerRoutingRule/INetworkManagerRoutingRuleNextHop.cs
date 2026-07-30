using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerRoutingRule
{
    [JsiiInterface(nativeType: typeof(INetworkManagerRoutingRuleNextHop), fullyQualifiedName: "azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleNextHop")]
    public interface INetworkManagerRoutingRuleNextHop
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/network_manager_routing_rule#type NetworkManagerRoutingRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/network_manager_routing_rule#address NetworkManagerRoutingRule#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkManagerRoutingRuleNextHop), fullyQualifiedName: "azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleNextHop")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleNextHop
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/network_manager_routing_rule#type NetworkManagerRoutingRule#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/network_manager_routing_rule#address NetworkManagerRoutingRule#address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
