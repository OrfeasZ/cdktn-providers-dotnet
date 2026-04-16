using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationFilter")]
    public class DataCloudflareZeroTrustAccessApplicationFilter : cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationFilter
    {
        /// <summary>The aud of the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#aud DataCloudflareZeroTrustAccessApplication#aud}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aud", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Aud
        {
            get;
            set;
        }

        /// <summary>The domain of the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#domain DataCloudflareZeroTrustAccessApplication#domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        private object? _exact;

        /// <summary>True for only exact string matches against passed name/domain query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#exact DataCloudflareZeroTrustAccessApplication#exact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Exact
        {
            get => _exact;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exact = value;
            }
        }

        /// <summary>The name of the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#name DataCloudflareZeroTrustAccessApplication#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Search for apps by other listed query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_application#search DataCloudflareZeroTrustAccessApplication#search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Search
        {
            get;
            set;
        }
    }
}
