using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomOriginTrustStore
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareCustomOriginTrustStoreFilter), fullyQualifiedName: "cloudflare.dataCloudflareCustomOriginTrustStore.DataCloudflareCustomOriginTrustStoreFilter")]
    public interface IDataCloudflareCustomOriginTrustStoreFilter
    {
        /// <summary>Limit to the number of records returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_origin_trust_store#limit DataCloudflareCustomOriginTrustStore#limit}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_origin_trust_store#offset DataCloudflareCustomOriginTrustStore#offset}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareCustomOriginTrustStoreFilter), fullyQualifiedName: "cloudflare.dataCloudflareCustomOriginTrustStore.DataCloudflareCustomOriginTrustStoreFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareCustomOriginTrustStore.IDataCloudflareCustomOriginTrustStoreFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Limit to the number of records returned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_origin_trust_store#limit DataCloudflareCustomOriginTrustStore#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Offset the results.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_origin_trust_store#offset DataCloudflareCustomOriginTrustStore#offset}
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
