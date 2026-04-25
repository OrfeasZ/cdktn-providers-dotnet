using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiInterface(nativeType: typeof(IPipelineSinkConfigPartitioning), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigPartitioning")]
    public interface IPipelineSinkConfigPartitioning
    {
        /// <summary>The pattern of the date string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#time_pattern PipelineSink#time_pattern}
        /// </remarks>
        [JsiiProperty(name: "timePattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimePattern
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineSinkConfigPartitioning), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigPartitioning")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineSink.IPipelineSinkConfigPartitioning
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The pattern of the date string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#time_pattern PipelineSink#time_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timePattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimePattern
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
