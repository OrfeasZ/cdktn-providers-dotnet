using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookie")]
    public class RulesetRulesActionParametersCacheKeyCustomKeyCookie : cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyCookie
    {
        /// <summary>A list of cookies to check for the presence of.</summary>
        /// <remarks>
        /// The presence of these cookies is included in the cache key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#check_presence Ruleset#check_presence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "checkPresence", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CheckPresence
        {
            get;
            set;
        }

        /// <summary>A list of cookies to include in the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#include Ruleset#include}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Include
        {
            get;
            set;
        }
    }
}
