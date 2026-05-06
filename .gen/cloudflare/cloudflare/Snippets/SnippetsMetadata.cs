using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Snippets
{
    [JsiiByValue(fqn: "cloudflare.snippets.SnippetsMetadata")]
    public class SnippetsMetadata : cloudflare.Snippets.ISnippetsMetadata
    {
        /// <summary>Main module name of uploaded snippet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/snippets#main_module Snippets#main_module}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MainModule
        {
            get;
            set;
        }
    }
}
