using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustAccessApplicationFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationFilter")]
    public interface IDataCloudflareZeroTrustAccessApplicationFilter
    {
        /// <summary>The aud of the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#aud DataCloudflareZeroTrustAccessApplication#aud}
        /// </remarks>
        [JsiiProperty(name: "aud", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Aud
        {
            get
            {
                return null;
            }
        }

        /// <summary>The domain of the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#domain DataCloudflareZeroTrustAccessApplication#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>True for only exact string matches against passed name/domain query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#exact DataCloudflareZeroTrustAccessApplication#exact}
        /// </remarks>
        [JsiiProperty(name: "exact", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Exact
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#name DataCloudflareZeroTrustAccessApplication#name}
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

        /// <summary>Search for apps by other listed query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#search DataCloudflareZeroTrustAccessApplication#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustAccessApplicationFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The aud of the app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#aud DataCloudflareZeroTrustAccessApplication#aud}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aud", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Aud
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The domain of the app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#domain DataCloudflareZeroTrustAccessApplication#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>True for only exact string matches against passed name/domain query parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#exact DataCloudflareZeroTrustAccessApplication#exact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exact", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Exact
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The name of the app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#name DataCloudflareZeroTrustAccessApplication#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Search for apps by other listed query parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#search DataCloudflareZeroTrustAccessApplication#search}
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
