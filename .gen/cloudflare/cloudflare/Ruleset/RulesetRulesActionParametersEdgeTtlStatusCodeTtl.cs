using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtl")]
    public class RulesetRulesActionParametersEdgeTtlStatusCodeTtl : cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtl
    {
        /// <summary>Time to cache a response (in seconds).</summary>
        /// <remarks>
        /// A value of 0 is equivalent to setting the Cache-Control header with the value "no-cache". A value of -1 is equivalent to setting Cache-Control header with the value of "no-store".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#value Ruleset#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }

        /// <summary>Set the TTL for responses with this specific status code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#status_code Ruleset#status_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StatusCode
        {
            get;
            set;
        }

        /// <summary>The range of status codes used to apply the selected mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#status_code_range Ruleset#status_code_range}
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
