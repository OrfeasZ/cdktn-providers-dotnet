using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayBgpSettings), fullyQualifiedName: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings")]
    public interface IVirtualNetworkGatewayBgpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#asn VirtualNetworkGateway#asn}.</summary>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Asn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#peering_address VirtualNetworkGateway#peering_address}.</summary>
        [JsiiProperty(name: "peeringAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeeringAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#peer_weight VirtualNetworkGateway#peer_weight}.</summary>
        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeerWeight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayBgpSettings), fullyQualifiedName: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#asn VirtualNetworkGateway#asn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Asn
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#peering_address VirtualNetworkGateway#peering_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peeringAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeeringAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#peer_weight VirtualNetworkGateway#peer_weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeerWeight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
