using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkIpAddressPool), fullyQualifiedName: "azurerm.virtualNetwork.VirtualNetworkIpAddressPool")]
    public interface IVirtualNetworkIpAddressPool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/virtual_network#id VirtualNetwork#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/virtual_network#number_of_ip_addresses VirtualNetwork#number_of_ip_addresses}.</summary>
        [JsiiProperty(name: "numberOfIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
        string NumberOfIpAddresses
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkIpAddressPool), fullyQualifiedName: "azurerm.virtualNetwork.VirtualNetworkIpAddressPool")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetwork.IVirtualNetworkIpAddressPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/virtual_network#id VirtualNetwork#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/virtual_network#number_of_ip_addresses VirtualNetwork#number_of_ip_addresses}.</summary>
            [JsiiProperty(name: "numberOfIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
            public string NumberOfIpAddresses
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
