using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerRoutingRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkManagerRoutingRule.NetworkManagerRoutingRuleNextHop")]
    public class NetworkManagerRoutingRuleNextHop : azurerm.NetworkManagerRoutingRule.INetworkManagerRoutingRuleNextHop
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_routing_rule#type NetworkManagerRoutingRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_routing_rule#address NetworkManagerRoutingRule#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }
    }
}
