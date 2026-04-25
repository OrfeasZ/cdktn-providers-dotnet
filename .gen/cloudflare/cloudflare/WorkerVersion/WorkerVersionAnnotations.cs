using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionAnnotations")]
    public class WorkerVersionAnnotations : cloudflare.WorkerVersion.IWorkerVersionAnnotations
    {
        /// <summary>Human-readable message about the version. Truncated to 1000 bytes if longer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#workers_message WorkerVersion#workers_message}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workersMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkersMessage
        {
            get;
            set;
        }

        /// <summary>User-provided identifier for the version. Maximum 100 bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#workers_tag WorkerVersion#workers_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workersTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkersTag
        {
            get;
            set;
        }
    }
}
