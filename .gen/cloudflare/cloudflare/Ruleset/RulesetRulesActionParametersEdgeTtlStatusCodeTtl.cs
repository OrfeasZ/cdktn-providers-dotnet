using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtl")]
    public class RulesetRulesActionParametersEdgeTtlStatusCodeTtl : cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtl
    {
        /// <summary>The time to cache the response for (in seconds).</summary>
        /// <remarks>
        /// A value of 0 is equivalent to setting the cache control header with the value "no-cache". A value of -1 is equivalent to setting the cache control header with the value of "no-store".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#value Ruleset#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }

        /// <summary>A single status code to apply the TTL to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#status_code Ruleset#status_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StatusCode
        {
            get;
            set;
        }

        /// <summary>A range of status codes to apply the TTL to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#status_code_range Ruleset#status_code_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCodeRange", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange? StatusCodeRange
        {
            get;
            set;
        }
    }
}
