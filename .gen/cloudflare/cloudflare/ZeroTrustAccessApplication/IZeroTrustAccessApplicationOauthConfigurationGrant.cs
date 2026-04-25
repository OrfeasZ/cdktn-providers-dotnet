using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationOauthConfigurationGrant), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationOauthConfigurationGrant")]
    public interface IZeroTrustAccessApplicationOauthConfigurationGrant
    {
        /// <summary>The lifetime of the access token.</summary>
        /// <remarks>
        /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are ns, us (or µs), ms, s, m, h.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#access_token_lifetime ZeroTrustAccessApplication#access_token_lifetime}
        /// </remarks>
        [JsiiProperty(name: "accessTokenLifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessTokenLifetime
        {
            get
            {
                return null;
            }
        }

        /// <summary>The duration of the OAuth session.</summary>
        /// <remarks>
        /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are ns, us (or µs), ms, s, m, h.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#session_duration ZeroTrustAccessApplication#session_duration}
        /// </remarks>
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationOauthConfigurationGrant), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationOauthConfigurationGrant")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationOauthConfigurationGrant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The lifetime of the access token.</summary>
            /// <remarks>
            /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are ns, us (or µs), ms, s, m, h.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#access_token_lifetime ZeroTrustAccessApplication#access_token_lifetime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessTokenLifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessTokenLifetime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The duration of the OAuth session.</summary>
            /// <remarks>
            /// Must be in the format <c>300ms</c> or <c>2h45m</c>. Valid time units are ns, us (or µs), ms, s, m, h.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#session_duration ZeroTrustAccessApplication#session_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionDuration
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
