using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude")]
    public interface IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude
    {
        /// <summary>Whether to include all query string parameters in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#all Ruleset#all}
        /// </remarks>
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? All
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of query string parameters to include in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#list Ruleset#list}
        /// </remarks>
        [JsiiProperty(name: "list", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? List
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to include all query string parameters in the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#all Ruleset#all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? All
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of query string parameters to include in the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#list Ruleset#list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "list", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? List
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
