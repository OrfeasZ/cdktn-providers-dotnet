using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpCustomEntry
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDlpCustomEntry.ZeroTrustDlpCustomEntryPattern")]
    public class ZeroTrustDlpCustomEntryPattern : cloudflare.ZeroTrustDlpCustomEntry.IZeroTrustDlpCustomEntryPattern
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_entry#regex ZeroTrustDlpCustomEntry#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        public string Regex
        {
            get;
            set;
        }

        /// <summary>Available values: "luhn".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_entry#validation ZeroTrustDlpCustomEntry#validation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Validation
        {
            get;
            set;
        }
    }
}
