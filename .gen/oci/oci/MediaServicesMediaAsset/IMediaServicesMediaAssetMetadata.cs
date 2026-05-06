using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MediaServicesMediaAsset
{
    [JsiiInterface(nativeType: typeof(IMediaServicesMediaAssetMetadata), fullyQualifiedName: "oci.mediaServicesMediaAsset.MediaServicesMediaAssetMetadata")]
    public interface IMediaServicesMediaAssetMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_asset#metadata MediaServicesMediaAsset#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        string Metadata
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMediaServicesMediaAssetMetadata), fullyQualifiedName: "oci.mediaServicesMediaAsset.MediaServicesMediaAssetMetadata")]
        internal sealed class _Proxy : DeputyBase, oci.MediaServicesMediaAsset.IMediaServicesMediaAssetMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_asset#metadata MediaServicesMediaAsset#metadata}.</summary>
            [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
            public string Metadata
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
