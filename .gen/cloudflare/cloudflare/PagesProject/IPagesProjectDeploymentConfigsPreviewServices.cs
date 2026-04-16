using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewServices), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewServices")]
    public interface IPagesProjectDeploymentConfigsPreviewServices
    {
        /// <summary>The Service name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#service PagesProject#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        string Service
        {
            get;
        }

        /// <summary>The entrypoint to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#entrypoint PagesProject#entrypoint}
        /// </remarks>
        [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Entrypoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Service environment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#environment PagesProject#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Environment
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewServices), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewServices")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewServices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Service name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#service PagesProject#service}
            /// </remarks>
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
            public string Service
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The entrypoint to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#entrypoint PagesProject#entrypoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Entrypoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Service environment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#environment PagesProject#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Environment
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
