using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessServiceToken
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustAccessServiceTokenFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessServiceToken.DataCloudflareZeroTrustAccessServiceTokenFilter")]
    public interface IDataCloudflareZeroTrustAccessServiceTokenFilter
    {
        /// <summary>The name of the service token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_service_token#name DataCloudflareZeroTrustAccessServiceToken#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Search for service tokens by other listed query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_service_token#search DataCloudflareZeroTrustAccessServiceToken#search}
        /// </remarks>
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Search
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustAccessServiceTokenFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessServiceToken.DataCloudflareZeroTrustAccessServiceTokenFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustAccessServiceToken.IDataCloudflareZeroTrustAccessServiceTokenFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the service token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_service_token#name DataCloudflareZeroTrustAccessServiceToken#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Search for service tokens by other listed query parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_service_token#search DataCloudflareZeroTrustAccessServiceToken#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
