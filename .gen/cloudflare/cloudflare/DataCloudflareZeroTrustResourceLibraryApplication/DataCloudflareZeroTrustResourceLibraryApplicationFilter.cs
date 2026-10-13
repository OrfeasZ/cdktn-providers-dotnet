using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustResourceLibraryApplication
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustResourceLibraryApplication.DataCloudflareZeroTrustResourceLibraryApplicationFilter")]
    public class DataCloudflareZeroTrustResourceLibraryApplicationFilter : cloudflare.DataCloudflareZeroTrustResourceLibraryApplication.IDataCloudflareZeroTrustResourceLibraryApplicationFilter
    {
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_application#fields DataCloudflareZeroTrustResourceLibraryApplication#fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fields", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fields
        {
            get;
            set;
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_application#filter DataCloudflareZeroTrustResourceLibraryApplication#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Filter
        {
            get;
            set;
        }

        /// <summary>Number of results to return. Defaults to 25; values are clamped to 1–250.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_application#limit DataCloudflareZeroTrustResourceLibraryApplication#limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Limit
        {
            get;
            set;
        }

        /// <summary>Find complete, case-insensitive application name mentions in a phrase or rule sentence.</summary>
        /// <remarks>
        /// Misspelled names do not match. Returns matching applications
        /// ranked by relevance. Must be between 2 and 1000 characters. Uses the same
        /// filters, fields, and pagination as listing. <c>search</c> cannot be combined
        /// with lookup. Results are ranked by relevance, so <c>order_by</c> is ignored.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_application#lookup DataCloudflareZeroTrustResourceLibraryApplication#lookup}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lookup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Lookup
        {
            get;
            set;
        }

        /// <summary>Number of results to skip. Defaults to 0; negative values are clamped to 0.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_application#offset DataCloudflareZeroTrustResourceLibraryApplication#offset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Offset
        {
            get;
            set;
        }

        /// <summary>Order results using field:direction format.</summary>
        /// <remarks>
        /// Supported fields are name, id, human_id,
        /// category_id, application_type, application_confidence_score, and gen_ai_score.
        /// Supported directions are asc and desc. Ignored when search is provided; results are
        /// ranked by relevance instead. Also ignored when lookup is provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_application#order_by DataCloudflareZeroTrustResourceLibraryApplication#order_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrderBy
        {
            get;
            set;
        }

        /// <summary>Fuzzy search across application name and hostnames.</summary>
        /// <remarks>
        /// Results are ranked by relevance. Must be between 2 and 200 characters. Can be combined with filter parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.28.0/docs/data-sources/zero_trust_resource_library_application#search DataCloudflareZeroTrustResourceLibraryApplication#search}
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
