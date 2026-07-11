using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate")]
    public class VirtualNetworkGatewayVpnClientConfigurationRootCertificate : azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#name VirtualNetworkGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#public_cert_data VirtualNetworkGateway#public_cert_data}.</summary>
        [JsiiProperty(name: "publicCertData", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicCertData
        {
            get;
            set;
        }
    }
}
