using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionContainers")]
    public class WorkerVersionContainers : cloudflare.WorkerVersion.IWorkerVersionContainers
    {
        /// <summary>Select which Durable Object class should get this container attached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#class_name WorkerVersion#class_name}
        /// </remarks>
        [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}")]
        public string ClassName
        {
            get;
            set;
        }
    }
}
