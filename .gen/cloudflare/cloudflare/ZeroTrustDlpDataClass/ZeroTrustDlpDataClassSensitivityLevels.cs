using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpDataClass
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDlpDataClass.ZeroTrustDlpDataClassSensitivityLevels")]
    public class ZeroTrustDlpDataClassSensitivityLevels : cloudflare.ZeroTrustDlpDataClass.IZeroTrustDlpDataClassSensitivityLevels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/zero_trust_dlp_data_class#group_id ZeroTrustDlpDataClass#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/zero_trust_dlp_data_class#level_id ZeroTrustDlpDataClass#level_id}.</summary>
        [JsiiProperty(name: "levelId", typeJson: "{\"primitive\":\"string\"}")]
        public string LevelId
        {
            get;
            set;
        }
    }
}
