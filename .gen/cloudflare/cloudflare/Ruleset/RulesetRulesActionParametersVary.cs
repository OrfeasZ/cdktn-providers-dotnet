using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersVary")]
    public class RulesetRulesActionParametersVary : cloudflare.Ruleset.IRulesetRulesActionParametersVary
    {
        /// <summary>Controls how response Vary headers without a per-header override contribute to the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ruleset#default Ruleset#default}
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryDefault\"}")]
        public cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault Default
        {
            get;
            set;
        }

        private object? _headers;

        /// <summary>A mapping of lowercase request header names to their vary configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ruleset#headers Ruleset#headers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders" />&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryHeaders\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Headers
        {
            get => _headers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headers = value;
            }
        }
    }
}
