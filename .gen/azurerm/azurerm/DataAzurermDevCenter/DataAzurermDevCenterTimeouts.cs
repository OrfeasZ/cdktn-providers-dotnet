using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenter
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenter.DataAzurermDevCenterTimeouts")]
    public class DataAzurermDevCenterTimeouts : azurerm.DataAzurermDevCenter.IDataAzurermDevCenterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dev_center#read DataAzurermDevCenter#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
