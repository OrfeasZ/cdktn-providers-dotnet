using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Workflow
{
    [JsiiInterface(nativeType: typeof(IWorkflowSchedules), fullyQualifiedName: "cloudflare.workflow.WorkflowSchedules")]
    public interface IWorkflowSchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/workflow#cron Workflow#cron}.</summary>
        [JsiiProperty(name: "cron", typeJson: "{\"primitive\":\"string\"}")]
        string Cron
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkflowSchedules), fullyQualifiedName: "cloudflare.workflow.WorkflowSchedules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Workflow.IWorkflowSchedules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/workflow#cron Workflow#cron}.</summary>
            [JsiiProperty(name: "cron", typeJson: "{\"primitive\":\"string\"}")]
            public string Cron
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
