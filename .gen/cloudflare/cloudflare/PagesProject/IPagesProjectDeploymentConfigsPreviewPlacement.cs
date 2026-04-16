using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewPlacement), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewPlacement")]
    public interface IPagesProjectDeploymentConfigsPreviewPlacement
    {
        /// <summary>Placement mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#mode PagesProject#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewPlacement), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewPlacement")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewPlacement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Placement mode.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#mode PagesProject#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
