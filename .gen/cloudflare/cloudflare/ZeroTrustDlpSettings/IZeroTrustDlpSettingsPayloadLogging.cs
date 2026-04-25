using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpSettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDlpSettingsPayloadLogging), fullyQualifiedName: "cloudflare.zeroTrustDlpSettings.ZeroTrustDlpSettingsPayloadLogging")]
    public interface IZeroTrustDlpSettingsPayloadLogging
    {
        /// <summary>Masking level for payload logs.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>full</c>: The entire payload is masked.</description>
        /// <description><c>partial</c>: Only partial payload content is masked.</description>
        /// <description><c>clear</c>: No masking is applied to the payload content.</description>
        /// <description><c>default</c>: DLP uses its default masking behavior.
        /// Available values: "full", "partial", "clear", "default".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#masking_level ZeroTrustDlpSettings#masking_level}
        /// </remarks>
        [JsiiProperty(name: "maskingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaskingLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Base64-encoded public key for encrypting payload logs.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>Set to a non-empty base64 string to enable payload logging with the given key.</description>
        /// <description>Set to an empty string to disable payload logging.</description>
        /// <description>Omit or set to null to leave unchanged (PATCH) or reset to disabled (PUT).</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#public_key ZeroTrustDlpSettings#public_key}
        /// </remarks>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDlpSettingsPayloadLogging), fullyQualifiedName: "cloudflare.zeroTrustDlpSettings.ZeroTrustDlpSettingsPayloadLogging")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDlpSettings.IZeroTrustDlpSettingsPayloadLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Masking level for payload logs.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>full</c>: The entire payload is masked.</description>
            /// <description><c>partial</c>: Only partial payload content is masked.</description>
            /// <description><c>clear</c>: No masking is applied to the payload content.</description>
            /// <description><c>default</c>: DLP uses its default masking behavior.
            /// Available values: "full", "partial", "clear", "default".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#masking_level ZeroTrustDlpSettings#masking_level}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maskingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaskingLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Base64-encoded public key for encrypting payload logs.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description>Set to a non-empty base64 string to enable payload logging with the given key.</description>
            /// <description>Set to an empty string to disable payload logging.</description>
            /// <description>Omit or set to null to leave unchanged (PATCH) or reset to disabled (PUT).</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#public_key ZeroTrustDlpSettings#public_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
