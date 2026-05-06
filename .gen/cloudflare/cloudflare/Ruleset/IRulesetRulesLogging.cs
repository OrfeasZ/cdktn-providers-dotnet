using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesLogging), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesLogging")]
    public interface IRulesetRulesLogging
    {
        /// <summary>Whether to generate a log when the rule matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#enabled Ruleset#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesLogging), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesLogging")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to generate a log when the rule matches.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#enabled Ruleset#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
