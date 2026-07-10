using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersVaryHeaders")]
    public class RulesetRulesActionParametersVaryHeaders : cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders
    {
        /// <summary>How the header value is treated when building the cache key. Available values: "bypass", "passthrough", "normalize".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ruleset#action Ruleset#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>The set of languages to normalize against. Only valid for the `accept-language` header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ruleset#languages Ruleset#languages}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "languages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Languages
        {
            get;
            set;
        }

        /// <summary>The set of media types to normalize against. Only valid for the `accept` header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ruleset#media_types Ruleset#media_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mediaTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MediaTypes
        {
            get;
            set;
        }
    }
}
