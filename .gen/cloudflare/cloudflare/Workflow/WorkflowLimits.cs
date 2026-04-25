using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Workflow
{
    [JsiiByValue(fqn: "cloudflare.workflow.WorkflowLimits")]
    public class WorkflowLimits : cloudflare.Workflow.IWorkflowLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workflow#steps Workflow#steps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "steps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Steps
        {
            get;
            set;
        }
    }
}
