using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionMigrationsTransferredClasses")]
    public class WorkerVersionMigrationsTransferredClasses : cloudflare.WorkerVersion.IWorkerVersionMigrationsTransferredClasses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#from WorkerVersion#from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? From
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#from_script WorkerVersion#from_script}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FromScript
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#to WorkerVersion#to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? To
        {
            get;
            set;
        }
    }
}
