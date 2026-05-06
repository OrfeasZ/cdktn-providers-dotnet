using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange")]
    public class RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange : cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange
    {
        /// <summary>Response status code lower bound.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#from Ruleset#from}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? From
        {
            get;
            set;
        }

        /// <summary>Response status code upper bound.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#to Ruleset#to}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? To
        {
            get;
            set;
        }
    }
}
