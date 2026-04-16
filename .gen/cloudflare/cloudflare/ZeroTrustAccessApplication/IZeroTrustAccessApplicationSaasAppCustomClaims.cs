using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationSaasAppCustomClaims), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaims")]
    public interface IZeroTrustAccessApplicationSaasAppCustomClaims
    {
        /// <summary>The name of the claim.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name ZeroTrustAccessApplication#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>If the claim is required when building an OIDC token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#required ZeroTrustAccessApplication#required}
        /// </remarks>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Required
        {
            get
            {
                return null;
            }
        }

        /// <summary>The scope of the claim. Available values: "groups", "profile", "email", "openid".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#scope ZeroTrustAccessApplication#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#source ZeroTrustAccessApplication#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaimsSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaimsSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationSaasAppCustomClaims), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaims")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaims
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the claim.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name ZeroTrustAccessApplication#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If the claim is required when building an OIDC token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#required ZeroTrustAccessApplication#required}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Required
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The scope of the claim. Available values: "groups", "profile", "email", "openid".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#scope ZeroTrustAccessApplication#scope}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#source ZeroTrustAccessApplication#source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaimsSource\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaimsSource? Source
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaimsSource?>();
            }
        }
    }
}
