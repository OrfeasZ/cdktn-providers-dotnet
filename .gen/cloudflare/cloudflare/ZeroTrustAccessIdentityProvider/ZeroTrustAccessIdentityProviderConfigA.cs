using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessIdentityProvider
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigA")]
    public class ZeroTrustAccessIdentityProviderConfigA : cloudflare.ZeroTrustAccessIdentityProvider.IZeroTrustAccessIdentityProviderConfigA
    {
        /// <summary>Your companies TLD.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#apps_domain ZeroTrustAccessIdentityProvider#apps_domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appsDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppsDomain
        {
            get;
            set;
        }

        /// <summary>A list of SAML attribute names that will be added to your signed JWT token and can be used in SAML policy rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#attributes ZeroTrustAccessIdentityProvider#attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Attributes
        {
            get;
            set;
        }

        /// <summary>Your okta authorization server id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#authorization_server_id ZeroTrustAccessIdentityProvider#authorization_server_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorizationServerId
        {
            get;
            set;
        }

        /// <summary>The authorization_endpoint URL of your IdP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#auth_url ZeroTrustAccessIdentityProvider#auth_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthUrl
        {
            get;
            set;
        }

        /// <summary>Your centrify account url.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#centrify_account ZeroTrustAccessIdentityProvider#centrify_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "centrifyAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CentrifyAccount
        {
            get;
            set;
        }

        /// <summary>Your centrify app id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#centrify_app_id ZeroTrustAccessIdentityProvider#centrify_app_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "centrifyAppId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CentrifyAppId
        {
            get;
            set;
        }

        /// <summary>The jwks_uri endpoint of your IdP to allow the IdP keys to sign the tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#certs_url ZeroTrustAccessIdentityProvider#certs_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertsUrl
        {
            get;
            set;
        }

        /// <summary>Custom claims.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#claims ZeroTrustAccessIdentityProvider#claims}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "claims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Claims
        {
            get;
            set;
        }

        /// <summary>Your OAuth Client ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#client_id ZeroTrustAccessIdentityProvider#client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Your OAuth Client Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#client_secret ZeroTrustAccessIdentityProvider#client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        private object? _conditionalAccessEnabled;

        /// <summary>Should Cloudflare try to load authentication contexts from your account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#conditional_access_enabled ZeroTrustAccessIdentityProvider#conditional_access_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditionalAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ConditionalAccessEnabled
        {
            get => _conditionalAccessEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditionalAccessEnabled = value;
            }
        }

        /// <summary>Your Azure directory uuid.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#directory_id ZeroTrustAccessIdentityProvider#directory_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DirectoryId
        {
            get;
            set;
        }

        /// <summary>The attribute name for email in the SAML response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#email_attribute_name ZeroTrustAccessIdentityProvider#email_attribute_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailAttributeName
        {
            get;
            set;
        }

        /// <summary>The claim name for email in the id_token response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#email_claim_name ZeroTrustAccessIdentityProvider#email_claim_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailClaimName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailClaimName
        {
            get;
            set;
        }

        private object? _headerAttributes;

        /// <summary>Add a list of attribute names that will be returned in the response header from the Access callback.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#header_attributes ZeroTrustAccessIdentityProvider#header_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigHeaderAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HeaderAttributes
        {
            get => _headerAttributes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessIdentityProvider.IZeroTrustAccessIdentityProviderConfigHeaderAttributes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessIdentityProvider.IZeroTrustAccessIdentityProviderConfigHeaderAttributes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headerAttributes = value;
            }
        }

        /// <summary>X509 certificate to verify the signature in the SAML authentication response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#idp_public_certs ZeroTrustAccessIdentityProvider#idp_public_certs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idpPublicCerts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdpPublicCerts
        {
            get;
            set;
        }

        /// <summary>IdP Entity ID or Issuer URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#issuer_url ZeroTrustAccessIdentityProvider#issuer_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IssuerUrl
        {
            get;
            set;
        }

        /// <summary>Your okta account url.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#okta_account ZeroTrustAccessIdentityProvider#okta_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oktaAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OktaAccount
        {
            get;
            set;
        }

        /// <summary>Your OneLogin account url.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#onelogin_account ZeroTrustAccessIdentityProvider#onelogin_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oneloginAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OneloginAccount
        {
            get;
            set;
        }

        /// <summary>Your PingOne environment identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#ping_env_id ZeroTrustAccessIdentityProvider#ping_env_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pingEnvId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PingEnvId
        {
            get;
            set;
        }

        private object? _pkceEnabled;

        /// <summary>Enable Proof Key for Code Exchange (PKCE).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#pkce_enabled ZeroTrustAccessIdentityProvider#pkce_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pkceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PkceEnabled
        {
            get => _pkceEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pkceEnabled = value;
            }
        }

        /// <summary>Indicates the type of user interaction that is required.</summary>
        /// <remarks>
        /// prompt=login forces the user to enter their credentials on that request, negating single-sign on. prompt=none is the opposite. It ensures that the user isn't presented with any interactive prompt. If the request can't be completed silently by using single-sign on, the Microsoft identity platform returns an interaction_required error. prompt=select_account interrupts single sign-on providing account selection experience listing all the accounts either in session or any remembered account or an option to choose to use a different account altogether.
        /// Available values: "login", "select_account", "none".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#prompt ZeroTrustAccessIdentityProvider#prompt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prompt
        {
            get;
            set;
        }

        /// <summary>OAuth scopes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#scopes ZeroTrustAccessIdentityProvider#scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Scopes
        {
            get;
            set;
        }

        private object? _signRequest;

        /// <summary>Sign the SAML authentication request with Access credentials.</summary>
        /// <remarks>
        /// To verify the signature, use the public key from the Access certs endpoints.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#sign_request ZeroTrustAccessIdentityProvider#sign_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "signRequest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SignRequest
        {
            get => _signRequest;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _signRequest = value;
            }
        }

        /// <summary>URL to send the SAML authentication requests to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#sso_target_url ZeroTrustAccessIdentityProvider#sso_target_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssoTargetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SsoTargetUrl
        {
            get;
            set;
        }

        private object? _supportGroups;

        /// <summary>Should Cloudflare try to load groups from your account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#support_groups ZeroTrustAccessIdentityProvider#support_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "supportGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SupportGroups
        {
            get => _supportGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _supportGroups = value;
            }
        }

        /// <summary>The token_endpoint URL of your IdP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#token_url ZeroTrustAccessIdentityProvider#token_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenUrl
        {
            get;
            set;
        }
    }
}
