using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiInterface(nativeType: typeof(IPageRuleActionsCacheKeyFieldsHost), fullyQualifiedName: "cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHost")]
    public interface IPageRuleActionsCacheKeyFieldsHost
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#resolved PageRule#resolved}.</summary>
        [JsiiProperty(name: "resolved", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Resolved
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPageRuleActionsCacheKeyFieldsHost), fullyQualifiedName: "cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHost")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/page_rule#resolved PageRule#resolved}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resolved", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Resolved
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
