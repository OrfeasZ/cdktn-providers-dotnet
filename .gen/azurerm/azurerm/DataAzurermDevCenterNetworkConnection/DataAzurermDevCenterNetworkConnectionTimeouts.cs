using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterNetworkConnection
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterNetworkConnection.DataAzurermDevCenterNetworkConnectionTimeouts")]
    public class DataAzurermDevCenterNetworkConnectionTimeouts : azurerm.DataAzurermDevCenterNetworkConnection.IDataAzurermDevCenterNetworkConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/dev_center_network_connection#read DataAzurermDevCenterNetworkConnection#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
