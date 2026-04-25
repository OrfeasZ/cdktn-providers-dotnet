using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpCustomProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDlpCustomProfileSensitivityLevels), fullyQualifiedName: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileSensitivityLevels")]
    public interface IZeroTrustDlpCustomProfileSensitivityLevels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_custom_profile#group_id ZeroTrustDlpCustomProfile#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        string GroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_custom_profile#level_id ZeroTrustDlpCustomProfile#level_id}.</summary>
        [JsiiProperty(name: "levelId", typeJson: "{\"primitive\":\"string\"}")]
        string LevelId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDlpCustomProfileSensitivityLevels), fullyQualifiedName: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileSensitivityLevels")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileSensitivityLevels
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_custom_profile#group_id ZeroTrustDlpCustomProfile#group_id}.</summary>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_custom_profile#level_id ZeroTrustDlpCustomProfile#level_id}.</summary>
            [JsiiProperty(name: "levelId", typeJson: "{\"primitive\":\"string\"}")]
            public string LevelId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
