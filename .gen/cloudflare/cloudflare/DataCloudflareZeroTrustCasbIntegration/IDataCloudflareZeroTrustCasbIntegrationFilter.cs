using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustCasbIntegrationFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationFilter")]
    public interface IDataCloudflareZeroTrustCasbIntegrationFilter
    {
        /// <summary>Filter by application/vendor (e.g., GOOGLE_WORKSPACE, MICROSOFT_INTERNAL).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#application DataCloudflareZeroTrustCasbIntegration#application}
        /// </remarks>
        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Application
        {
            get
            {
                return null;
            }
        }

        /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#direction DataCloudflareZeroTrustCasbIntegration#direction}
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

        /// <summary>Filter by DLP enabled status (true/false).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#dlp_enabled DataCloudflareZeroTrustCasbIntegration#dlp_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "dlpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DlpEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order results by. Available values: "application", "created", "name", "status".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#order DataCloudflareZeroTrustCasbIntegration#order}
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

        /// <summary>Page number within the paginated result set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#page DataCloudflareZeroTrustCasbIntegration#page}
        /// </remarks>
        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Page
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of results per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#page_size DataCloudflareZeroTrustCasbIntegration#page_size}
        /// </remarks>
        [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PageSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Search integrations by name or application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#search DataCloudflareZeroTrustCasbIntegration#search}
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

        /// <summary>Filter by integration status. Available values: "Healthy", "Initializing", "Offline", "Unhealthy".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#status DataCloudflareZeroTrustCasbIntegration#status}
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

        /// <summary>Filter by one enabled use case (for example, casb or ces).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#use_cases DataCloudflareZeroTrustCasbIntegration#use_cases}
        /// </remarks>
        [JsiiProperty(name: "useCases", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UseCases
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustCasbIntegrationFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustCasbIntegration.DataCloudflareZeroTrustCasbIntegrationFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustCasbIntegration.IDataCloudflareZeroTrustCasbIntegrationFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter by application/vendor (e.g., GOOGLE_WORKSPACE, MICROSOFT_INTERNAL).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#application DataCloudflareZeroTrustCasbIntegration#application}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Application
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#direction DataCloudflareZeroTrustCasbIntegration#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter by DLP enabled status (true/false).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#dlp_enabled DataCloudflareZeroTrustCasbIntegration#dlp_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dlpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DlpEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Field to order results by. Available values: "application", "created", "name", "status".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#order DataCloudflareZeroTrustCasbIntegration#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Page number within the paginated result set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#page DataCloudflareZeroTrustCasbIntegration#page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Page
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of results per page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#page_size DataCloudflareZeroTrustCasbIntegration#page_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PageSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Search integrations by name or application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#search DataCloudflareZeroTrustCasbIntegration#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter by integration status. Available values: "Healthy", "Initializing", "Offline", "Unhealthy".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#status DataCloudflareZeroTrustCasbIntegration#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter by one enabled use case (for example, casb or ces).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/zero_trust_casb_integration#use_cases DataCloudflareZeroTrustCasbIntegration#use_cases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useCases", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UseCases
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
