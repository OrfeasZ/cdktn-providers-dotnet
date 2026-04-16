using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersDeployment
{
    [JsiiByValue(fqn: "cloudflare.workersDeployment.WorkersDeploymentAnnotations")]
    public class WorkersDeploymentAnnotations : cloudflare.WorkersDeployment.IWorkersDeploymentAnnotations
    {
        /// <summary>Human-readable message about the deployment. Truncated to 100 bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#workers_message WorkersDeployment#workers_message}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workersMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkersMessage
        {
            get;
            set;
        }
    }
}
