using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersUri")]
    public class RulesetRulesActionParametersUri : cloudflare.Ruleset.IRulesetRulesActionParametersUri
    {
        /// <summary>A URI path rewrite.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#path Ruleset#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriPath\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersUriPath? Path
        {
            get;
            set;
        }

        /// <summary>A URI query rewrite.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#query Ruleset#query}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersUriQuery\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersUriQuery? Query
        {
            get;
            set;
        }
    }
}
