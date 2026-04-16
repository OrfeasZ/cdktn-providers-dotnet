using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesExcludeSaml), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeSaml")]
    public interface IZeroTrustAccessApplicationPoliciesExcludeSaml
    {
        /// <summary>The name of the SAML attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#attribute_name ZeroTrustAccessApplication#attribute_name}
        /// </remarks>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeName
        {
            get;
        }

        /// <summary>The SAML attribute value to look for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#attribute_value ZeroTrustAccessApplication#attribute_value}
        /// </remarks>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeValue
        {
            get;
        }

        /// <summary>The ID of your SAML identity provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#identity_provider_id ZeroTrustAccessApplication#identity_provider_id}
        /// </remarks>
        [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProviderId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesExcludeSaml), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeSaml")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeSaml
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the SAML attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#attribute_name ZeroTrustAccessApplication#attribute_name}
            /// </remarks>
            [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The SAML attribute value to look for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#attribute_value ZeroTrustAccessApplication#attribute_value}
            /// </remarks>
            [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of your SAML identity provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#identity_provider_id ZeroTrustAccessApplication#identity_provider_id}
            /// </remarks>
            [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProviderId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
