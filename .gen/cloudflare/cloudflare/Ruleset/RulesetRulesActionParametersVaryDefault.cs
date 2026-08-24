using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersVaryDefault")]
    public class RulesetRulesActionParametersVaryDefault : cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault
    {
        /// <summary>How the header value is treated when building the cache key. Available values: "bypass", "passthrough", "normalize".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ruleset#action Ruleset#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }
    }
}
