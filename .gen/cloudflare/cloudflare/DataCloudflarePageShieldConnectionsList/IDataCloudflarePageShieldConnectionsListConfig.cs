using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePageShieldConnectionsList
{
    [JsiiInterface(nativeType: typeof(IDataCloudflarePageShieldConnectionsListConfig), fullyQualifiedName: "cloudflare.dataCloudflarePageShieldConnectionsList.DataCloudflarePageShieldConnectionsListConfig")]
    public interface IDataCloudflarePageShieldConnectionsListConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The direction used to sort returned connections. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#direction DataCloudflarePageShieldConnectionsList#direction}
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

        /// <summary>When true, excludes connections seen in a `/cdn-cgi` path from the returned connections. The default value is true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#exclude_cdn_cgi DataCloudflarePageShieldConnectionsList#exclude_cdn_cgi}
        /// </remarks>
        [JsiiProperty(name: "excludeCdnCgi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeCdnCgi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Excludes connections whose URL contains one of the URL-encoded URLs separated by commas.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#exclude_urls DataCloudflarePageShieldConnectionsList#exclude_urls}
        /// </remarks>
        [JsiiProperty(name: "excludeUrls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExcludeUrls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Export the list of connections as a file, limited to 50000 entries. Available values: "csv".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#export DataCloudflarePageShieldConnectionsList#export}
        /// </remarks>
        [JsiiProperty(name: "export", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Export
        {
            get
            {
                return null;
            }
        }

        /// <summary>Includes connections that match one or more URL-encoded hostnames separated by commas.</summary>
        /// <remarks>
        /// Wildcards are supported at the start and end of each hostname to support starts with, ends with
        /// and contains. If no wildcards are used, results will be filtered by exact match
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#hosts DataCloudflarePageShieldConnectionsList#hosts}
        /// </remarks>
        [JsiiProperty(name: "hosts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#max_items DataCloudflarePageShieldConnectionsList#max_items}
        /// </remarks>
        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>The field used to sort returned connections. Available values: "first_seen_at", "last_seen_at".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#order_by DataCloudflarePageShieldConnectionsList#order_by}
        /// </remarks>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrderBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The current page number of the paginated results.</summary>
        /// <remarks>
        /// We additionally support a special value "all". When "all" is used, the API will return all the connections
        /// with the applied filters in a single page. This feature is best-effort and it may only work for zones with
        /// a low number of connections
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#page DataCloudflarePageShieldConnectionsList#page}
        /// </remarks>
        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Page
        {
            get
            {
                return null;
            }
        }

        /// <summary>Includes connections that match one or more page URLs (separated by commas) where they were last seen.</summary>
        /// <remarks>
        /// Wildcards are supported at the start and end of each page URL to support starts with, ends with
        /// and contains. If no wildcards are used, results will be filtered by exact match
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#page_url DataCloudflarePageShieldConnectionsList#page_url}
        /// </remarks>
        [JsiiProperty(name: "pageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PageUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of results per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#per_page DataCloudflarePageShieldConnectionsList#per_page}
        /// </remarks>
        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PerPage
        {
            get
            {
                return null;
            }
        }

        /// <summary>When true, malicious connections appear first in the returned connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#prioritize_malicious DataCloudflarePageShieldConnectionsList#prioritize_malicious}
        /// </remarks>
        [JsiiProperty(name: "prioritizeMalicious", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrioritizeMalicious
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filters the returned connections using a comma-separated list of connection statuses.</summary>
        /// <remarks>
        /// Accepted values: <c>active</c>, <c>infrequent</c>, and <c>inactive</c>. The default value is <c>active</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#status DataCloudflarePageShieldConnectionsList#status}
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

        /// <summary>Includes connections whose URL contain one or more URL-encoded URLs separated by commas.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#urls DataCloudflarePageShieldConnectionsList#urls}
        /// </remarks>
        [JsiiProperty(name: "urls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Urls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#zone_id DataCloudflarePageShieldConnectionsList#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflarePageShieldConnectionsListConfig), fullyQualifiedName: "cloudflare.dataCloudflarePageShieldConnectionsList.DataCloudflarePageShieldConnectionsListConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflarePageShieldConnectionsList.IDataCloudflarePageShieldConnectionsListConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The direction used to sort returned connections. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#direction DataCloudflarePageShieldConnectionsList#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When true, excludes connections seen in a `/cdn-cgi` path from the returned connections. The default value is true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#exclude_cdn_cgi DataCloudflarePageShieldConnectionsList#exclude_cdn_cgi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeCdnCgi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeCdnCgi
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Excludes connections whose URL contains one of the URL-encoded URLs separated by commas.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#exclude_urls DataCloudflarePageShieldConnectionsList#exclude_urls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeUrls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcludeUrls
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Export the list of connections as a file, limited to 50000 entries. Available values: "csv".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#export DataCloudflarePageShieldConnectionsList#export}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "export", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Export
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Includes connections that match one or more URL-encoded hostnames separated by commas.</summary>
            /// <remarks>
            /// Wildcards are supported at the start and end of each hostname to support starts with, ends with
            /// and contains. If no wildcards are used, results will be filtered by exact match
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#hosts DataCloudflarePageShieldConnectionsList#hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hosts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hosts
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#max_items DataCloudflarePageShieldConnectionsList#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The field used to sort returned connections. Available values: "first_seen_at", "last_seen_at".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#order_by DataCloudflarePageShieldConnectionsList#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The current page number of the paginated results.</summary>
            /// <remarks>
            /// We additionally support a special value "all". When "all" is used, the API will return all the connections
            /// with the applied filters in a single page. This feature is best-effort and it may only work for zones with
            /// a low number of connections
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#page DataCloudflarePageShieldConnectionsList#page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Page
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Includes connections that match one or more page URLs (separated by commas) where they were last seen.</summary>
            /// <remarks>
            /// Wildcards are supported at the start and end of each page URL to support starts with, ends with
            /// and contains. If no wildcards are used, results will be filtered by exact match
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#page_url DataCloudflarePageShieldConnectionsList#page_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of results per page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#per_page DataCloudflarePageShieldConnectionsList#per_page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerPage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>When true, malicious connections appear first in the returned connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#prioritize_malicious DataCloudflarePageShieldConnectionsList#prioritize_malicious}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prioritizeMalicious", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PrioritizeMalicious
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Filters the returned connections using a comma-separated list of connection statuses.</summary>
            /// <remarks>
            /// Accepted values: <c>active</c>, <c>infrequent</c>, and <c>inactive</c>. The default value is <c>active</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#status DataCloudflarePageShieldConnectionsList#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Includes connections whose URL contain one or more URL-encoded URLs separated by commas.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#urls DataCloudflarePageShieldConnectionsList#urls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Urls
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_connections_list#zone_id DataCloudflarePageShieldConnectionsList#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
