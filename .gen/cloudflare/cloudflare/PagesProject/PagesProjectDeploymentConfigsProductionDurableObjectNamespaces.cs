using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespaces")]
    public class PagesProjectDeploymentConfigsProductionDurableObjectNamespaces : cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionDurableObjectNamespaces
    {
        /// <summary>ID of the Durable Object namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#namespace_id PagesProject#namespace_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamespaceId
        {
            get;
            set;
        }
    }
}
