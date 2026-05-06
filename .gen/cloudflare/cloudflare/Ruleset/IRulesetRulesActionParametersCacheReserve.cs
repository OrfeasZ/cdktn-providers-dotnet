using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheReserve), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheReserve")]
    public interface IRulesetRulesActionParametersCacheReserve
    {
        /// <summary>Determines whether cache reserve is enabled.</summary>
        /// <remarks>
        /// If this is true and a request meets eligibility criteria, Cloudflare will write the resource to cache reserve.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#eligible Ruleset#eligible}
        /// </remarks>
        [JsiiProperty(name: "eligible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Eligible
        {
            get;
        }

        /// <summary>The minimum file size eligible for store in cache reserve.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#minimum_file_size Ruleset#minimum_file_size}
        /// </remarks>
        [JsiiProperty(name: "minimumFileSize", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumFileSize
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersCacheReserve), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheReserve")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersCacheReserve
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Determines whether cache reserve is enabled.</summary>
            /// <remarks>
            /// If this is true and a request meets eligibility criteria, Cloudflare will write the resource to cache reserve.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#eligible Ruleset#eligible}
            /// </remarks>
            [JsiiProperty(name: "eligible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Eligible
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The minimum file size eligible for store in cache reserve.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#minimum_file_size Ruleset#minimum_file_size}
            /// </remarks>
            [JsiiProperty(name: "minimumFileSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumFileSize
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
