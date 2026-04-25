using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiInterface(nativeType: typeof(IPipelineSinkConfigRollingPolicy), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigRollingPolicy")]
    public interface IPipelineSinkConfigRollingPolicy
    {
        /// <summary>Files will be rolled after reaching this number of bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#file_size_bytes PipelineSink#file_size_bytes}
        /// </remarks>
        [JsiiProperty(name: "fileSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FileSizeBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of seconds of inactivity to wait before rolling over to a new file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#inactivity_seconds PipelineSink#inactivity_seconds}
        /// </remarks>
        [JsiiProperty(name: "inactivitySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InactivitySeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of seconds to wait before rolling over to a new file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#interval_seconds PipelineSink#interval_seconds}
        /// </remarks>
        [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntervalSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineSinkConfigRollingPolicy), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigRollingPolicy")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineSink.IPipelineSinkConfigRollingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Files will be rolled after reaching this number of bytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#file_size_bytes PipelineSink#file_size_bytes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FileSizeBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of seconds of inactivity to wait before rolling over to a new file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#inactivity_seconds PipelineSink#inactivity_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inactivitySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InactivitySeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Number of seconds to wait before rolling over to a new file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#interval_seconds PipelineSink#interval_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
