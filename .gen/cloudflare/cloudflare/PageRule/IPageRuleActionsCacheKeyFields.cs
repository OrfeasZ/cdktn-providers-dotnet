using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiInterface(nativeType: typeof(IPageRuleActionsCacheKeyFields), fullyQualifiedName: "cloudflare.pageRule.PageRuleActionsCacheKeyFields")]
    public interface IPageRuleActionsCacheKeyFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#cookie PageRule#cookie}.</summary>
        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsCookie\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsCookie? Cookie
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#header PageRule#header}.</summary>
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHeader? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#host PageRule#host}.</summary>
        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHost\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHost? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#query_string PageRule#query_string}.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsQueryString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsQueryString? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#user PageRule#user}.</summary>
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsUser? User
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPageRuleActionsCacheKeyFields), fullyQualifiedName: "cloudflare.pageRule.PageRuleActionsCacheKeyFields")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PageRule.IPageRuleActionsCacheKeyFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#cookie PageRule#cookie}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsCookie\"}", isOptional: true)]
            public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsCookie? Cookie
            {
                get => GetInstanceProperty<cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsCookie?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#header PageRule#header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHeader\"}", isOptional: true)]
            public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHeader? Header
            {
                get => GetInstanceProperty<cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHeader?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#host PageRule#host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHost\"}", isOptional: true)]
            public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHost? Host
            {
                get => GetInstanceProperty<cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHost?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#query_string PageRule#query_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsQueryString\"}", isOptional: true)]
            public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsQueryString? QueryString
            {
                get => GetInstanceProperty<cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsQueryString?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#user PageRule#user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsUser\"}", isOptional: true)]
            public cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsUser? User
            {
                get => GetInstanceProperty<cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsUser?>();
            }
        }
    }
}
