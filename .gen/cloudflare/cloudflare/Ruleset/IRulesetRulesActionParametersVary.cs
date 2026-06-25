using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersVary), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersVary")]
    public interface IRulesetRulesActionParametersVary
    {
        /// <summary>Controls how response Vary headers without a per-header override contribute to the cache key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#default Ruleset#default}
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryDefault\"}")]
        cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault Default
        {
            get;
        }

        /// <summary>A mapping of lowercase request header names to their vary configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#headers Ruleset#headers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryHeaders\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Headers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersVary), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersVary")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersVary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls how response Vary headers without a per-header override contribute to the cache key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#default Ruleset#default}
            /// </remarks>
            [JsiiProperty(name: "default", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryDefault\"}")]
            public cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault Default
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersVaryDefault>()!;
            }

            /// <summary>A mapping of lowercase request header names to their vary configuration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/ruleset#headers Ruleset#headers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Ruleset.IRulesetRulesActionParametersVaryHeaders" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersVaryHeaders\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
