using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterCatalog
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterCatalog.DataAzurermDevCenterCatalogTimeouts")]
    public class DataAzurermDevCenterCatalogTimeouts : azurerm.DataAzurermDevCenterCatalog.IDataAzurermDevCenterCatalogTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dev_center_catalog#read DataAzurermDevCenterCatalog#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
