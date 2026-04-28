using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesCacheStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesCacheStageConfig), fullyQualifiedName: "scaleway.edgeServicesCacheStage.EdgeServicesCacheStageConfig")]
    public interface IEdgeServicesCacheStageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the pipeline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#pipeline_id EdgeServicesCacheStage#pipeline_id}
        /// </remarks>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        string PipelineId
        {
            get;
        }

        /// <summary>The backend stage ID the cache stage will be linked to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#backend_stage_id EdgeServicesCacheStage#backend_stage_id}
        /// </remarks>
        [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackendStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Time To Live (TTL) in seconds. Defines how long content is cached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#fallback_ttl EdgeServicesCacheStage#fallback_ttl}
        /// </remarks>
        [JsiiProperty(name: "fallbackTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FallbackTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#id EdgeServicesCacheStage#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines whether responses to requests with cookies must be stored in the cache.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#include_cookies EdgeServicesCacheStage#include_cookies}
        /// </remarks>
        [JsiiProperty(name: "includeCookies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeCookies
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#project_id EdgeServicesCacheStage#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>purge_requests block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#purge_requests EdgeServicesCacheStage#purge_requests}
        /// </remarks>
        [JsiiProperty(name: "purgeRequests", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.edgeServicesCacheStage.EdgeServicesCacheStagePurgeRequests\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeRequests
        {
            get
            {
                return null;
            }
        }

        /// <summary>Trigger a refresh of the cache by changing this field's value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#refresh_cache EdgeServicesCacheStage#refresh_cache}
        /// </remarks>
        [JsiiProperty(name: "refreshCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefreshCache
        {
            get
            {
                return null;
            }
        }

        /// <summary>The route stage ID the cache stage will be linked to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#route_stage_id EdgeServicesCacheStage#route_stage_id}
        /// </remarks>
        [JsiiProperty(name: "routeStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteStageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The WAF stage ID the cache stage will be linked to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#waf_stage_id EdgeServicesCacheStage#waf_stage_id}
        /// </remarks>
        [JsiiProperty(name: "wafStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WafStageId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesCacheStageConfig), fullyQualifiedName: "scaleway.edgeServicesCacheStage.EdgeServicesCacheStageConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesCacheStage.IEdgeServicesCacheStageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the pipeline.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#pipeline_id EdgeServicesCacheStage#pipeline_id}
            /// </remarks>
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
            public string PipelineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The backend stage ID the cache stage will be linked to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#backend_stage_id EdgeServicesCacheStage#backend_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackendStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Time To Live (TTL) in seconds. Defines how long content is cached.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#fallback_ttl EdgeServicesCacheStage#fallback_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fallbackTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FallbackTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#id EdgeServicesCacheStage#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines whether responses to requests with cookies must be stored in the cache.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#include_cookies EdgeServicesCacheStage#include_cookies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeCookies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeCookies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#project_id EdgeServicesCacheStage#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>purge_requests block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#purge_requests EdgeServicesCacheStage#purge_requests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purgeRequests", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.edgeServicesCacheStage.EdgeServicesCacheStagePurgeRequests\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PurgeRequests
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Trigger a refresh of the cache by changing this field's value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#refresh_cache EdgeServicesCacheStage#refresh_cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refreshCache", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshCache
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The route stage ID the cache stage will be linked to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#route_stage_id EdgeServicesCacheStage#route_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteStageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The WAF stage ID the cache stage will be linked to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#waf_stage_id EdgeServicesCacheStage#waf_stage_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wafStageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WafStageId
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
