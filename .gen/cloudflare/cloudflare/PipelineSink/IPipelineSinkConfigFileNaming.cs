using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiInterface(nativeType: typeof(IPipelineSinkConfigFileNaming), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigFileNaming")]
    public interface IPipelineSinkConfigFileNaming
    {
        /// <summary>The prefix to use in file name. i.e prefix-&lt;uuid&gt;.parquet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#prefix PipelineSink#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filename generation strategy. Available values: "serial", "uuid", "uuid_v7", "ulid".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#strategy PipelineSink#strategy}
        /// </remarks>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Strategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>This will overwrite the default file suffix. i.e .parquet, use with caution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#suffix PipelineSink#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Suffix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineSinkConfigFileNaming), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigFileNaming")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineSink.IPipelineSinkConfigFileNaming
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The prefix to use in file name. i.e prefix-&lt;uuid&gt;.parquet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#prefix PipelineSink#prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filename generation strategy. Available values: "serial", "uuid", "uuid_v7", "ulid".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#strategy PipelineSink#strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Strategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This will overwrite the default file suffix. i.e .parquet, use with caution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#suffix PipelineSink#suffix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Suffix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
