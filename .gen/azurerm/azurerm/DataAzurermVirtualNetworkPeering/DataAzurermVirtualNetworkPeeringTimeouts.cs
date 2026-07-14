using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualNetworkPeering
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVirtualNetworkPeering.DataAzurermVirtualNetworkPeeringTimeouts")]
    public class DataAzurermVirtualNetworkPeeringTimeouts : azurerm.DataAzurermVirtualNetworkPeering.IDataAzurermVirtualNetworkPeeringTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/virtual_network_peering#read DataAzurermVirtualNetworkPeering#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
