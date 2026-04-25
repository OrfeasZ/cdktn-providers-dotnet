using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersFromValue")]
    public class RulesetRulesActionParametersFromValue : cloudflare.Ruleset.IRulesetRulesActionParametersFromValue
    {
        /// <summary>A URL to redirect the request to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#target_url Ruleset#target_url}
        /// </remarks>
        [JsiiProperty(name: "targetUrl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromValueTargetUrl\"}")]
        public cloudflare.Ruleset.IRulesetRulesActionParametersFromValueTargetUrl TargetUrl
        {
            get;
            set;
        }

        private object? _preserveQueryString;

        /// <summary>Whether to keep the query string of the original request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#preserve_query_string Ruleset#preserve_query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preserveQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PreserveQueryString
        {
            get => _preserveQueryString;
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
                _preserveQueryString = value;
            }
        }

        /// <summary>The status code to use for the redirect.</summary>
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
    }
}
