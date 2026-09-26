using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerPreviewsBaseConfigLimits), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigLimits")]
    public interface IWorkerPreviewsBaseConfigLimits
    {
        /// <summary>The amount of CPU time this Worker can use in milliseconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#cpu_ms Worker#cpu_ms}
        /// </remarks>
        [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of subrequests this Worker can make per request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#subrequests Worker#subrequests}
        /// </remarks>
        [JsiiProperty(name: "subrequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Subrequests
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerPreviewsBaseConfigLimits), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigLimits")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerPreviewsBaseConfigLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount of CPU time this Worker can use in milliseconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#cpu_ms Worker#cpu_ms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuMs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of subrequests this Worker can make per request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#subrequests Worker#subrequests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subrequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Subrequests
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
