using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersCacheReserve), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheReserve")]
    public interface IRulesetRulesActionParametersCacheReserve
    {
        /// <summary>Whether Cache Reserve is enabled.</summary>
        /// <remarks>
        /// If this is true and a request meets eligibility criteria, Cloudflare will write the resource to Cache Reserve.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#eligible Ruleset#eligible}
        /// </remarks>
        [JsiiProperty(name: "eligible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Eligible
        {
            get;
        }

        /// <summary>The minimum file size eligible for storage in Cache Reserve.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#minimum_file_size Ruleset#minimum_file_size}
        /// </remarks>
        [JsiiProperty(name: "minimumFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumFileSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersCacheReserve), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheReserve")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersCacheReserve
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether Cache Reserve is enabled.</summary>
            /// <remarks>
            /// If this is true and a request meets eligibility criteria, Cloudflare will write the resource to Cache Reserve.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#eligible Ruleset#eligible}
            /// </remarks>
            [JsiiProperty(name: "eligible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Eligible
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The minimum file size eligible for storage in Cache Reserve.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#minimum_file_size Ruleset#minimum_file_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumFileSize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
