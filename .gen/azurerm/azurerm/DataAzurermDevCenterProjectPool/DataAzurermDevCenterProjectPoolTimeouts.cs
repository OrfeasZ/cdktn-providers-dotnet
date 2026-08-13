using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterProjectPool
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterProjectPool.DataAzurermDevCenterProjectPoolTimeouts")]
    public class DataAzurermDevCenterProjectPoolTimeouts : azurerm.DataAzurermDevCenterProjectPool.IDataAzurermDevCenterProjectPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/dev_center_project_pool#read DataAzurermDevCenterProjectPool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
