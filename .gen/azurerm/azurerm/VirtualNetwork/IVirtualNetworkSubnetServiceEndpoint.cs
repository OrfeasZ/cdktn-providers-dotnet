using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkSubnetServiceEndpoint), fullyQualifiedName: "azurerm.virtualNetwork.VirtualNetworkSubnetServiceEndpoint")]
    public interface IVirtualNetworkSubnetServiceEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/virtual_network#network_identifier VirtualNetwork#network_identifier}.</summary>
        [JsiiProperty(name: "networkIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/virtual_network#service VirtualNetwork#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Service
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkSubnetServiceEndpoint), fullyQualifiedName: "azurerm.virtualNetwork.VirtualNetworkSubnetServiceEndpoint")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetwork.IVirtualNetworkSubnetServiceEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/virtual_network#network_identifier VirtualNetwork#network_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/virtual_network#service VirtualNetwork#service}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Service
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
