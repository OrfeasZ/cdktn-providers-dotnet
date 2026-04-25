using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyQueryString), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryString")]
    public interface IRulesetRulesActionParametersCacheKeyCustomKeyQueryString
    {
        /// <summary>Which query string parameters to exclude from the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#exclude Ruleset#exclude}
        /// </remarks>
        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude? Exclude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which query string parameters to include in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#include Ruleset#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude? Include
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyQueryString), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryString")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryString
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Which query string parameters to exclude from the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#exclude Ruleset#exclude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude? Exclude
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude?>();
            }

            /// <summary>Which query string parameters to include in the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#include Ruleset#include}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude? Include
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude?>();
            }
        }
    }
}
