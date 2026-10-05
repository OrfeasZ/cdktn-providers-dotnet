using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationGoogleCloudPlatform), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatform")]
    public interface IZeroTrustCasbIntegrationGoogleCloudPlatform
    {
        /// <summary>Authenticate with a service account key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#google_cloud_platform_service_account ZeroTrustCasbIntegration#google_cloud_platform_service_account}
        /// </remarks>
        [JsiiProperty(name: "googleCloudPlatformServiceAccount", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount? GoogleCloudPlatformServiceAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationGoogleCloudPlatform), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatform")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleCloudPlatform
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Authenticate with a service account key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#google_cloud_platform_service_account ZeroTrustCasbIntegration#google_cloud_platform_service_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "googleCloudPlatformServiceAccount", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount\"}", isOptional: true)]
            public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount? GoogleCloudPlatformServiceAccount
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleCloudPlatformGoogleCloudPlatformServiceAccount?>();
            }
        }
    }
}
