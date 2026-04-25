using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailSecurityTrustedDomains
{
    [JsiiInterface(nativeType: typeof(IEmailSecurityTrustedDomainsBody), fullyQualifiedName: "cloudflare.emailSecurityTrustedDomains.EmailSecurityTrustedDomainsBody")]
    public interface IEmailSecurityTrustedDomainsBody
    {
        /// <summary>Select to prevent recently registered domains from triggering a Suspicious or Malicious disposition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#is_recent EmailSecurityTrustedDomains#is_recent}
        /// </remarks>
        [JsiiProperty(name: "isRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsRecent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#is_regex EmailSecurityTrustedDomains#is_regex}.</summary>
        [JsiiProperty(name: "isRegex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsRegex
        {
            get;
        }

        /// <summary>Select for partner or other approved domains that have similar spelling to your connected domains.</summary>
        /// <remarks>
        /// Prevents listed domains from
        /// triggering a Spoof disposition.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#is_similarity EmailSecurityTrustedDomains#is_similarity}
        /// </remarks>
        [JsiiProperty(name: "isSimilarity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsSimilarity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#pattern EmailSecurityTrustedDomains#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        string Pattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#comments EmailSecurityTrustedDomains#comments}.</summary>
        [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comments
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmailSecurityTrustedDomainsBody), fullyQualifiedName: "cloudflare.emailSecurityTrustedDomains.EmailSecurityTrustedDomainsBody")]
        internal sealed class _Proxy : DeputyBase, cloudflare.EmailSecurityTrustedDomains.IEmailSecurityTrustedDomainsBody
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Select to prevent recently registered domains from triggering a Suspicious or Malicious disposition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#is_recent EmailSecurityTrustedDomains#is_recent}
            /// </remarks>
            [JsiiProperty(name: "isRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsRecent
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#is_regex EmailSecurityTrustedDomains#is_regex}.</summary>
            [JsiiProperty(name: "isRegex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsRegex
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Select for partner or other approved domains that have similar spelling to your connected domains.</summary>
            /// <remarks>
            /// Prevents listed domains from
            /// triggering a Spoof disposition.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#is_similarity EmailSecurityTrustedDomains#is_similarity}
            /// </remarks>
            [JsiiProperty(name: "isSimilarity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsSimilarity
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#pattern EmailSecurityTrustedDomains#pattern}.</summary>
            [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
            public string Pattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_security_trusted_domains#comments EmailSecurityTrustedDomains#comments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comments
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
