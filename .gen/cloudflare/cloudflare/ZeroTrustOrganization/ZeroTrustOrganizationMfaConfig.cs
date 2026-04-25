using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustOrganization
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationMfaConfig")]
    public class ZeroTrustOrganizationMfaConfig : cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationMfaConfig
    {
        /// <summary>Lists the MFA methods that users can authenticate with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#allowed_authenticators ZeroTrustOrganization#allowed_authenticators}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedAuthenticators", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedAuthenticators
        {
            get;
            set;
        }

        /// <summary>Allows a user to skip MFA via Authentication Method Reference (AMR) matching when the AMR claim provided by the IdP the user used to authenticate contains "mfa".</summary>
        /// <remarks>
        /// Must be in minutes (m) or hours (h). Minimum: 0m. Maximum: 720h (30 days).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#amr_matching_session_duration ZeroTrustOrganization#amr_matching_session_duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amrMatchingSessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmrMatchingSessionDuration
        {
            get;
            set;
        }

        /// <summary>Specifies a Cloudflare List of required FIDO2 authenticator device AAGUIDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#required_aaguids ZeroTrustOrganization#required_aaguids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requiredAaguids", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequiredAaguids
        {
            get;
            set;
        }

        /// <summary>Defines the duration of an MFA session.</summary>
        /// <remarks>
        /// Must be in minutes (m) or hours (h). Minimum: 0m. Maximum: 720h (30 days). Examples:<c>5m</c> or <c>24h</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#session_duration ZeroTrustOrganization#session_duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionDuration
        {
            get;
            set;
        }
    }
}
