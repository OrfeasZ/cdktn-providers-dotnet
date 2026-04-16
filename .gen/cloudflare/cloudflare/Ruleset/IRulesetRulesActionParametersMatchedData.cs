using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersMatchedData), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersMatchedData")]
    public interface IRulesetRulesActionParametersMatchedData
    {
        /// <summary>The public key to encrypt matched data logs with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#public_key Ruleset#public_key}
        /// </remarks>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        string PublicKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersMatchedData), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersMatchedData")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersMatchedData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The public key to encrypt matched data logs with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#public_key Ruleset#public_key}
            /// </remarks>
            [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
