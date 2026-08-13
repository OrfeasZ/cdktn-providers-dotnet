using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciMarketplaceGalleryImage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciMarketplaceGalleryImage.StackHciMarketplaceGalleryImageIdentifier")]
    public class StackHciMarketplaceGalleryImageIdentifier : azurerm.StackHciMarketplaceGalleryImage.IStackHciMarketplaceGalleryImageIdentifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/stack_hci_marketplace_gallery_image#offer StackHciMarketplaceGalleryImage#offer}.</summary>
        [JsiiProperty(name: "offer", typeJson: "{\"primitive\":\"string\"}")]
        public string Offer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/stack_hci_marketplace_gallery_image#publisher StackHciMarketplaceGalleryImage#publisher}.</summary>
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
        public string Publisher
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/stack_hci_marketplace_gallery_image#sku StackHciMarketplaceGalleryImage#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public string Sku
        {
            get;
            set;
        }
    }
}
