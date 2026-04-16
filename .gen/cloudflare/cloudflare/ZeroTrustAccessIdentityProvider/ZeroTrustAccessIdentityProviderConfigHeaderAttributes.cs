using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessIdentityProvider
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigHeaderAttributes")]
    public class ZeroTrustAccessIdentityProviderConfigHeaderAttributes : cloudflare.ZeroTrustAccessIdentityProvider.IZeroTrustAccessIdentityProviderConfigHeaderAttributes
    {
        /// <summary>attribute name from the IDP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_identity_provider#attribute_name ZeroTrustAccessIdentityProvider#attribute_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AttributeName
        {
            get;
            set;
        }

        /// <summary>header that will be added on the request to the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_identity_provider#header_name ZeroTrustAccessIdentityProvider#header_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderName
        {
            get;
            set;
        }
    }
}
