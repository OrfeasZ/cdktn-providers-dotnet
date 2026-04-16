using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessIdentityProviderConfigHeaderAttributes), fullyQualifiedName: "cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigHeaderAttributes")]
    public interface IZeroTrustAccessIdentityProviderConfigHeaderAttributes
    {
        /// <summary>attribute name from the IDP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_identity_provider#attribute_name ZeroTrustAccessIdentityProvider#attribute_name}
        /// </remarks>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AttributeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>header that will be added on the request to the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_identity_provider#header_name ZeroTrustAccessIdentityProvider#header_name}
        /// </remarks>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeaderName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessIdentityProviderConfigHeaderAttributes), fullyQualifiedName: "cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigHeaderAttributes")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessIdentityProvider.IZeroTrustAccessIdentityProviderConfigHeaderAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>attribute name from the IDP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_identity_provider#attribute_name ZeroTrustAccessIdentityProvider#attribute_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AttributeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>header that will be added on the request to the origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_identity_provider#header_name ZeroTrustAccessIdentityProvider#header_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
