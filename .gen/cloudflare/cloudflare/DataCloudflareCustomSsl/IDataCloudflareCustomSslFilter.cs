using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomSsl
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareCustomSslFilter), fullyQualifiedName: "cloudflare.dataCloudflareCustomSsl.DataCloudflareCustomSslFilter")]
    public interface IDataCloudflareCustomSslFilter
    {
        /// <summary>Whether to match all search requirements or at least one (any). Available values: "any", "all".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_ssl#match DataCloudflareCustomSsl#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Match
        {
            get
            {
                return null;
            }
        }

        /// <summary>Status of the zone's custom SSL. Available values: "active", "expired", "deleted", "pending", "initializing".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_ssl#status DataCloudflareCustomSsl#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareCustomSslFilter), fullyQualifiedName: "cloudflare.dataCloudflareCustomSsl.DataCloudflareCustomSslFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareCustomSsl.IDataCloudflareCustomSslFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to match all search requirements or at least one (any). Available values: "any", "all".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_ssl#match DataCloudflareCustomSsl#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Match
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Status of the zone's custom SSL. Available values: "active", "expired", "deleted", "pending", "initializing".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_ssl#status DataCloudflareCustomSsl#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
