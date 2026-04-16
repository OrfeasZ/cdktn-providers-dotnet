using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryString")]
    public class RulesetRulesActionParametersCacheKeyCustomKeyQueryString : cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryString
    {
        /// <summary>Which query string parameters to exclude from the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#exclude Ruleset#exclude}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExclude? Exclude
        {
            get;
            set;
        }

        /// <summary>Which query string parameters to include in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#include Ruleset#include}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryStringInclude? Include
        {
            get;
            set;
        }
    }
}
