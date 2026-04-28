using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesCacheStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesCacheStagePurgeRequests), fullyQualifiedName: "scaleway.edgeServicesCacheStage.EdgeServicesCacheStagePurgeRequests")]
    public interface IEdgeServicesCacheStagePurgeRequests
    {
        /// <summary>Defines whether to purge all content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#all EdgeServicesCacheStage#all}
        /// </remarks>
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? All
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of asserts to purge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#assets EdgeServicesCacheStage#assets}
        /// </remarks>
        [JsiiProperty(name: "assets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Assets
        {
            get
            {
                return null;
            }
        }

        /// <summary>The pipeline ID in which the purge request will be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#pipeline_id EdgeServicesCacheStage#pipeline_id}
        /// </remarks>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesCacheStagePurgeRequests), fullyQualifiedName: "scaleway.edgeServicesCacheStage.EdgeServicesCacheStagePurgeRequests")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesCacheStage.IEdgeServicesCacheStagePurgeRequests
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines whether to purge all content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#all EdgeServicesCacheStage#all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? All
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The list of asserts to purge.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#assets EdgeServicesCacheStage#assets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Assets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The pipeline ID in which the purge request will be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_cache_stage#pipeline_id EdgeServicesCacheStage#pipeline_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
