using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectSource")]
    public class PagesProjectSource : cloudflare.PagesProject.IPagesProjectSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#config PagesProject#config}.</summary>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectSourceConfig\"}")]
        public cloudflare.PagesProject.IPagesProjectSourceConfig Config
        {
            get;
            set;
        }

        /// <summary>The source control management provider. Available values: "github", "gitlab".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#type PagesProject#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
