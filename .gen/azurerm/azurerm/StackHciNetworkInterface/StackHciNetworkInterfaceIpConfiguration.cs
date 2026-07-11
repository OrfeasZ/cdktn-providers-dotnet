using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciNetworkInterface
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciNetworkInterface.StackHciNetworkInterfaceIpConfiguration")]
    public class StackHciNetworkInterfaceIpConfiguration : azurerm.StackHciNetworkInterface.IStackHciNetworkInterfaceIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/stack_hci_network_interface#subnet_id StackHciNetworkInterface#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/stack_hci_network_interface#private_ip_address StackHciNetworkInterface#private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddress
        {
            get;
            set;
        }
    }
}
