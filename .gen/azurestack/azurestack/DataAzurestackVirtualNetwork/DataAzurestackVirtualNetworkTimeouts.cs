using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackVirtualNetwork
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackVirtualNetwork.DataAzurestackVirtualNetworkTimeouts")]
    public class DataAzurestackVirtualNetworkTimeouts : azurestack.DataAzurestackVirtualNetwork.IDataAzurestackVirtualNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/virtual_network#read DataAzurestackVirtualNetwork#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
