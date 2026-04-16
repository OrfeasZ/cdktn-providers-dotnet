using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigs")]
    public class PagesProjectDeploymentConfigs : cloudflare.PagesProject.IPagesProjectDeploymentConfigs
    {
        /// <summary>Configs for preview deploys.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#preview PagesProject#preview}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preview", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreview\"}", isOptional: true)]
        public cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreview? Preview
        {
            get;
            set;
        }

        /// <summary>Configs for production deploys.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#production PagesProject#production}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "production", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction\"}", isOptional: true)]
        public cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction? Production
        {
            get;
            set;
        }
    }
}
