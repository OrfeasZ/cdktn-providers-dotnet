using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersOriginRangeRequests), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersOriginRangeRequests")]
    public interface IRulesetRulesActionParametersOriginRangeRequests
    {
        /// <summary>Whether to use range requests. `default` is the behaviour the zone gets without this rule. Available values: "on", "off", "default".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/ruleset#mode Ruleset#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersOriginRangeRequests), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersOriginRangeRequests")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersOriginRangeRequests
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to use range requests. `default` is the behaviour the zone gets without this rule. Available values: "on", "off", "default".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/ruleset#mode Ruleset#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
