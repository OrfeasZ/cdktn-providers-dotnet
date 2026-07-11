using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    [JsiiByValue(fqn: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings")]
    public class VirtualNetworkGatewayBgpSettings : azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#asn VirtualNetworkGateway#asn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Asn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#peering_address VirtualNetworkGateway#peering_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peeringAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeeringAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#peer_weight VirtualNetworkGateway#peer_weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeerWeight
        {
            get;
            set;
        }
    }
}
