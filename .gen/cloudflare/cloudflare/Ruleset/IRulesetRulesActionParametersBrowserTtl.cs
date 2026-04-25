using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersBrowserTtl), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersBrowserTtl")]
    public interface IRulesetRulesActionParametersBrowserTtl
    {
        /// <summary>The browser TTL mode. Available values: "respect_origin", "bypass_by_default", "override_origin", "bypass".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#mode Ruleset#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>The browser TTL (in seconds) if you choose the "override_origin" mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#default Ruleset#default}
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersBrowserTtl), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersBrowserTtl")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersBrowserTtl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The browser TTL mode. Available values: "respect_origin", "bypass_by_default", "override_origin", "bypass".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#mode Ruleset#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The browser TTL (in seconds) if you choose the "override_origin" mode.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#default Ruleset#default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Default
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
