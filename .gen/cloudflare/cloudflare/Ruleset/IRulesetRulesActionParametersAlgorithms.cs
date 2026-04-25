using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersAlgorithms), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersAlgorithms")]
    public interface IRulesetRulesActionParametersAlgorithms
    {
        /// <summary>Name of the compression algorithm to enable. Available values: "none", "auto", "default", "gzip", "brotli", "zstd".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#name Ruleset#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersAlgorithms), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersAlgorithms")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersAlgorithms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the compression algorithm to enable. Available values: "none", "auto", "default", "gzip", "brotli", "zstd".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#name Ruleset#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
