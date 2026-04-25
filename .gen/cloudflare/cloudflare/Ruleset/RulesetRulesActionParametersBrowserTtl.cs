using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersBrowserTtl")]
    public class RulesetRulesActionParametersBrowserTtl : cloudflare.Ruleset.IRulesetRulesActionParametersBrowserTtl
    {
        /// <summary>The browser TTL mode. Available values: "respect_origin", "bypass_by_default", "override_origin", "bypass".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#mode Ruleset#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>The browser TTL (in seconds) if you choose the "override_origin" mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#default Ruleset#default}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Default
        {
            get;
            set;
        }
    }
}
