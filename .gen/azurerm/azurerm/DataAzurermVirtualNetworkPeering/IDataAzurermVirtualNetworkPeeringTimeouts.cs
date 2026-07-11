using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualNetworkPeering
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualNetworkPeeringTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualNetworkPeering.DataAzurermVirtualNetworkPeeringTimeouts")]
    public interface IDataAzurermVirtualNetworkPeeringTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/virtual_network_peering#read DataAzurermVirtualNetworkPeering#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualNetworkPeeringTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualNetworkPeering.DataAzurermVirtualNetworkPeeringTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualNetworkPeering.IDataAzurermVirtualNetworkPeeringTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/virtual_network_peering#read DataAzurermVirtualNetworkPeering#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
