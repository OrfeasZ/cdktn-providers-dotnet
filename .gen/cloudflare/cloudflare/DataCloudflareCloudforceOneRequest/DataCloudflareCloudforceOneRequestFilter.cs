using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCloudforceOneRequest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.dataCloudflareCloudforceOneRequest.DataCloudflareCloudforceOneRequestFilter")]
    public class DataCloudflareCloudforceOneRequestFilter : cloudflare.DataCloudflareCloudforceOneRequest.IDataCloudflareCloudforceOneRequestFilter
    {
        /// <summary>Page number of results.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#page DataCloudflareCloudforceOneRequest#page}
        /// </remarks>
        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}")]
        public double Page
        {
            get;
            set;
        }

        /// <summary>Number of results per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#per_page DataCloudflareCloudforceOneRequest#per_page}
        /// </remarks>
        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}")]
        public double PerPage
        {
            get;
            set;
        }

        /// <summary>Retrieve requests completed after this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#completed_after DataCloudflareCloudforceOneRequest#completed_after}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "completedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompletedAfter
        {
            get;
            set;
        }

        /// <summary>Retrieve requests completed before this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#completed_before DataCloudflareCloudforceOneRequest#completed_before}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "completedBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompletedBefore
        {
            get;
            set;
        }

        /// <summary>Retrieve requests created after this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#created_after DataCloudflareCloudforceOneRequest#created_after}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedAfter
        {
            get;
            set;
        }

        /// <summary>Retrieve requests created before this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#created_before DataCloudflareCloudforceOneRequest#created_before}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedBefore
        {
            get;
            set;
        }

        /// <summary>Requested information from request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#request_type DataCloudflareCloudforceOneRequest#request_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestType
        {
            get;
            set;
        }

        /// <summary>Field to sort results by.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#sort_by DataCloudflareCloudforceOneRequest#sort_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortBy
        {
            get;
            set;
        }

        /// <summary>Sort order (asc or desc). Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#sort_order DataCloudflareCloudforceOneRequest#sort_order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortOrder
        {
            get;
            set;
        }

        /// <summary>Request Status. Available values: "open", "accepted", "reported", "approved", "completed", "declined".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#status DataCloudflareCloudforceOneRequest#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
