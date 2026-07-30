using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciNetworkInterface
{
    [JsiiInterface(nativeType: typeof(IStackHciNetworkInterfaceIpConfiguration), fullyQualifiedName: "azurerm.stackHciNetworkInterface.StackHciNetworkInterfaceIpConfiguration")]
    public interface IStackHciNetworkInterfaceIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_network_interface#subnet_id StackHciNetworkInterface#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_network_interface#private_ip_address StackHciNetworkInterface#private_ip_address}.</summary>
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateIpAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciNetworkInterfaceIpConfiguration), fullyQualifiedName: "azurerm.stackHciNetworkInterface.StackHciNetworkInterfaceIpConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciNetworkInterface.IStackHciNetworkInterfaceIpConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_network_interface#subnet_id StackHciNetworkInterface#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_network_interface#private_ip_address StackHciNetworkInterface#private_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateIpAddress
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
