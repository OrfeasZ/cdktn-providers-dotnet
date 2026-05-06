using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheKeyCustomKeyQueryString), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryString")]
    public interface IRulesetRulesActionParametersCacheKeyCustomKeyQueryString
    {
        /// <summary>A list of query string parameters NOT used to build the cache key.</summary>
        /// <remarks>
        /// All parameters present in the request but missing in this list will be used to build the cache key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#exclude Ruleset#exclude}
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

        /// <summary>A list of query string parameters used to build the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#include Ruleset#include}
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

            /// <summary>A list of query string parameters NOT used to build the cache key.</summary>
            /// <remarks>
            /// All parameters present in the request but missing in this list will be used to build the cache key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#exclude Ruleset#exclude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude\"}", isOptional: true)]
            public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude? Exclude
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude?>();
            }

            /// <summary>A list of query string parameters used to build the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#include Ruleset#include}
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
