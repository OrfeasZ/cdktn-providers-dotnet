using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersAlgorithms")]
    public class RulesetRulesActionParametersAlgorithms : cloudflare.Ruleset.IRulesetRulesActionParametersAlgorithms
    {
        /// <summary>Name of the compression algorithm to enable. Available values: "none", "auto", "default", "gzip", "brotli", "zstd".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#name Ruleset#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
