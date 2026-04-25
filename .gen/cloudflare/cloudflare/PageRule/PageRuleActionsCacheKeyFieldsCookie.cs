using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiByValue(fqn: "cloudflare.pageRule.PageRuleActionsCacheKeyFieldsCookie")]
    public class PageRuleActionsCacheKeyFieldsCookie : cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsCookie
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#check_presence PageRule#check_presence}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "checkPresence", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CheckPresence
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
