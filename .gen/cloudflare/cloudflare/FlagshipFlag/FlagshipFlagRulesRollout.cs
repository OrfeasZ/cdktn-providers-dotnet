using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.flagshipFlag.FlagshipFlagRulesRollout")]
    public class FlagshipFlagRulesRollout : cloudflare.FlagshipFlag.IFlagshipFlagRulesRollout
    {
        /// <summary>Percentage of matching traffic (0–100) served this variation.</summary>
        /// <remarks>
        /// For multi-way splits, use cumulative upper bounds across rules (e.g. 30, 70, 100).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/flagship_flag#percentage FlagshipFlag#percentage}
        /// </remarks>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        public double Percentage
        {
            get;
            set;
        }

        /// <summary>Context attribute used for sticky bucketing. Defaults to `targetingKey`. If absent at evaluation time, bucketing is random per request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/flagship_flag#attribute FlagshipFlag#attribute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Attribute
        {
            get;
            set;
        }
    }
}
