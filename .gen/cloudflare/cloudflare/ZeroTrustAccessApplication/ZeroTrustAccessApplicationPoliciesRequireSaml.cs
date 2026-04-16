using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesRequireSaml")]
    public class ZeroTrustAccessApplicationPoliciesRequireSaml : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesRequireSaml
    {
        /// <summary>The name of the SAML attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#attribute_name ZeroTrustAccessApplication#attribute_name}
        /// </remarks>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeName
        {
            get;
            set;
        }

        /// <summary>The SAML attribute value to look for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#attribute_value ZeroTrustAccessApplication#attribute_value}
        /// </remarks>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeValue
        {
            get;
            set;
        }

        /// <summary>The ID of your SAML identity provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#identity_provider_id ZeroTrustAccessApplication#identity_provider_id}
        /// </remarks>
        [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityProviderId
        {
            get;
            set;
        }
    }
}
