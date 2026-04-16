using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailSecurityTrustedDomains
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareEmailSecurityTrustedDomainsFilter), fullyQualifiedName: "cloudflare.dataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsFilter")]
    public interface IDataCloudflareEmailSecurityTrustedDomainsFilter
    {
        /// <summary>The sorting direction. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#direction DataCloudflareEmailSecurityTrustedDomains#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#is_recent DataCloudflareEmailSecurityTrustedDomains#is_recent}.</summary>
        [JsiiProperty(name: "isRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRecent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#is_similarity DataCloudflareEmailSecurityTrustedDomains#is_similarity}.</summary>
        [JsiiProperty(name: "isSimilarity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSimilarity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The field to sort by. Available values: "pattern", "created_at".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#order DataCloudflareEmailSecurityTrustedDomains#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#pattern DataCloudflareEmailSecurityTrustedDomains#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Pattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows searching in multiple properties of a record simultaneously.</summary>
        /// <remarks>
        /// This parameter is intended for human users, not automation. Its exact
        /// behavior is intentionally left unspecified and is subject to change
        /// in the future.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#search DataCloudflareEmailSecurityTrustedDomains#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareEmailSecurityTrustedDomainsFilter), fullyQualifiedName: "cloudflare.dataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareEmailSecurityTrustedDomains.IDataCloudflareEmailSecurityTrustedDomainsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The sorting direction. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#direction DataCloudflareEmailSecurityTrustedDomains#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#is_recent DataCloudflareEmailSecurityTrustedDomains#is_recent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRecent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#is_similarity DataCloudflareEmailSecurityTrustedDomains#is_similarity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSimilarity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSimilarity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The field to sort by. Available values: "pattern", "created_at".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#order DataCloudflareEmailSecurityTrustedDomains#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#pattern DataCloudflareEmailSecurityTrustedDomains#pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Pattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Allows searching in multiple properties of a record simultaneously.</summary>
            /// <remarks>
            /// This parameter is intended for human users, not automation. Its exact
            /// behavior is intentionally left unspecified and is subject to change
            /// in the future.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#search DataCloudflareEmailSecurityTrustedDomains#search}
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
