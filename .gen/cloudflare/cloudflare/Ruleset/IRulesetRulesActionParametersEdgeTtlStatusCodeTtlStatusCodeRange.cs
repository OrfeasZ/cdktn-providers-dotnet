using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange")]
    public interface IRulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange
    {
        /// <summary>The lower bound of the range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#from Ruleset#from}
        /// </remarks>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? From
        {
            get
            {
                return null;
            }
        }

        /// <summary>The upper bound of the range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#to Ruleset#to}
        /// </remarks>
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? To
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersEdgeTtlStatusCodeTtlStatusCodeRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The lower bound of the range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#from Ruleset#from}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? From
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The upper bound of the range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ruleset#to Ruleset#to}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? To
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
