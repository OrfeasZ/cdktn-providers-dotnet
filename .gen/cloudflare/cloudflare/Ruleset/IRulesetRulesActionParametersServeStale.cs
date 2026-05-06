using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersServeStale), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersServeStale")]
    public interface IRulesetRulesActionParametersServeStale
    {
        /// <summary>Defines whether Cloudflare should serve stale content while updating.</summary>
        /// <remarks>
        /// If true, Cloudflare will not serve stale content while getting the latest content from the origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_stale_while_updating Ruleset#disable_stale_while_updating}
        /// </remarks>
        [JsiiProperty(name: "disableStaleWhileUpdating", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object DisableStaleWhileUpdating
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersServeStale), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersServeStale")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersServeStale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines whether Cloudflare should serve stale content while updating.</summary>
            /// <remarks>
            /// If true, Cloudflare will not serve stale content while getting the latest content from the origin.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_stale_while_updating Ruleset#disable_stale_while_updating}
            /// </remarks>
            [JsiiProperty(name: "disableStaleWhileUpdating", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object DisableStaleWhileUpdating
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
