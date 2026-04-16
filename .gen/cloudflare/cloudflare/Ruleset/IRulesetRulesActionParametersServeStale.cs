using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersServeStale), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersServeStale")]
    public interface IRulesetRulesActionParametersServeStale
    {
        /// <summary>Whether Cloudflare should disable serving stale content while getting the latest content from the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#disable_stale_while_updating Ruleset#disable_stale_while_updating}
        /// </remarks>
        [JsiiProperty(name: "disableStaleWhileUpdating", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableStaleWhileUpdating
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersServeStale), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersServeStale")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersServeStale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether Cloudflare should disable serving stale content while getting the latest content from the origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#disable_stale_while_updating Ruleset#disable_stale_while_updating}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableStaleWhileUpdating", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableStaleWhileUpdating
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
