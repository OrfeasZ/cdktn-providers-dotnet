using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.worker.WorkerTailConsumers")]
    public class WorkerTailConsumers : cloudflare.Worker.IWorkerTailConsumers
    {
        /// <summary>Name of the consumer Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker#name Worker#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
