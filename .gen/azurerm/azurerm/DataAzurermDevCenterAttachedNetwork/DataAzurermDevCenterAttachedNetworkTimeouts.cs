using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterAttachedNetwork
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterAttachedNetwork.DataAzurermDevCenterAttachedNetworkTimeouts")]
    public class DataAzurermDevCenterAttachedNetworkTimeouts : azurerm.DataAzurermDevCenterAttachedNetwork.IDataAzurermDevCenterAttachedNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/dev_center_attached_network#read DataAzurermDevCenterAttachedNetwork#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
