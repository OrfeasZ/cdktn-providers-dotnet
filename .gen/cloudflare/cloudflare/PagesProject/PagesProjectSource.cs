using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectSource")]
    public class PagesProjectSource : cloudflare.PagesProject.IPagesProjectSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#config PagesProject#config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectSourceConfig\"}", isOptional: true)]
        public cloudflare.PagesProject.IPagesProjectSourceConfig? Config
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#type PagesProject#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
