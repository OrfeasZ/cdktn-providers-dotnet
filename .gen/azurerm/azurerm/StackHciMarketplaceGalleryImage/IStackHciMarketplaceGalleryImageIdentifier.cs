using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciMarketplaceGalleryImage
{
    [JsiiInterface(nativeType: typeof(IStackHciMarketplaceGalleryImageIdentifier), fullyQualifiedName: "azurerm.stackHciMarketplaceGalleryImage.StackHciMarketplaceGalleryImageIdentifier")]
    public interface IStackHciMarketplaceGalleryImageIdentifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_marketplace_gallery_image#offer StackHciMarketplaceGalleryImage#offer}.</summary>
        [JsiiProperty(name: "offer", typeJson: "{\"primitive\":\"string\"}")]
        string Offer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_marketplace_gallery_image#publisher StackHciMarketplaceGalleryImage#publisher}.</summary>
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
        string Publisher
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_marketplace_gallery_image#sku StackHciMarketplaceGalleryImage#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        string Sku
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciMarketplaceGalleryImageIdentifier), fullyQualifiedName: "azurerm.stackHciMarketplaceGalleryImage.StackHciMarketplaceGalleryImageIdentifier")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciMarketplaceGalleryImage.IStackHciMarketplaceGalleryImageIdentifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_marketplace_gallery_image#offer StackHciMarketplaceGalleryImage#offer}.</summary>
            [JsiiProperty(name: "offer", typeJson: "{\"primitive\":\"string\"}")]
            public string Offer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_marketplace_gallery_image#publisher StackHciMarketplaceGalleryImage#publisher}.</summary>
            [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
            public string Publisher
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/stack_hci_marketplace_gallery_image#sku StackHciMarketplaceGalleryImage#sku}.</summary>
            [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
            public string Sku
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
