using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiByValue(fqn: "cloudflare.pipelineSink.PipelineSinkConfigRollingPolicy")]
    public class PipelineSinkConfigRollingPolicy : cloudflare.PipelineSink.IPipelineSinkConfigRollingPolicy
    {
        /// <summary>Files will be rolled after reaching this number of bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#file_size_bytes PipelineSink#file_size_bytes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FileSizeBytes
        {
            get;
            set;
        }

        /// <summary>Number of seconds of inactivity to wait before rolling over to a new file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#inactivity_seconds PipelineSink#inactivity_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inactivitySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InactivitySeconds
        {
            get;
            set;
        }

        /// <summary>Number of seconds to wait before rolling over to a new file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#interval_seconds PipelineSink#interval_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalSeconds
        {
            get;
            set;
        }
    }
}
