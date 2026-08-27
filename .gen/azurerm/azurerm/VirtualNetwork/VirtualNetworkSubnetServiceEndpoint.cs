using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetwork
{
    [JsiiByValue(fqn: "azurerm.virtualNetwork.VirtualNetworkSubnetServiceEndpoint")]
    public class VirtualNetworkSubnetServiceEndpoint : azurerm.VirtualNetwork.IVirtualNetworkSubnetServiceEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_network#network_identifier VirtualNetwork#network_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_network#service VirtualNetwork#service}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }
    }
}
