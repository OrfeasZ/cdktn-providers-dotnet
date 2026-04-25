using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiByValue(fqn: "cloudflare.pageRule.PageRuleActionsCacheKeyFieldsQueryString")]
    public class PageRuleActionsCacheKeyFieldsQueryString : cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsQueryString
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#exclude PageRule#exclude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Exclude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#include PageRule#include}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Include
        {
            get;
            set;
        }
    }
}
