using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiByValue(fqn: "cloudflare.pipelineSink.PipelineSinkConfigPartitioning")]
    public class PipelineSinkConfigPartitioning : cloudflare.PipelineSink.IPipelineSinkConfigPartitioning
    {
        /// <summary>The pattern of the date string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#time_pattern PipelineSink#time_pattern}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timePattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimePattern
        {
            get;
            set;
        }
    }
}
