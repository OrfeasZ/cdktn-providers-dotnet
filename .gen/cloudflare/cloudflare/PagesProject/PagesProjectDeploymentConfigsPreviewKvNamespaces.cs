using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewKvNamespaces")]
    public class PagesProjectDeploymentConfigsPreviewKvNamespaces : cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewKvNamespaces
    {
        /// <summary>ID of the KV namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#namespace_id PagesProject#namespace_id}
        /// </remarks>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespaceId
        {
            get;
            set;
        }
    }
}
