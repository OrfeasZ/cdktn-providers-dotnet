using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Workflow
{
    [JsiiInterface(nativeType: typeof(IWorkflowConcurrency), fullyQualifiedName: "cloudflare.workflow.WorkflowConcurrency")]
    public interface IWorkflowConcurrency
    {
        /// <summary>Maximum number of instances of this workflow that can run concurrently.</summary>
        /// <remarks>
        /// Additional instances are queued and started as running instances complete. Must not exceed the account concurrency limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workflow#limit Workflow#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkflowConcurrency), fullyQualifiedName: "cloudflare.workflow.WorkflowConcurrency")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Workflow.IWorkflowConcurrency
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Maximum number of instances of this workflow that can run concurrently.</summary>
            /// <remarks>
            /// Additional instances are queued and started as running instances complete. Must not exceed the account concurrency limit.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/workflow#limit Workflow#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
