using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtl")]
    public class RulesetRulesActionParametersEdgeTtl : cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtl
    {
        /// <summary>The edge TTL mode. Available values: "respect_origin", "bypass_by_default", "override_origin".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#mode Ruleset#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>The edge TTL (in seconds) if you choose the "override_origin" mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#default Ruleset#default}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Default
        {
            get;
            set;
        }

        private object? _statusCodeTtl;

        /// <summary>A list of TTLs to apply to specific status codes or status code ranges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#status_code_ttl Ruleset#status_code_ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCodeTtl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StatusCodeTtl
        {
            get => _statusCodeTtl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _statusCodeTtl = value;
            }
        }
    }
}
