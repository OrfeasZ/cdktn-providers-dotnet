using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Workflow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workflow.WorkflowSchedules")]
    public class WorkflowSchedules : cloudflare.Workflow.IWorkflowSchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/workflow#cron Workflow#cron}.</summary>
        [JsiiProperty(name: "cron", typeJson: "{\"primitive\":\"string\"}")]
        public string Cron
        {
            get;
            set;
        }
    }
}
