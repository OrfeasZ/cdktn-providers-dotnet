using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Workflow
{
    [JsiiInterface(nativeType: typeof(IWorkflowDefaultRetention), fullyQualifiedName: "cloudflare.workflow.WorkflowDefaultRetention")]
    public interface IWorkflowDefaultRetention
    {
        /// <summary>Specifies the duration in milliseconds or as a string like '5 minutes'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workflow#error_retention Workflow#error_retention}
        /// </remarks>
        [JsiiProperty(name: "errorRetention", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? ErrorRetention
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the duration in milliseconds or as a string like '5 minutes'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workflow#success_retention Workflow#success_retention}
        /// </remarks>
        [JsiiProperty(name: "successRetention", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? SuccessRetention
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkflowDefaultRetention), fullyQualifiedName: "cloudflare.workflow.WorkflowDefaultRetention")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Workflow.IWorkflowDefaultRetention
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the duration in milliseconds or as a string like '5 minutes'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workflow#error_retention Workflow#error_retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorRetention", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? ErrorRetention
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>Specifies the duration in milliseconds or as a string like '5 minutes'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workflow#success_retention Workflow#success_retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "successRetention", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? SuccessRetention
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }
        }
    }
}
