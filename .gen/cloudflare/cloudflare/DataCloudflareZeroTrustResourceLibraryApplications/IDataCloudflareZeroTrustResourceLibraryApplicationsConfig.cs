using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustResourceLibraryApplications
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustResourceLibraryApplicationsConfig), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustResourceLibraryApplications.DataCloudflareZeroTrustResourceLibraryApplicationsConfig")]
    public interface IDataCloudflareZeroTrustResourceLibraryApplicationsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#account_id DataCloudflareZeroTrustResourceLibraryApplications#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Return only the listed properties on each application, as a comma-separated list.</summary>
        /// <remarks>
        /// Use this to keep responses small when you only need part of each application, for
        /// example populating a picker with <c>fields=id,name</c> instead of downloading every
        /// hostname and IP subnet.
        ///
        /// Omit this parameter to receive the full application object, including
        /// when lookup is used.
        ///
        /// <c>id</c> is always returned.
        ///
        /// Selectable properties: <c>id</c>, <c>name</c>, <c>human_id</c>, <c>version</c>, <c>hostnames</c>,
        /// <c>support_domains</c>, <c>ip_subnets</c>, <c>port_protocols</c>, <c>supported</c>, <c>gen_ai_score</c>,
        /// <c>application_confidence_score</c>, <c>created_at</c>, <c>updated_at</c>, <c>review_status</c>.
        ///
        /// Unknown or empty property names return <c>400</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#fields DataCloudflareZeroTrustResourceLibraryApplications#fields}
        /// </remarks>
        [JsiiProperty(name: "fields", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter applications using `key:value` format.</summary>
        /// <remarks>
        /// Supported filter keys:
        ///
        /// <list type="bullet">
        /// <description><c>name</c>: application name (for example, <c>name:HR</c>).</description>
        /// <description><c>id</c>: application ID (for example, <c>id:498</c>).</description>
        /// <description><c>human_id</c>: human-readable ID (for example, <c>human_id:HR</c>).</description>
        /// <description><c>hostname</c>: hostname or support domain (for example, <c>hostname:portal.example.com</c>).</description>
        /// <description><c>source</c>: application source name (for example, <c>source:cloudflare</c>).</description>
        /// <description><c>ip_subnet</c>: CIDR containment; returns applications where a stored subnet contains the search value (for example, <c>ip_subnet:10.0.1.5/32</c> matches <c>10.0.0.0/16</c>).</description>
        /// <description><c>category_id</c>: category ID (for example, <c>category_id:12</c>).</description>
        /// <description><c>category_name</c>: category name (for example, <c>category_name:HR</c>).</description>
        /// <description><c>supported</c>: supported Cloudflare product. Values: <c>GATEWAY</c>, <c>ACCESS</c>, <c>CASB</c>.</description>
        /// <description><c>review_status</c>: account-specific Gateway review status. Values: <c>approved</c>, <c>unapproved</c>, <c>in_review</c>, <c>unreviewed</c>.</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#filter DataCloudflareZeroTrustResourceLibraryApplications#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of results to return. Defaults to 25; values are clamped to 1–250.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#limit DataCloudflareZeroTrustResourceLibraryApplications#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Find complete, case-insensitive application name mentions in a phrase or rule sentence.</summary>
        /// <remarks>
        /// Misspelled names do not match. Returns matching applications
        /// ranked by relevance. Must be between 2 and 1000 characters. Uses the same
        /// filters, fields, and pagination as listing. <c>search</c> cannot be combined
        /// with lookup. Results are ranked by relevance, so <c>order_by</c> is ignored.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#lookup DataCloudflareZeroTrustResourceLibraryApplications#lookup}
        /// </remarks>
        [JsiiProperty(name: "lookup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lookup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#max_items DataCloudflareZeroTrustResourceLibraryApplications#max_items}
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

        /// <summary>Number of results to skip. Defaults to 0; negative values are clamped to 0.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#offset DataCloudflareZeroTrustResourceLibraryApplications#offset}
        /// </remarks>
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Offset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Order results using field:direction format.</summary>
        /// <remarks>
        /// Supported fields are name, id, human_id,
        /// category_id, application_type, application_confidence_score, and gen_ai_score.
        /// Supported directions are asc and desc. Ignored when search is provided; results are
        /// ranked by relevance instead. Also ignored when lookup is provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#order_by DataCloudflareZeroTrustResourceLibraryApplications#order_by}
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

        /// <summary>Fuzzy search across application name and hostnames.</summary>
        /// <remarks>
        /// Results are ranked by relevance. Must be between 2 and 200 characters. Can be combined with filter parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#search DataCloudflareZeroTrustResourceLibraryApplications#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustResourceLibraryApplicationsConfig), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustResourceLibraryApplications.DataCloudflareZeroTrustResourceLibraryApplicationsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustResourceLibraryApplications.IDataCloudflareZeroTrustResourceLibraryApplicationsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#account_id DataCloudflareZeroTrustResourceLibraryApplications#account_id}.</summary>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Return only the listed properties on each application, as a comma-separated list.</summary>
            /// <remarks>
            /// Use this to keep responses small when you only need part of each application, for
            /// example populating a picker with <c>fields=id,name</c> instead of downloading every
            /// hostname and IP subnet.
            ///
            /// Omit this parameter to receive the full application object, including
            /// when lookup is used.
            ///
            /// <c>id</c> is always returned.
            ///
            /// Selectable properties: <c>id</c>, <c>name</c>, <c>human_id</c>, <c>version</c>, <c>hostnames</c>,
            /// <c>support_domains</c>, <c>ip_subnets</c>, <c>port_protocols</c>, <c>supported</c>, <c>gen_ai_score</c>,
            /// <c>application_confidence_score</c>, <c>created_at</c>, <c>updated_at</c>, <c>review_status</c>.
            ///
            /// Unknown or empty property names return <c>400</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#fields DataCloudflareZeroTrustResourceLibraryApplications#fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fields", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fields
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter applications using `key:value` format.</summary>
            /// <remarks>
            /// Supported filter keys:
            ///
            /// <list type="bullet">
            /// <description><c>name</c>: application name (for example, <c>name:HR</c>).</description>
            /// <description><c>id</c>: application ID (for example, <c>id:498</c>).</description>
            /// <description><c>human_id</c>: human-readable ID (for example, <c>human_id:HR</c>).</description>
            /// <description><c>hostname</c>: hostname or support domain (for example, <c>hostname:portal.example.com</c>).</description>
            /// <description><c>source</c>: application source name (for example, <c>source:cloudflare</c>).</description>
            /// <description><c>ip_subnet</c>: CIDR containment; returns applications where a stored subnet contains the search value (for example, <c>ip_subnet:10.0.1.5/32</c> matches <c>10.0.0.0/16</c>).</description>
            /// <description><c>category_id</c>: category ID (for example, <c>category_id:12</c>).</description>
            /// <description><c>category_name</c>: category name (for example, <c>category_name:HR</c>).</description>
            /// <description><c>supported</c>: supported Cloudflare product. Values: <c>GATEWAY</c>, <c>ACCESS</c>, <c>CASB</c>.</description>
            /// <description><c>review_status</c>: account-specific Gateway review status. Values: <c>approved</c>, <c>unapproved</c>, <c>in_review</c>, <c>unreviewed</c>.</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#filter DataCloudflareZeroTrustResourceLibraryApplications#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Number of results to return. Defaults to 25; values are clamped to 1–250.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#limit DataCloudflareZeroTrustResourceLibraryApplications#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Find complete, case-insensitive application name mentions in a phrase or rule sentence.</summary>
            /// <remarks>
            /// Misspelled names do not match. Returns matching applications
            /// ranked by relevance. Must be between 2 and 1000 characters. Uses the same
            /// filters, fields, and pagination as listing. <c>search</c> cannot be combined
            /// with lookup. Results are ranked by relevance, so <c>order_by</c> is ignored.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#lookup DataCloudflareZeroTrustResourceLibraryApplications#lookup}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lookup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lookup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#max_items DataCloudflareZeroTrustResourceLibraryApplications#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of results to skip. Defaults to 0; negative values are clamped to 0.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#offset DataCloudflareZeroTrustResourceLibraryApplications#offset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Offset
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Order results using field:direction format.</summary>
            /// <remarks>
            /// Supported fields are name, id, human_id,
            /// category_id, application_type, application_confidence_score, and gen_ai_score.
            /// Supported directions are asc and desc. Ignored when search is provided; results are
            /// ranked by relevance instead. Also ignored when lookup is provided.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#order_by DataCloudflareZeroTrustResourceLibraryApplications#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Fuzzy search across application name and hostnames.</summary>
            /// <remarks>
            /// Results are ranked by relevance. Must be between 2 and 200 characters. Can be combined with filter parameters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_applications#search DataCloudflareZeroTrustResourceLibraryApplications#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
