using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCloudforceOneRequest
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareCloudforceOneRequestFilter), fullyQualifiedName: "cloudflare.dataCloudflareCloudforceOneRequest.DataCloudflareCloudforceOneRequestFilter")]
    public interface IDataCloudflareCloudforceOneRequestFilter
    {
        /// <summary>Page number of results.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#page DataCloudflareCloudforceOneRequest#page}
        /// </remarks>
        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}")]
        double Page
        {
            get;
        }

        /// <summary>Number of results per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#per_page DataCloudflareCloudforceOneRequest#per_page}
        /// </remarks>
        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}")]
        double PerPage
        {
            get;
        }

        /// <summary>Retrieve requests completed after this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#completed_after DataCloudflareCloudforceOneRequest#completed_after}
        /// </remarks>
        [JsiiProperty(name: "completedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompletedAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Retrieve requests completed before this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#completed_before DataCloudflareCloudforceOneRequest#completed_before}
        /// </remarks>
        [JsiiProperty(name: "completedBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompletedBefore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Retrieve requests created after this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#created_after DataCloudflareCloudforceOneRequest#created_after}
        /// </remarks>
        [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Retrieve requests created before this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#created_before DataCloudflareCloudforceOneRequest#created_before}
        /// </remarks>
        [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedBefore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Requested information from request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#request_type DataCloudflareCloudforceOneRequest#request_type}
        /// </remarks>
        [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to sort results by.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#sort_by DataCloudflareCloudforceOneRequest#sort_by}
        /// </remarks>
        [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SortBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sort order (asc or desc). Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#sort_order DataCloudflareCloudforceOneRequest#sort_order}
        /// </remarks>
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SortOrder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Request Status. Available values: "open", "accepted", "reported", "approved", "completed", "declined".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#status DataCloudflareCloudforceOneRequest#status}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareCloudforceOneRequestFilter), fullyQualifiedName: "cloudflare.dataCloudflareCloudforceOneRequest.DataCloudflareCloudforceOneRequestFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareCloudforceOneRequest.IDataCloudflareCloudforceOneRequestFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Page number of results.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#page DataCloudflareCloudforceOneRequest#page}
            /// </remarks>
            [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}")]
            public double Page
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Number of results per page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#per_page DataCloudflareCloudforceOneRequest#per_page}
            /// </remarks>
            [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}")]
            public double PerPage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Retrieve requests completed after this time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#completed_after DataCloudflareCloudforceOneRequest#completed_after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "completedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompletedAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Retrieve requests completed before this time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#completed_before DataCloudflareCloudforceOneRequest#completed_before}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "completedBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompletedBefore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Retrieve requests created after this time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#created_after DataCloudflareCloudforceOneRequest#created_after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Retrieve requests created before this time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#created_before DataCloudflareCloudforceOneRequest#created_before}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedBefore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Requested information from request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#request_type DataCloudflareCloudforceOneRequest#request_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Field to sort results by.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#sort_by DataCloudflareCloudforceOneRequest#sort_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sort order (asc or desc). Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#sort_order DataCloudflareCloudforceOneRequest#sort_order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortOrder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Request Status. Available values: "open", "accepted", "reported", "approved", "completed", "declined".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/cloudforce_one_request#status DataCloudflareCloudforceOneRequest#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
