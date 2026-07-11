using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackLocalNetworkGateway
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackLocalNetworkGateway.DataAzurestackLocalNetworkGatewayTimeouts")]
    public class DataAzurestackLocalNetworkGatewayTimeouts : azurestack.DataAzurestackLocalNetworkGateway.IDataAzurestackLocalNetworkGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/local_network_gateway#read DataAzurestackLocalNetworkGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
