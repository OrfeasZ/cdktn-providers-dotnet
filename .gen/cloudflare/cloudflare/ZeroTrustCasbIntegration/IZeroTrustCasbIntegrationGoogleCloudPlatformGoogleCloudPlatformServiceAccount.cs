using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount")]
    public interface IZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount
    {
        /// <summary>Contents of a Google service account JSON key file.</summary>
        /// <remarks>
        /// This value is write-only and is never persisted to Terraform state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#service_account_key_json ZeroTrustCasbIntegration#service_account_key_json}
        /// </remarks>
        [JsiiProperty(name: "serviceAccountKeyJson", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceAccountKeyJson
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Contents of a Google service account JSON key file.</summary>
            /// <remarks>
            /// This value is write-only and is never persisted to Terraform state.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#service_account_key_json ZeroTrustCasbIntegration#service_account_key_json}
            /// </remarks>
            [JsiiProperty(name: "serviceAccountKeyJson", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceAccountKeyJson
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
