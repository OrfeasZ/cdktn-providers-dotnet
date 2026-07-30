using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterGallery
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDevCenterGallery.DataAzurermDevCenterGalleryTimeouts")]
    public class DataAzurermDevCenterGalleryTimeouts : azurerm.DataAzurermDevCenterGallery.IDataAzurermDevCenterGalleryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/dev_center_gallery#read DataAzurermDevCenterGallery#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
