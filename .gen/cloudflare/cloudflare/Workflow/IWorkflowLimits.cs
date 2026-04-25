using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Workflow
{
    [JsiiInterface(nativeType: typeof(IWorkflowLimits), fullyQualifiedName: "cloudflare.workflow.WorkflowLimits")]
    public interface IWorkflowLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workflow#steps Workflow#steps}.</summary>
        [JsiiProperty(name: "steps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Steps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkflowLimits), fullyQualifiedName: "cloudflare.workflow.WorkflowLimits")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Workflow.IWorkflowLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workflow#steps Workflow#steps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "steps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Steps
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
