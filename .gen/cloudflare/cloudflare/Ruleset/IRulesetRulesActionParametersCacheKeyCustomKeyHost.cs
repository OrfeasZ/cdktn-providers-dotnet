using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyHost), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHost")]
    public interface IRulesetRulesActionParametersCacheKeyCustomKeyHost
    {
        /// <summary>Whether to use the resolved host in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#resolved Ruleset#resolved}
        /// </remarks>
        [JsiiProperty(name: "resolved", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Resolved
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyHost), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHost")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyHost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to use the resolved host in the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#resolved Ruleset#resolved}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resolved", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Resolved
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
