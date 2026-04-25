using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pageRule.PageRuleActionsForwardingUrl")]
    public class PageRuleActionsForwardingUrl : cloudflare.PageRule.IPageRuleActionsForwardingUrl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#status_code PageRule#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        public double StatusCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#url PageRule#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }
    }
}
