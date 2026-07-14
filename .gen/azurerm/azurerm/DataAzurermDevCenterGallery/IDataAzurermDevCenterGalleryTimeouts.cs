using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterGallery
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDevCenterGalleryTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterGallery.DataAzurermDevCenterGalleryTimeouts")]
    public interface IDataAzurermDevCenterGalleryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/dev_center_gallery#read DataAzurermDevCenterGallery#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDevCenterGalleryTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterGallery.DataAzurermDevCenterGalleryTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDevCenterGallery.IDataAzurermDevCenterGalleryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/dev_center_gallery#read DataAzurermDevCenterGallery#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
