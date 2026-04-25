using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePageShieldScriptsList
{
    [JsiiInterface(nativeType: typeof(IDataCloudflarePageShieldScriptsListConfig), fullyQualifiedName: "cloudflare.dataCloudflarePageShieldScriptsList.DataCloudflarePageShieldScriptsListConfig")]
    public interface IDataCloudflarePageShieldScriptsListConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The direction used to sort returned scripts. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#direction DataCloudflarePageShieldScriptsList#direction}
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

        /// <summary>When true, excludes scripts seen in a `/cdn-cgi` path from the returned scripts. The default value is true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#exclude_cdn_cgi DataCloudflarePageShieldScriptsList#exclude_cdn_cgi}
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

        /// <summary>When true, excludes duplicate scripts.</summary>
        /// <remarks>
        /// We consider a script duplicate of another if their javascript
        /// content matches and they share the same url host and zone hostname. In such case, we return the most
        /// recent script for the URL host and zone hostname combination.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#exclude_duplicates DataCloudflarePageShieldScriptsList#exclude_duplicates}
        /// </remarks>
        [JsiiProperty(name: "excludeDuplicates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeDuplicates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Excludes scripts whose URL contains one of the URL-encoded URLs separated by commas.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#exclude_urls DataCloudflarePageShieldScriptsList#exclude_urls}
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

        /// <summary>Export the list of scripts as a file, limited to 50000 entries. Available values: "csv".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#export DataCloudflarePageShieldScriptsList#export}
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

        /// <summary>Includes scripts that match one or more URL-encoded hostnames separated by commas.</summary>
        /// <remarks>
        /// Wildcards are supported at the start and end of each hostname to support starts with, ends with
        /// and contains. If no wildcards are used, results will be filtered by exact match
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#hosts DataCloudflarePageShieldScriptsList#hosts}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#max_items DataCloudflarePageShieldScriptsList#max_items}
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

        /// <summary>The field used to sort returned scripts. Available values: "first_seen_at", "last_seen_at".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#order_by DataCloudflarePageShieldScriptsList#order_by}
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
        /// We additionally support a special value "all". When "all" is used, the API will return all the scripts
        /// with the applied filters in a single page. This feature is best-effort and it may only work for zones with
        /// a low number of scripts
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#page DataCloudflarePageShieldScriptsList#page}
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

        /// <summary>Includes scripts that match one or more page URLs (separated by commas) where they were last seen.</summary>
        /// <remarks>
        /// Wildcards are supported at the start and end of each page URL to support starts with, ends with
        /// and contains. If no wildcards are used, results will be filtered by exact match
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#page_url DataCloudflarePageShieldScriptsList#page_url}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#per_page DataCloudflarePageShieldScriptsList#per_page}
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

        /// <summary>When true, malicious scripts appear first in the returned scripts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#prioritize_malicious DataCloudflarePageShieldScriptsList#prioritize_malicious}
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

        /// <summary>Filters the returned scripts using a comma-separated list of scripts statuses.</summary>
        /// <remarks>
        /// Accepted values: <c>active</c>, <c>infrequent</c>, and <c>inactive</c>. The default value is <c>active</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#status DataCloudflarePageShieldScriptsList#status}
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

        /// <summary>Includes scripts whose URL contain one or more URL-encoded URLs separated by commas.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#urls DataCloudflarePageShieldScriptsList#urls}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#zone_id DataCloudflarePageShieldScriptsList#zone_id}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflarePageShieldScriptsListConfig), fullyQualifiedName: "cloudflare.dataCloudflarePageShieldScriptsList.DataCloudflarePageShieldScriptsListConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflarePageShieldScriptsList.IDataCloudflarePageShieldScriptsListConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The direction used to sort returned scripts. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#direction DataCloudflarePageShieldScriptsList#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When true, excludes scripts seen in a `/cdn-cgi` path from the returned scripts. The default value is true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#exclude_cdn_cgi DataCloudflarePageShieldScriptsList#exclude_cdn_cgi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeCdnCgi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeCdnCgi
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When true, excludes duplicate scripts.</summary>
            /// <remarks>
            /// We consider a script duplicate of another if their javascript
            /// content matches and they share the same url host and zone hostname. In such case, we return the most
            /// recent script for the URL host and zone hostname combination.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#exclude_duplicates DataCloudflarePageShieldScriptsList#exclude_duplicates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeDuplicates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeDuplicates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Excludes scripts whose URL contains one of the URL-encoded URLs separated by commas.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#exclude_urls DataCloudflarePageShieldScriptsList#exclude_urls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeUrls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcludeUrls
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Export the list of scripts as a file, limited to 50000 entries. Available values: "csv".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#export DataCloudflarePageShieldScriptsList#export}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "export", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Export
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Includes scripts that match one or more URL-encoded hostnames separated by commas.</summary>
            /// <remarks>
            /// Wildcards are supported at the start and end of each hostname to support starts with, ends with
            /// and contains. If no wildcards are used, results will be filtered by exact match
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#hosts DataCloudflarePageShieldScriptsList#hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hosts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hosts
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#max_items DataCloudflarePageShieldScriptsList#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The field used to sort returned scripts. Available values: "first_seen_at", "last_seen_at".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#order_by DataCloudflarePageShieldScriptsList#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The current page number of the paginated results.</summary>
            /// <remarks>
            /// We additionally support a special value "all". When "all" is used, the API will return all the scripts
            /// with the applied filters in a single page. This feature is best-effort and it may only work for zones with
            /// a low number of scripts
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#page DataCloudflarePageShieldScriptsList#page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Page
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Includes scripts that match one or more page URLs (separated by commas) where they were last seen.</summary>
            /// <remarks>
            /// Wildcards are supported at the start and end of each page URL to support starts with, ends with
            /// and contains. If no wildcards are used, results will be filtered by exact match
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#page_url DataCloudflarePageShieldScriptsList#page_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of results per page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#per_page DataCloudflarePageShieldScriptsList#per_page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerPage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>When true, malicious scripts appear first in the returned scripts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#prioritize_malicious DataCloudflarePageShieldScriptsList#prioritize_malicious}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prioritizeMalicious", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PrioritizeMalicious
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Filters the returned scripts using a comma-separated list of scripts statuses.</summary>
            /// <remarks>
            /// Accepted values: <c>active</c>, <c>infrequent</c>, and <c>inactive</c>. The default value is <c>active</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#status DataCloudflarePageShieldScriptsList#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Includes scripts whose URL contain one or more URL-encoded URLs separated by commas.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#urls DataCloudflarePageShieldScriptsList#urls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Urls
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/page_shield_scripts_list#zone_id DataCloudflarePageShieldScriptsList#zone_id}
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
