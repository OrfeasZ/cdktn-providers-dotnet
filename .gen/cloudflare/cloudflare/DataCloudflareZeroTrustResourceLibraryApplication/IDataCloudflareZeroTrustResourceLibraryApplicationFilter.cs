using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustResourceLibraryApplication
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustResourceLibraryApplicationFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustResourceLibraryApplication.DataCloudflareZeroTrustResourceLibraryApplicationFilter")]
    public interface IDataCloudflareZeroTrustResourceLibraryApplicationFilter
    {
        /// <summary>Return only the listed properties on each application, as a comma-separated list.</summary>
        /// <remarks>
        /// Use this to keep responses small when you only need part of each application — for
        /// example populating a picker with <c>fields=id,name</c> instead of downloading every
        /// hostname and IP subnet.
        ///
        /// Omit this parameter to receive the full application object.
        ///
        /// <c>id</c> is always returned.
        ///
        /// Selectable properties: <c>id</c>, <c>name</c>, <c>human_id</c>, <c>version</c>, <c>hostnames</c>,
        /// <c>support_domains</c>, <c>ip_subnets</c>, <c>port_protocols</c>, <c>supported</c>, <c>gen_ai_score</c>,
        /// <c>application_confidence_score</c>, <c>created_at</c>, <c>updated_at</c>, <c>review_status</c>.
        ///
        /// Unknown or empty property names return <c>400</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#fields DataCloudflareZeroTrustResourceLibraryApplication#fields}
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

        /// <summary>Filter applications using key:value format.</summary>
        /// <remarks>
        /// Supported filter keys:
        ///
        /// <list type="bullet">
        /// <description>name: Filter by application name (e.g., name:HR)</description>
        /// <description>id: Filter by application ID (e.g., id:498)</description>
        /// <description>human_id: Filter by human-readable ID (e.g., human_id:HR)</description>
        /// <description>hostname: Filter by hostname or support domain (e.g., hostname:portal.example.com)</description>
        /// <description>source: Filter by application source name (e.g., source:cloudflare)</description>
        /// <description>ip_subnet: Filter by IP subnet using CIDR containment — returns applications where any stored subnet contains the search value (e.g., ip_subnet:10.0.1.5/32 matches apps with 10.0.0.0/16)</description>
        /// <description>category_id: Filter by category ID (e.g., category_id:12).</description>
        /// <description>category_name: Filter by category name (e.g., category_name:HR).</description>
        /// <description>supported: Filter by supported Cloudflare product (e.g., supported:ACCESS). Values: GATEWAY, ACCESS, CASB.</description>
        /// <description>review_status: Filter by the account's Gateway review status. Values: approved, unapproved, in_review, unreviewed.
        /// .</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#filter DataCloudflareZeroTrustResourceLibraryApplication#filter}
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

        /// <summary>Limit of number of results to return (max 250).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#limit DataCloudflareZeroTrustResourceLibraryApplication#limit}
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

        /// <summary>Offset of results to return.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#offset DataCloudflareZeroTrustResourceLibraryApplication#offset}
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
        /// ranked by relevance instead.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#order_by DataCloudflareZeroTrustResourceLibraryApplication#order_by}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#search DataCloudflareZeroTrustResourceLibraryApplication#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustResourceLibraryApplicationFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustResourceLibraryApplication.DataCloudflareZeroTrustResourceLibraryApplicationFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustResourceLibraryApplication.IDataCloudflareZeroTrustResourceLibraryApplicationFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Return only the listed properties on each application, as a comma-separated list.</summary>
            /// <remarks>
            /// Use this to keep responses small when you only need part of each application — for
            /// example populating a picker with <c>fields=id,name</c> instead of downloading every
            /// hostname and IP subnet.
            ///
            /// Omit this parameter to receive the full application object.
            ///
            /// <c>id</c> is always returned.
            ///
            /// Selectable properties: <c>id</c>, <c>name</c>, <c>human_id</c>, <c>version</c>, <c>hostnames</c>,
            /// <c>support_domains</c>, <c>ip_subnets</c>, <c>port_protocols</c>, <c>supported</c>, <c>gen_ai_score</c>,
            /// <c>application_confidence_score</c>, <c>created_at</c>, <c>updated_at</c>, <c>review_status</c>.
            ///
            /// Unknown or empty property names return <c>400</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#fields DataCloudflareZeroTrustResourceLibraryApplication#fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fields", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fields
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter applications using key:value format.</summary>
            /// <remarks>
            /// Supported filter keys:
            ///
            /// <list type="bullet">
            /// <description>name: Filter by application name (e.g., name:HR)</description>
            /// <description>id: Filter by application ID (e.g., id:498)</description>
            /// <description>human_id: Filter by human-readable ID (e.g., human_id:HR)</description>
            /// <description>hostname: Filter by hostname or support domain (e.g., hostname:portal.example.com)</description>
            /// <description>source: Filter by application source name (e.g., source:cloudflare)</description>
            /// <description>ip_subnet: Filter by IP subnet using CIDR containment — returns applications where any stored subnet contains the search value (e.g., ip_subnet:10.0.1.5/32 matches apps with 10.0.0.0/16)</description>
            /// <description>category_id: Filter by category ID (e.g., category_id:12).</description>
            /// <description>category_name: Filter by category name (e.g., category_name:HR).</description>
            /// <description>supported: Filter by supported Cloudflare product (e.g., supported:ACCESS). Values: GATEWAY, ACCESS, CASB.</description>
            /// <description>review_status: Filter by the account's Gateway review status. Values: approved, unapproved, in_review, unreviewed.
            /// .</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#filter DataCloudflareZeroTrustResourceLibraryApplication#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Limit of number of results to return (max 250).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#limit DataCloudflareZeroTrustResourceLibraryApplication#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Offset of results to return.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#offset DataCloudflareZeroTrustResourceLibraryApplication#offset}
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
            /// ranked by relevance instead.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#order_by DataCloudflareZeroTrustResourceLibraryApplication#order_by}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/data-sources/zero_trust_resource_library_application#search DataCloudflareZeroTrustResourceLibraryApplication#search}
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
