using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpCustomProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileSensitivityLevels")]
    public class ZeroTrustDlpCustomProfileSensitivityLevels : cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileSensitivityLevels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_custom_profile#group_id ZeroTrustDlpCustomProfile#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_custom_profile#level_id ZeroTrustDlpCustomProfile#level_id}.</summary>
        [JsiiProperty(name: "levelId", typeJson: "{\"primitive\":\"string\"}")]
        public string LevelId
        {
            get;
            set;
        }
    }
}
