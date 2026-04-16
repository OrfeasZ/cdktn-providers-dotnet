using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustAccessGroupFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupFilter")]
    public interface IDataCloudflareZeroTrustAccessGroupFilter
    {
        /// <summary>The name of the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_group#name DataCloudflareZeroTrustAccessGroup#name}
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

        /// <summary>Search for groups by other listed query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_group#search DataCloudflareZeroTrustAccessGroup#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustAccessGroupFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_group#name DataCloudflareZeroTrustAccessGroup#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Search for groups by other listed query parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_group#search DataCloudflareZeroTrustAccessGroup#search}
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
