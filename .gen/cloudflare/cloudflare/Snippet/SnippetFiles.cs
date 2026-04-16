using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Snippet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.snippet.SnippetFiles")]
    public class SnippetFiles : cloudflare.Snippet.ISnippetFiles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet#content Snippet#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet#name Snippet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
