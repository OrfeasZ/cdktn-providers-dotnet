using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Workflow
{
    [JsiiByValue(fqn: "cloudflare.workflow.WorkflowDefaultRetention")]
    public class WorkflowDefaultRetention : cloudflare.Workflow.IWorkflowDefaultRetention
    {
        /// <summary>Specifies the duration in milliseconds or as a string like '5 minutes'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/workflow#error_retention Workflow#error_retention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorRetention", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? ErrorRetention
        {
            get;
            set;
        }

        /// <summary>Specifies the duration in milliseconds or as a string like '5 minutes'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/workflow#success_retention Workflow#success_retention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "successRetention", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? SuccessRetention
        {
            get;
            set;
        }
    }
}
