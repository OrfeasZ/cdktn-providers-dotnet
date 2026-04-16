using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOriginCaCertificate
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareOriginCaCertificateFilter), fullyQualifiedName: "cloudflare.dataCloudflareOriginCaCertificate.DataCloudflareOriginCaCertificateFilter")]
    public interface IDataCloudflareOriginCaCertificateFilter
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/origin_ca_certificate#zone_id DataCloudflareOriginCaCertificate#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Limit to the number of records returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/origin_ca_certificate#limit DataCloudflareOriginCaCertificate#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Offset the results.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/origin_ca_certificate#offset DataCloudflareOriginCaCertificate#offset}
        /// </remarks>
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Offset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareOriginCaCertificateFilter), fullyQualifiedName: "cloudflare.dataCloudflareOriginCaCertificate.DataCloudflareOriginCaCertificateFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareOriginCaCertificate.IDataCloudflareOriginCaCertificateFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/origin_ca_certificate#zone_id DataCloudflareOriginCaCertificate#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Limit to the number of records returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/origin_ca_certificate#limit DataCloudflareOriginCaCertificate#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Offset the results.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/origin_ca_certificate#offset DataCloudflareOriginCaCertificate#offset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Offset
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
