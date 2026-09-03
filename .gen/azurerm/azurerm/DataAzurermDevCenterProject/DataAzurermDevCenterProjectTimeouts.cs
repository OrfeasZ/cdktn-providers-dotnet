using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterProject
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterProject.DataAzurermDevCenterProjectTimeouts")]
    public class DataAzurermDevCenterProjectTimeouts : azurerm.DataAzurermDevCenterProject.IDataAzurermDevCenterProjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dev_center_project#read DataAzurermDevCenterProject#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
