using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.flagshipFlag.FlagshipFlagRules")]
    public class FlagshipFlagRules : cloudflare.FlagshipFlag.IFlagshipFlagRules
    {
        private object _conditions;

        /// <summary>Conditions the context must satisfy for this rule to match. An empty array matches all contexts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#conditions FlagshipFlag#conditions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditions\"},\"kind\":\"array\"}}]}}")]
        public object Conditions
        {
            get => _conditions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditions = value;
            }
        }

        /// <summary>Evaluation order; lower numbers are evaluated first. Must be unique across the flag's rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#priority FlagshipFlag#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Variation served when this rule matches. Must be a key in `variations`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#serve_variation FlagshipFlag#serve_variation}
        /// </remarks>
        [JsiiProperty(name: "serveVariation", typeJson: "{\"primitive\":\"string\"}")]
        public string ServeVariation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/flagship_flag#rollout FlagshipFlag#rollout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rollout", typeJson: "{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesRollout\"}", isOptional: true)]
        public cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout? Rollout
        {
            get;
            set;
        }
    }
}
