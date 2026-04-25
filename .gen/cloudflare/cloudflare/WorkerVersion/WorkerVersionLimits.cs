using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionLimits")]
    public class WorkerVersionLimits : cloudflare.WorkerVersion.IWorkerVersionLimits
    {
        /// <summary>CPU time limit in milliseconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#cpu_ms WorkerVersion#cpu_ms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuMs
        {
            get;
            set;
        }

        /// <summary>Subrequest limit per request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#subrequests WorkerVersion#subrequests}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subrequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Subrequests
        {
            get;
            set;
        }
    }
}
