using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesRatelimit")]
    public class RulesetRulesRatelimit : cloudflare.Ruleset.IRulesetRulesRatelimit
    {
        /// <summary>Characteristics of the request on which the rate limit counter will be incremented.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#characteristics Ruleset#characteristics}
        /// </remarks>
        [JsiiProperty(name: "characteristics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Characteristics
        {
            get;
            set;
        }

        /// <summary>Period in seconds over which the counter is being incremented.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#period Ruleset#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        public double Period
        {
            get;
            set;
        }

        /// <summary>An expression that defines when the rate limit counter should be incremented.</summary>
        /// <remarks>
        /// It defaults to the same as the rule's expression.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#counting_expression Ruleset#counting_expression}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "countingExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CountingExpression
        {
            get;
            set;
        }

        /// <summary>Period of time in seconds after which the action will be disabled following its first execution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#mitigation_timeout Ruleset#mitigation_timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mitigationTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MitigationTimeout
        {
            get;
            set;
        }

        /// <summary>The threshold of requests per period after which the action will be executed for the first time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#requests_per_period Ruleset#requests_per_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestsPerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RequestsPerPeriod
        {
            get;
            set;
        }

        private object? _requestsToOrigin;

        /// <summary>Whether counting is only performed when an origin is reached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#requests_to_origin Ruleset#requests_to_origin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestsToOrigin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RequestsToOrigin
        {
            get => _requestsToOrigin;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestsToOrigin = value;
            }
        }

        /// <summary>The score threshold per period for which the action will be executed the first time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#score_per_period Ruleset#score_per_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scorePerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScorePerPeriod
        {
            get;
            set;
        }

        /// <summary>A response header name provided by the origin, which contains the score to increment rate limit counter with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#score_response_header_name Ruleset#score_response_header_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scoreResponseHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScoreResponseHeaderName
        {
            get;
            set;
        }
    }
}
