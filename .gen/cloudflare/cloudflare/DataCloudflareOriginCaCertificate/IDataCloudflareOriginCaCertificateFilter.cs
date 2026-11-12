using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOriginCaCertificate
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOriginCaCertificateFilter), fullyQualifiedName: "cloudflare.dataCloudflareOriginCaCertificate.DataCloudflareOriginCaCertificateFilter")]
    public interface IDataCloudflareOriginCaCertificateFilter
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/origin_ca_certificate#zone_id DataCloudflareOriginCaCertificate#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOriginCaCertificateFilter), fullyQualifiedName: "cloudflare.dataCloudflareOriginCaCertificate.DataCloudflareOriginCaCertificateFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOriginCaCertificate.IDataCloudflareOriginCaCertificateFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/origin_ca_certificate#zone_id DataCloudflareOriginCaCertificate#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
