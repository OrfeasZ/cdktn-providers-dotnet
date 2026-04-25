using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationScimConfigAuthentication")]
    public class ZeroTrustAccessApplicationScimConfigAuthentication : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationScimConfigAuthentication
    {
        /// <summary>The authentication scheme to use when making SCIM requests to this application. Available values: "httpbasic", "oauthbearertoken", "oauth2", "access_service_token".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#scheme ZeroTrustAccessApplication#scheme}
        /// </remarks>
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
        public string Scheme
        {
            get;
            set;
        }

        /// <summary>URL used to generate the auth code used during token generation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#authorization_url ZeroTrustAccessApplication#authorization_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorizationUrl
        {
            get;
            set;
        }

        /// <summary>Client ID used to authenticate when generating a token for authenticating with the remote SCIM service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#client_id ZeroTrustAccessApplication#client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Secret used to authenticate when generating a token for authenticating with the remove SCIM service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#client_secret ZeroTrustAccessApplication#client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        /// <summary>Password used to authenticate with the remote SCIM service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#password ZeroTrustAccessApplication#password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>The authorization scopes to request when generating the token used to authenticate with the remove SCIM service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#scopes ZeroTrustAccessApplication#scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Scopes
        {
            get;
            set;
        }

        /// <summary>Token used to authenticate with the remote SCIM service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#token ZeroTrustAccessApplication#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }

        /// <summary>URL used to generate the token used to authenticate with the remote SCIM service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#token_url ZeroTrustAccessApplication#token_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenUrl
        {
            get;
            set;
        }

        /// <summary>User name used to authenticate with the remote SCIM service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#user ZeroTrustAccessApplication#user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? User
        {
            get;
            set;
        }
    }
}
