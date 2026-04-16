using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesRatelimit), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesRatelimit")]
    public interface IRulesetRulesRatelimit
    {
        /// <summary>Characteristics of the request on which the rate limit counter will be incremented.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#characteristics Ruleset#characteristics}
        /// </remarks>
        [JsiiProperty(name: "characteristics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Characteristics
        {
            get;
        }

        /// <summary>Period in seconds over which the counter is being incremented.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#period Ruleset#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        double Period
        {
            get;
        }

        /// <summary>An expression that defines when the rate limit counter should be incremented.</summary>
        /// <remarks>
        /// It defaults to the same as the rule's expression.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#counting_expression Ruleset#counting_expression}
        /// </remarks>
        [JsiiProperty(name: "countingExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CountingExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Period of time in seconds after which the action will be disabled following its first execution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#mitigation_timeout Ruleset#mitigation_timeout}
        /// </remarks>
        [JsiiProperty(name: "mitigationTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MitigationTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>The threshold of requests per period after which the action will be executed for the first time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#requests_per_period Ruleset#requests_per_period}
        /// </remarks>
        [JsiiProperty(name: "requestsPerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RequestsPerPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether counting is only performed when an origin is reached.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#requests_to_origin Ruleset#requests_to_origin}
        /// </remarks>
        [JsiiProperty(name: "requestsToOrigin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestsToOrigin
        {
            get
            {
                return null;
            }
        }

        /// <summary>The score threshold per period for which the action will be executed the first time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#score_per_period Ruleset#score_per_period}
        /// </remarks>
        [JsiiProperty(name: "scorePerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScorePerPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>A response header name provided by the origin, which contains the score to increment rate limit counter with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#score_response_header_name Ruleset#score_response_header_name}
        /// </remarks>
        [JsiiProperty(name: "scoreResponseHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScoreResponseHeaderName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesRatelimit), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesRatelimit")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesRatelimit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Characteristics of the request on which the rate limit counter will be incremented.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#characteristics Ruleset#characteristics}
            /// </remarks>
            [JsiiProperty(name: "characteristics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Characteristics
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Period in seconds over which the counter is being incremented.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#period Ruleset#period}
            /// </remarks>
            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
            public double Period
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>An expression that defines when the rate limit counter should be incremented.</summary>
            /// <remarks>
            /// It defaults to the same as the rule's expression.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#counting_expression Ruleset#counting_expression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "countingExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CountingExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Period of time in seconds after which the action will be disabled following its first execution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#mitigation_timeout Ruleset#mitigation_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mitigationTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MitigationTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The threshold of requests per period after which the action will be executed for the first time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#requests_per_period Ruleset#requests_per_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestsPerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RequestsPerPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether counting is only performed when an origin is reached.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#requests_to_origin Ruleset#requests_to_origin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestsToOrigin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequestsToOrigin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The score threshold per period for which the action will be executed the first time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#score_per_period Ruleset#score_per_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scorePerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScorePerPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A response header name provided by the origin, which contains the score to increment rate limit counter with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#score_response_header_name Ruleset#score_response_header_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scoreResponseHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScoreResponseHeaderName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
