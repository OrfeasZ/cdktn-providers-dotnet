using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionLimits), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionLimits")]
    public interface IWorkerVersionLimits
    {
        /// <summary>CPU time limit in milliseconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#cpu_ms WorkerVersion#cpu_ms}
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

        /// <summary>Subrequest limit per request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#subrequests WorkerVersion#subrequests}
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

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionLimits), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionLimits")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>CPU time limit in milliseconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#cpu_ms WorkerVersion#cpu_ms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuMs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Subrequest limit per request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#subrequests WorkerVersion#subrequests}
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
