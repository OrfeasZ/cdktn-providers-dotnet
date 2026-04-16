using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesCacheStage
{
    [JsiiByValue(fqn: "scaleway.edgeServicesCacheStage.EdgeServicesCacheStagePurgeRequests")]
    public class EdgeServicesCacheStagePurgeRequests : scaleway.EdgeServicesCacheStage.IEdgeServicesCacheStagePurgeRequests
    {
        private object? _all;

        /// <summary>Defines whether to purge all content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_cache_stage#all EdgeServicesCacheStage#all}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? All
        {
            get => _all;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _all = value;
            }
        }

        /// <summary>The list of asserts to purge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_cache_stage#assets EdgeServicesCacheStage#assets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Assets
        {
            get;
            set;
        }

        /// <summary>The pipeline ID in which the purge request will be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_cache_stage#pipeline_id EdgeServicesCacheStage#pipeline_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PipelineId
        {
            get;
            set;
        }
    }
}
