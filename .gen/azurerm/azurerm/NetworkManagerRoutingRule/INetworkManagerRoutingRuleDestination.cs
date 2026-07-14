using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerRoutingRule
{
    [JsiiInterface(nativeType: typeof(INetworkManagerRoutingRuleDestination), fullyQualifiedName: "azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleDestination")]
    public interface INetworkManagerRoutingRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/network_manager_routing_rule#address NetworkManagerRoutingRule#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/network_manager_routing_rule#type NetworkManagerRoutingRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkManagerRoutingRuleDestination), fullyQualifiedName: "azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleDestination")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/network_manager_routing_rule#address NetworkManagerRoutingRule#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/network_manager_routing_rule#type NetworkManagerRoutingRule#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
