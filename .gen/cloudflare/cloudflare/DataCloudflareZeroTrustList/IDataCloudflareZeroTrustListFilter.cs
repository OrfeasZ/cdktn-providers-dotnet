using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustList
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustListFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustList.DataCloudflareZeroTrustListFilter")]
    public interface IDataCloudflareZeroTrustListFilter
    {
        /// <summary>Specify the list type. Available values: "SERIAL", "URL", "DOMAIN", "EMAIL", "IP", "CATEGORY", "LOCATION", "DEVICE", "AAGUID".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_list#type DataCloudflareZeroTrustList#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustListFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustList.DataCloudflareZeroTrustListFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustList.IDataCloudflareZeroTrustListFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the list type. Available values: "SERIAL", "URL", "DOMAIN", "EMAIL", "IP", "CATEGORY", "LOCATION", "DEVICE", "AAGUID".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_list#type DataCloudflareZeroTrustList#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
