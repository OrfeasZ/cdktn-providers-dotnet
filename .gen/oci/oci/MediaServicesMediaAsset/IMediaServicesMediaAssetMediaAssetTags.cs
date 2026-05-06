using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MediaServicesMediaAsset
{
    [JsiiInterface(nativeType: typeof(IMediaServicesMediaAssetMediaAssetTags), fullyQualifiedName: "oci.mediaServicesMediaAsset.MediaServicesMediaAssetMediaAssetTags")]
    public interface IMediaServicesMediaAssetMediaAssetTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_asset#value MediaServicesMediaAsset#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_asset#type MediaServicesMediaAsset#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMediaServicesMediaAssetMediaAssetTags), fullyQualifiedName: "oci.mediaServicesMediaAsset.MediaServicesMediaAssetMediaAssetTags")]
        internal sealed class _Proxy : DeputyBase, oci.MediaServicesMediaAsset.IMediaServicesMediaAssetMediaAssetTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_asset#value MediaServicesMediaAsset#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_asset#type MediaServicesMediaAsset#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
