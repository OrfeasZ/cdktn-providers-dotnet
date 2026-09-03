using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciLogicalNetwork
{
    [JsiiInterface(nativeType: typeof(IStackHciLogicalNetworkSubnetRoute), fullyQualifiedName: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRoute")]
    public interface IStackHciLogicalNetworkSubnetRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#address_prefix StackHciLogicalNetwork#address_prefix}.</summary>
        [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        string AddressPrefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#next_hop_ip_address StackHciLogicalNetwork#next_hop_ip_address}.</summary>
        [JsiiProperty(name: "nextHopIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        string NextHopIpAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#name StackHciLogicalNetwork#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciLogicalNetworkSubnetRoute), fullyQualifiedName: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRoute")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#address_prefix StackHciLogicalNetwork#address_prefix}.</summary>
            [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressPrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#next_hop_ip_address StackHciLogicalNetwork#next_hop_ip_address}.</summary>
            [JsiiProperty(name: "nextHopIpAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string NextHopIpAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_logical_network#name StackHciLogicalNetwork#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
