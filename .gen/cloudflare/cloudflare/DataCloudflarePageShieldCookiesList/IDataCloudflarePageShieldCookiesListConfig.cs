using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePageShieldCookiesList
{
    [JsiiInterface(nativeType: typeof(IDataCloudflarePageShieldCookiesListConfig), fullyQualifiedName: "cloudflare.dataCloudflarePageShieldCookiesList.DataCloudflarePageShieldCookiesListConfig")]
    public interface IDataCloudflarePageShieldCookiesListConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#zone_id DataCloudflarePageShieldCookiesList#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>The direction used to sort returned cookies.' Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#direction DataCloudflarePageShieldCookiesList#direction}
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

        /// <summary>Filters the returned cookies that match the specified domain attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#domain DataCloudflarePageShieldCookiesList#domain}
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

        /// <summary>Export the list of cookies as a file, limited to 50000 entries. Available values: "csv".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#export DataCloudflarePageShieldCookiesList#export}
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

        /// <summary>Includes cookies that match one or more URL-encoded hostnames separated by commas.</summary>
        /// <remarks>
        /// Wildcards are supported at the start and end of each hostname to support starts with, ends with
        /// and contains. If no wildcards are used, results will be filtered by exact match
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#hosts DataCloudflarePageShieldCookiesList#hosts}
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

        /// <summary>Filters the returned cookies that are set with HttpOnly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#http_only DataCloudflarePageShieldCookiesList#http_only}
        /// </remarks>
        [JsiiProperty(name: "httpOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#max_items DataCloudflarePageShieldCookiesList#max_items}
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

        /// <summary>Filters the returned cookies that match the specified name.</summary>
        /// <remarks>
        /// Wildcards are supported at the start and end to support starts with, ends with
        /// and contains. e.g. session*
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#name DataCloudflarePageShieldCookiesList#name}
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

        /// <summary>The field used to sort returned cookies. Available values: "first_seen_at", "last_seen_at".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#order_by DataCloudflarePageShieldCookiesList#order_by}
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
        /// We additionally support a special value "all". When "all" is used, the API will return all the cookies
        /// with the applied filters in a single page. This feature is best-effort and it may only work for zones with
        /// a low number of cookies
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#page DataCloudflarePageShieldCookiesList#page}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#page_url DataCloudflarePageShieldCookiesList#page_url}
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

        /// <summary>Filters the returned cookies that match the specified path attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#path DataCloudflarePageShieldCookiesList#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of results per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#per_page DataCloudflarePageShieldCookiesList#per_page}
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

        /// <summary>Filters the returned cookies that match the specified same_site attribute Available values: "lax", "strict", "none".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#same_site DataCloudflarePageShieldCookiesList#same_site}
        /// </remarks>
        [JsiiProperty(name: "sameSite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SameSite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filters the returned cookies that are set with Secure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#secure DataCloudflarePageShieldCookiesList#secure}
        /// </remarks>
        [JsiiProperty(name: "secure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Secure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filters the returned cookies that match the specified type attribute Available values: "first_party", "unknown".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#type DataCloudflarePageShieldCookiesList#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflarePageShieldCookiesListConfig), fullyQualifiedName: "cloudflare.dataCloudflarePageShieldCookiesList.DataCloudflarePageShieldCookiesListConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflarePageShieldCookiesList.IDataCloudflarePageShieldCookiesListConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#zone_id DataCloudflarePageShieldCookiesList#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The direction used to sort returned cookies.' Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#direction DataCloudflarePageShieldCookiesList#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filters the returned cookies that match the specified domain attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#domain DataCloudflarePageShieldCookiesList#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Export the list of cookies as a file, limited to 50000 entries. Available values: "csv".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#export DataCloudflarePageShieldCookiesList#export}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "export", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Export
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Includes cookies that match one or more URL-encoded hostnames separated by commas.</summary>
            /// <remarks>
            /// Wildcards are supported at the start and end of each hostname to support starts with, ends with
            /// and contains. If no wildcards are used, results will be filtered by exact match
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#hosts DataCloudflarePageShieldCookiesList#hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hosts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hosts
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filters the returned cookies that are set with HttpOnly.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#http_only DataCloudflarePageShieldCookiesList#http_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HttpOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#max_items DataCloudflarePageShieldCookiesList#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Filters the returned cookies that match the specified name.</summary>
            /// <remarks>
            /// Wildcards are supported at the start and end to support starts with, ends with
            /// and contains. e.g. session*
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#name DataCloudflarePageShieldCookiesList#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The field used to sort returned cookies. Available values: "first_seen_at", "last_seen_at".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#order_by DataCloudflarePageShieldCookiesList#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The current page number of the paginated results.</summary>
            /// <remarks>
            /// We additionally support a special value "all". When "all" is used, the API will return all the cookies
            /// with the applied filters in a single page. This feature is best-effort and it may only work for zones with
            /// a low number of cookies
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#page DataCloudflarePageShieldCookiesList#page}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#page_url DataCloudflarePageShieldCookiesList#page_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filters the returned cookies that match the specified path attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#path DataCloudflarePageShieldCookiesList#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of results per page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#per_page DataCloudflarePageShieldCookiesList#per_page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerPage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Filters the returned cookies that match the specified same_site attribute Available values: "lax", "strict", "none".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#same_site DataCloudflarePageShieldCookiesList#same_site}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sameSite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SameSite
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filters the returned cookies that are set with Secure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#secure DataCloudflarePageShieldCookiesList#secure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Secure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Filters the returned cookies that match the specified type attribute Available values: "first_party", "unknown".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/page_shield_cookies_list#type DataCloudflarePageShieldCookiesList#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
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
