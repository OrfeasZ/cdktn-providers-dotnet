using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    [JsiiInterface(nativeType: typeof(IFlagshipFlagRules), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagRules")]
    public interface IFlagshipFlagRules
    {
        /// <summary>Conditions the context must satisfy for this rule to match. An empty array matches all contexts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/flagship_flag#conditions FlagshipFlag#conditions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditions\"},\"kind\":\"array\"}}]}}")]
        object Conditions
        {
            get;
        }

        /// <summary>Evaluation order; lower numbers are evaluated first. Must be unique across the flag's rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/flagship_flag#priority FlagshipFlag#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Variation served when this rule matches. Must be a key in `variations`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/flagship_flag#serve_variation FlagshipFlag#serve_variation}
        /// </remarks>
        [JsiiProperty(name: "serveVariation", typeJson: "{\"primitive\":\"string\"}")]
        string ServeVariation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/flagship_flag#rollout FlagshipFlag#rollout}.</summary>
        [JsiiProperty(name: "rollout", typeJson: "{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesRollout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout? Rollout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFlagshipFlagRules), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.FlagshipFlag.IFlagshipFlagRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Conditions the context must satisfy for this rule to match. An empty array matches all contexts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/flagship_flag#conditions FlagshipFlag#conditions}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditions\"},\"kind\":\"array\"}}]}}")]
            public object Conditions
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Evaluation order; lower numbers are evaluated first. Must be unique across the flag's rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/flagship_flag#priority FlagshipFlag#priority}
            /// </remarks>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Variation served when this rule matches. Must be a key in `variations`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/flagship_flag#serve_variation FlagshipFlag#serve_variation}
            /// </remarks>
            [JsiiProperty(name: "serveVariation", typeJson: "{\"primitive\":\"string\"}")]
            public string ServeVariation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/flagship_flag#rollout FlagshipFlag#rollout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rollout", typeJson: "{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesRollout\"}", isOptional: true)]
            public cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout? Rollout
            {
                get => GetInstanceProperty<cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout?>();
            }
        }
    }
}
