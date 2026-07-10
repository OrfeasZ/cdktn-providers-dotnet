using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersVaryDefault), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersVaryDefault")]
    public interface IRulesetRulesActionParametersVaryDefault
    {
        /// <summary>How the header value is treated when building the cache key. Available values: "bypass", "passthrough", "normalize".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ruleset#action Ruleset#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersVaryDefault), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersVaryDefault")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>How the header value is treated when building the cache key. Available values: "bypass", "passthrough", "normalize".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ruleset#action Ruleset#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
