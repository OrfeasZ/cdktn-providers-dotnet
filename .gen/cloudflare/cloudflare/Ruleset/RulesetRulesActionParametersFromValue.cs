using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersFromValue")]
    public class RulesetRulesActionParametersFromValue : cloudflare.Ruleset.IRulesetRulesActionParametersFromValue
    {
        private object? _preserveQueryString;

        /// <summary>Keep the query string of the original request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#preserve_query_string Ruleset#preserve_query_string}
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

        /// <summary>The status code to be used for the redirect. Available values: 301, 302, 303, 307, 308.</summary>
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

        /// <summary>The URL to redirect the request to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#target_url Ruleset#target_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetUrl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromValueTargetUrl\"}", isOptional: true)]
        public cloudflare.Ruleset.IRulesetRulesActionParametersFromValueTargetUrl? TargetUrl
        {
            get;
            set;
        }
    }
}
