using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpDataClass
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDlpDataClassSensitivityLevels), fullyQualifiedName: "cloudflare.zeroTrustDlpDataClass.ZeroTrustDlpDataClassSensitivityLevels")]
    public interface IZeroTrustDlpDataClassSensitivityLevels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_dlp_data_class#group_id ZeroTrustDlpDataClass#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        string GroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_dlp_data_class#level_id ZeroTrustDlpDataClass#level_id}.</summary>
        [JsiiProperty(name: "levelId", typeJson: "{\"primitive\":\"string\"}")]
        string LevelId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDlpDataClassSensitivityLevels), fullyQualifiedName: "cloudflare.zeroTrustDlpDataClass.ZeroTrustDlpDataClassSensitivityLevels")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDlpDataClass.IZeroTrustDlpDataClassSensitivityLevels
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_dlp_data_class#group_id ZeroTrustDlpDataClass#group_id}.</summary>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/zero_trust_dlp_data_class#level_id ZeroTrustDlpDataClass#level_id}.</summary>
            [JsiiProperty(name: "levelId", typeJson: "{\"primitive\":\"string\"}")]
            public string LevelId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
