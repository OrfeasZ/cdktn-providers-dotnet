using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiByValue(fqn: "cloudflare.pipelineSink.PipelineSinkConfigFileNaming")]
    public class PipelineSinkConfigFileNaming : cloudflare.PipelineSink.IPipelineSinkConfigFileNaming
    {
        /// <summary>The prefix to use in file name. i.e prefix-&lt;uuid&gt;.parquet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#prefix PipelineSink#prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Filename generation strategy. Available values: "serial", "uuid", "uuid_v7", "ulid".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#strategy PipelineSink#strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Strategy
        {
            get;
            set;
        }

        /// <summary>This will overwrite the default file suffix. i.e .parquet, use with caution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#suffix PipelineSink#suffix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Suffix
        {
            get;
            set;
        }
    }
}
