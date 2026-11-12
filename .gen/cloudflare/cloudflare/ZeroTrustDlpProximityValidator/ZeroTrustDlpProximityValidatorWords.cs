using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpProximityValidator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDlpProximityValidator.ZeroTrustDlpProximityValidatorWords")]
    public class ZeroTrustDlpProximityValidatorWords : cloudflare.ZeroTrustDlpProximityValidator.IZeroTrustDlpProximityValidatorWords
    {
        /// <summary>How much a word contributes to a match's confidence when it is found nearby.</summary>
        /// <remarks>
        /// Separate from a profile's high/medium/low confidence threshold: this describes how telling the
        /// word is, not how confident the resulting match is.
        /// Available values: "strong", "moderate", "weak".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_dlp_proximity_validator#weight ZeroTrustDlpProximityValidator#weight}
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"string\"}")]
        public string Weight
        {
            get;
            set;
        }

        /// <summary>The word or phrase to look for. Must contain 1–128 characters and is matched case-insensitively.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_dlp_proximity_validator#word ZeroTrustDlpProximityValidator#word}
        /// </remarks>
        [JsiiProperty(name: "word", typeJson: "{\"primitive\":\"string\"}")]
        public string Word
        {
            get;
            set;
        }
    }
}
