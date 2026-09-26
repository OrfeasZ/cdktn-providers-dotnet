using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.worker.WorkerPreviewsBaseConfigEnv")]
    public class WorkerPreviewsBaseConfigEnv : cloudflare.Worker.IWorkerPreviewsBaseConfigEnv
    {
        /// <summary>The kind of resource that the binding provides.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#type Worker#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
