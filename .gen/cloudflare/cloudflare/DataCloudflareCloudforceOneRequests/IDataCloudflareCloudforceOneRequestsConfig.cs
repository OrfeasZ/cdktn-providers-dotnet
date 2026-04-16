using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCloudforceOneRequests
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareCloudforceOneRequestsConfig), fullyQualifiedName: "cloudflare.dataCloudflareCloudforceOneRequests.DataCloudflareCloudforceOneRequestsConfig")]
    public interface IDataCloudflareCloudforceOneRequestsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#account_id DataCloudflareCloudforceOneRequests#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Page number of results.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#page DataCloudflareCloudforceOneRequests#page}
        /// </remarks>
        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}")]
        double Page
        {
            get;
        }

        /// <summary>Number of results per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#per_page DataCloudflareCloudforceOneRequests#per_page}
        /// </remarks>
        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}")]
        double PerPage
        {
            get;
        }

        /// <summary>Retrieve requests completed after this time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#completed_after DataCloudflareCloudforceOneRequests#completed_after}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#completed_before DataCloudflareCloudforceOneRequests#completed_before}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#created_after DataCloudflareCloudforceOneRequests#created_after}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#created_before DataCloudflareCloudforceOneRequests#created_before}
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

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#max_items DataCloudflareCloudforceOneRequests#max_items}
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

        /// <summary>Requested information from request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#request_type DataCloudflareCloudforceOneRequests#request_type}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#sort_by DataCloudflareCloudforceOneRequests#sort_by}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#sort_order DataCloudflareCloudforceOneRequests#sort_order}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#status DataCloudflareCloudforceOneRequests#status}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareCloudforceOneRequestsConfig), fullyQualifiedName: "cloudflare.dataCloudflareCloudforceOneRequests.DataCloudflareCloudforceOneRequestsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareCloudforceOneRequests.IDataCloudflareCloudforceOneRequestsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#account_id DataCloudflareCloudforceOneRequests#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Page number of results.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#page DataCloudflareCloudforceOneRequests#page}
            /// </remarks>
            [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"number\"}")]
            public double Page
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Number of results per page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#per_page DataCloudflareCloudforceOneRequests#per_page}
            /// </remarks>
            [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}")]
            public double PerPage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Retrieve requests completed after this time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#completed_after DataCloudflareCloudforceOneRequests#completed_after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "completedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompletedAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Retrieve requests completed before this time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#completed_before DataCloudflareCloudforceOneRequests#completed_before}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "completedBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompletedBefore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Retrieve requests created after this time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#created_after DataCloudflareCloudforceOneRequests#created_after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Retrieve requests created before this time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#created_before DataCloudflareCloudforceOneRequests#created_before}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedBefore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#max_items DataCloudflareCloudforceOneRequests#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Requested information from request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#request_type DataCloudflareCloudforceOneRequests#request_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Field to sort results by.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#sort_by DataCloudflareCloudforceOneRequests#sort_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sortBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sort order (asc or desc). Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#sort_order DataCloudflareCloudforceOneRequests#sort_order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortOrder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Request Status. Available values: "open", "accepted", "reported", "approved", "completed", "declined".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/cloudforce_one_requests#status DataCloudflareCloudforceOneRequests#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
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
