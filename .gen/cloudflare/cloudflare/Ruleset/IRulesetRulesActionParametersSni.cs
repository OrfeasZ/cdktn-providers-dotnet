using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersSni), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersSni")]
    public interface IRulesetRulesActionParametersSni
    {
        /// <summary>A value to override the SNI to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#value Ruleset#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersSni), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersSni")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersSni
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A value to override the SNI to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#value Ruleset#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
