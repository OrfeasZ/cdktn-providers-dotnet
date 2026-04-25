using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewQueueProducers")]
    public class PagesProjectDeploymentConfigsPreviewQueueProducers : cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewQueueProducers
    {
        /// <summary>Name of the Queue.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#name PagesProject#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
