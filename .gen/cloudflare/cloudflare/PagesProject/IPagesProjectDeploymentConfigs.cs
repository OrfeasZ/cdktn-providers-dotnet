using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigs), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigs")]
    public interface IPagesProjectDeploymentConfigs
    {
        /// <summary>Configs for preview deploys.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#preview PagesProject#preview}
        /// </remarks>
        [JsiiProperty(name: "preview", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreview\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreview? Preview
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configs for production deploys.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#production PagesProject#production}
        /// </remarks>
        [JsiiProperty(name: "production", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction? Production
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigs), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigs")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configs for preview deploys.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#preview PagesProject#preview}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preview", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreview\"}", isOptional: true)]
            public cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreview? Preview
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreview?>();
            }

            /// <summary>Configs for production deploys.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#production PagesProject#production}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "production", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction\"}", isOptional: true)]
            public cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction? Production
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction?>();
            }
        }
    }
}
