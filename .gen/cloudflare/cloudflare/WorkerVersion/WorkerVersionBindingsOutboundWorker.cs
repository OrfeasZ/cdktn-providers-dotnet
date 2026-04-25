using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionBindingsOutboundWorker")]
    public class WorkerVersionBindingsOutboundWorker : cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundWorker
    {
        /// <summary>Entrypoint to invoke on the outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#entrypoint WorkerVersion#entrypoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Entrypoint
        {
            get;
            set;
        }

        /// <summary>Environment of the outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#environment WorkerVersion#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Environment
        {
            get;
            set;
        }

        /// <summary>Name of the outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#service WorkerVersion#service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }
    }
}
