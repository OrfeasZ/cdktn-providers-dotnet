using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewQueueProducers), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewQueueProducers")]
    public interface IPagesProjectDeploymentConfigsPreviewQueueProducers
    {
        /// <summary>Name of the Queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#name PagesProject#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewQueueProducers), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewQueueProducers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewQueueProducers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the Queue.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#name PagesProject#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
