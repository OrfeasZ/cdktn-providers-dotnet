using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationOauthConfigurationDynamicClientRegistration), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationOauthConfigurationDynamicClientRegistration")]
    public interface IZeroTrustAccessApplicationOauthConfigurationDynamicClientRegistration
    {
        /// <summary>Allows any client with redirect URIs on localhost.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allow_any_on_localhost ZeroTrustAccessApplication#allow_any_on_localhost}
        /// </remarks>
        [JsiiProperty(name: "allowAnyOnLocalhost", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAnyOnLocalhost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows any client with redirect URIs on 127.0.0.1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allow_any_on_loopback ZeroTrustAccessApplication#allow_any_on_loopback}
        /// </remarks>
        [JsiiProperty(name: "allowAnyOnLoopback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAnyOnLoopback
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URIs that are allowed as redirect URIs for dynamically registered clients.</summary>
        /// <remarks>
        /// Must use the <c>https</c> protocol. Paths may end in <c>/*</c> to match all sub-paths.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allowed_uris ZeroTrustAccessApplication#allowed_uris}
        /// </remarks>
        [JsiiProperty(name: "allowedUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedUris
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether dynamic client registration is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#enabled ZeroTrustAccessApplication#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationOauthConfigurationDynamicClientRegistration), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationOauthConfigurationDynamicClientRegistration")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationOauthConfigurationDynamicClientRegistration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allows any client with redirect URIs on localhost.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allow_any_on_localhost ZeroTrustAccessApplication#allow_any_on_localhost}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowAnyOnLocalhost", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAnyOnLocalhost
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allows any client with redirect URIs on 127.0.0.1.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allow_any_on_loopback ZeroTrustAccessApplication#allow_any_on_loopback}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowAnyOnLoopback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAnyOnLoopback
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The URIs that are allowed as redirect URIs for dynamically registered clients.</summary>
            /// <remarks>
            /// Must use the <c>https</c> protocol. Paths may end in <c>/*</c> to match all sub-paths.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allowed_uris ZeroTrustAccessApplication#allowed_uris}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedUris
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether dynamic client registration is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#enabled ZeroTrustAccessApplication#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
