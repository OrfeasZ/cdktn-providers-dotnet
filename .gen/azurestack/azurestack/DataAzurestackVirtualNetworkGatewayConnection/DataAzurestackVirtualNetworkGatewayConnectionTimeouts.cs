using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackVirtualNetworkGatewayConnection
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackVirtualNetworkGatewayConnection.DataAzurestackVirtualNetworkGatewayConnectionTimeouts")]
    public class DataAzurestackVirtualNetworkGatewayConnectionTimeouts : azurestack.DataAzurestackVirtualNetworkGatewayConnection.IDataAzurestackVirtualNetworkGatewayConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/virtual_network_gateway_connection#read DataAzurestackVirtualNetworkGatewayConnection#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
