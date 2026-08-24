using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    [JsiiInterface(nativeType: typeof(IFlagshipFlagRulesRollout), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagRulesRollout")]
    public interface IFlagshipFlagRulesRollout
    {
        /// <summary>Percentage of matching traffic (0–100) served this variation.</summary>
        /// <remarks>
        /// For multi-way splits, use cumulative upper bounds across rules (e.g. 30, 70, 100).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/flagship_flag#percentage FlagshipFlag#percentage}
        /// </remarks>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        double Percentage
        {
            get;
        }

        /// <summary>Context attribute used for sticky bucketing. Defaults to `targetingKey`. If absent at evaluation time, bucketing is random per request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/flagship_flag#attribute FlagshipFlag#attribute}
        /// </remarks>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFlagshipFlagRulesRollout), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagRulesRollout")]
        internal sealed class _Proxy : DeputyBase, cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Percentage of matching traffic (0–100) served this variation.</summary>
            /// <remarks>
            /// For multi-way splits, use cumulative upper bounds across rules (e.g. 30, 70, 100).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/flagship_flag#percentage FlagshipFlag#percentage}
            /// </remarks>
            [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
            public double Percentage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Context attribute used for sticky bucketing. Defaults to `targetingKey`. If absent at evaluation time, bucketing is random per request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/flagship_flag#attribute FlagshipFlag#attribute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attribute
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
