using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiByValue(fqn: "cloudflare.pageRule.PageRuleActionsCacheKeyFields")]
    public class PageRuleActionsCacheKeyFields : cloudflare.PageRule.IPageRuleActionsCacheKeyFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#cookie PageRule#cookie}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsCookie\"}", isOptional: true)]
        public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsCookie? Cookie
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#header PageRule#header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHeader\"}", isOptional: true)]
        public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHeader? Header
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#host PageRule#host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHost\"}", isOptional: true)]
        public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHost? Host
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#query_string PageRule#query_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsQueryString\"}", isOptional: true)]
        public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsQueryString? QueryString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#user PageRule#user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsUser\"}", isOptional: true)]
        public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsUser? User
        {
            get;
            set;
        }
    }
}
