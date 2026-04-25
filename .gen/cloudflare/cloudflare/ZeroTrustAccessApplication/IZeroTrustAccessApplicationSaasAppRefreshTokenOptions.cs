using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationSaasAppRefreshTokenOptions), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptions")]
    public interface IZeroTrustAccessApplicationSaasAppRefreshTokenOptions
    {
        /// <summary>How long a refresh token will be valid for after creation.</summary>
        /// <remarks>
        /// Valid units are m,h,d. Must be longer than 1m.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#lifetime ZeroTrustAccessApplication#lifetime}
        /// </remarks>
        [JsiiProperty(name: "lifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lifetime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationSaasAppRefreshTokenOptions), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppRefreshTokenOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>How long a refresh token will be valid for after creation.</summary>
            /// <remarks>
            /// Valid units are m,h,d. Must be longer than 1m.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#lifetime ZeroTrustAccessApplication#lifetime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lifetime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
