using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificate")]
    public class VirtualNetworkGatewayVpnClientConfigurationRevokedCertificate : azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#name VirtualNetworkGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#thumbprint VirtualNetworkGateway#thumbprint}.</summary>
        [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public string Thumbprint
        {
            get;
            set;
        }
    }
}
