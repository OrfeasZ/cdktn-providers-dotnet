using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersDeployment
{
    [JsiiInterface(nativeType: typeof(IWorkersDeploymentAnnotations), fullyQualifiedName: "cloudflare.workersDeployment.WorkersDeploymentAnnotations")]
    public interface IWorkersDeploymentAnnotations
    {
        /// <summary>Human-readable message about the deployment. Truncated to 100 bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#workers_message WorkersDeployment#workers_message}
        /// </remarks>
        [JsiiProperty(name: "workersMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkersMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersDeploymentAnnotations), fullyQualifiedName: "cloudflare.workersDeployment.WorkersDeploymentAnnotations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersDeployment.IWorkersDeploymentAnnotations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Human-readable message about the deployment. Truncated to 100 bytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#workers_message WorkersDeployment#workers_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workersMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkersMessage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
