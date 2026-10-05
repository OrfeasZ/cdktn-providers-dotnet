using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustCasbIntegration
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationFilter")]
    public class DataCloudflareZeroTrustCasbIntegrationFilter : cloudflare.DataCloudflareZeroTrustCasbIntegration.IDataCloudflareZeroTrustCasbIntegrationFilter
    {
        /// <summary>Filter by application/vendor (e.g., GOOGLE_WORKSPACE, MICROSOFT_INTERNAL).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#application DataCloudflareZeroTrustCasbIntegration#application}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Application
        {
            get;
            set;
        }

        /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#direction DataCloudflareZeroTrustCasbIntegration#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        private object? _dlpEnabled;

        /// <summary>Filter by DLP enabled status (true/false).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#dlp_enabled DataCloudflareZeroTrustCasbIntegration#dlp_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dlpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DlpEnabled
        {
            get => _dlpEnabled;
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
                _dlpEnabled = value;
            }
        }

        /// <summary>Field to order results by. Available values: "application", "created", "name", "status".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#order DataCloudflareZeroTrustCasbIntegration#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }

        /// <summary>Page number within the paginated result set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#page DataCloudflareZeroTrustCasbIntegration#page}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Page
        {
            get;
            set;
        }

        /// <summary>Number of results per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#page_size DataCloudflareZeroTrustCasbIntegration#page_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PageSize
        {
            get;
            set;
        }

        /// <summary>Search integrations by name or application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#search DataCloudflareZeroTrustCasbIntegration#search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Search
        {
            get;
            set;
        }

        /// <summary>Filter by integration status. Available values: "Healthy", "Initializing", "Offline", "Unhealthy".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#status DataCloudflareZeroTrustCasbIntegration#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Filter by one enabled use case (for example, casb or ces).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#use_cases DataCloudflareZeroTrustCasbIntegration#use_cases}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useCases", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UseCases
        {
            get;
            set;
        }
    }
}
