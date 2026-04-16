using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiInterface(nativeType: typeof(IPageRuleActionsForwardingUrl), fullyQualifiedName: "cloudflare.pageRule.PageRuleActionsForwardingUrl")]
    public interface IPageRuleActionsForwardingUrl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#status_code PageRule#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        double StatusCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#url PageRule#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPageRuleActionsForwardingUrl), fullyQualifiedName: "cloudflare.pageRule.PageRuleActionsForwardingUrl")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PageRule.IPageRuleActionsForwardingUrl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#status_code PageRule#status_code}.</summary>
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
            public double StatusCode
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/page_rule#url PageRule#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
