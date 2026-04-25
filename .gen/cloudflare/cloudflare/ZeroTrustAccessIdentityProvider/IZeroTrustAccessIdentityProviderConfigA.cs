using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessIdentityProvider
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessIdentityProviderConfigA), fullyQualifiedName: "cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigA")]
    public interface IZeroTrustAccessIdentityProviderConfigA
    {
        /// <summary>Your companies TLD.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#apps_domain ZeroTrustAccessIdentityProvider#apps_domain}
        /// </remarks>
        [JsiiProperty(name: "appsDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppsDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of SAML attribute names that will be added to your signed JWT token and can be used in SAML policy rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#attributes ZeroTrustAccessIdentityProvider#attributes}
        /// </remarks>
        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your okta authorization server id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#authorization_server_id ZeroTrustAccessIdentityProvider#authorization_server_id}
        /// </remarks>
        [JsiiProperty(name: "authorizationServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizationServerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The authorization_endpoint URL of your IdP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#auth_url ZeroTrustAccessIdentityProvider#auth_url}
        /// </remarks>
        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your centrify account url.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#centrify_account ZeroTrustAccessIdentityProvider#centrify_account}
        /// </remarks>
        [JsiiProperty(name: "centrifyAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CentrifyAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your centrify app id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#centrify_app_id ZeroTrustAccessIdentityProvider#centrify_app_id}
        /// </remarks>
        [JsiiProperty(name: "centrifyAppId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CentrifyAppId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The jwks_uri endpoint of your IdP to allow the IdP keys to sign the tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#certs_url ZeroTrustAccessIdentityProvider#certs_url}
        /// </remarks>
        [JsiiProperty(name: "certsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertsUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Custom claims.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#claims ZeroTrustAccessIdentityProvider#claims}
        /// </remarks>
        [JsiiProperty(name: "claims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Claims
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your OAuth Client ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#client_id ZeroTrustAccessIdentityProvider#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your OAuth Client Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#client_secret ZeroTrustAccessIdentityProvider#client_secret}
        /// </remarks>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should Cloudflare try to load authentication contexts from your account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#conditional_access_enabled ZeroTrustAccessIdentityProvider#conditional_access_enabled}
        /// </remarks>
        [JsiiProperty(name: "conditionalAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConditionalAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your Azure directory uuid.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#directory_id ZeroTrustAccessIdentityProvider#directory_id}
        /// </remarks>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The attribute name for email in the SAML response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#email_attribute_name ZeroTrustAccessIdentityProvider#email_attribute_name}
        /// </remarks>
        [JsiiProperty(name: "emailAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailAttributeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The claim name for email in the id_token response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#email_claim_name ZeroTrustAccessIdentityProvider#email_claim_name}
        /// </remarks>
        [JsiiProperty(name: "emailClaimName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailClaimName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Add a list of attribute names that will be returned in the response header from the Access callback.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#header_attributes ZeroTrustAccessIdentityProvider#header_attributes}
        /// </remarks>
        [JsiiProperty(name: "headerAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigHeaderAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HeaderAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>X509 certificate to verify the signature in the SAML authentication response.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#idp_public_certs ZeroTrustAccessIdentityProvider#idp_public_certs}
        /// </remarks>
        [JsiiProperty(name: "idpPublicCerts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdpPublicCerts
        {
            get
            {
                return null;
            }
        }

        /// <summary>IdP Entity ID or Issuer URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#issuer_url ZeroTrustAccessIdentityProvider#issuer_url}
        /// </remarks>
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IssuerUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your okta account url.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#okta_account ZeroTrustAccessIdentityProvider#okta_account}
        /// </remarks>
        [JsiiProperty(name: "oktaAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OktaAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your OneLogin account url.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#onelogin_account ZeroTrustAccessIdentityProvider#onelogin_account}
        /// </remarks>
        [JsiiProperty(name: "oneloginAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OneloginAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Your PingOne environment identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#ping_env_id ZeroTrustAccessIdentityProvider#ping_env_id}
        /// </remarks>
        [JsiiProperty(name: "pingEnvId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PingEnvId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable Proof Key for Code Exchange (PKCE).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#pkce_enabled ZeroTrustAccessIdentityProvider#pkce_enabled}
        /// </remarks>
        [JsiiProperty(name: "pkceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PkceEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates the type of user interaction that is required.</summary>
        /// <remarks>
        /// prompt=login forces the user to enter their credentials on that request, negating single-sign on. prompt=none is the opposite. It ensures that the user isn't presented with any interactive prompt. If the request can't be completed silently by using single-sign on, the Microsoft identity platform returns an interaction_required error. prompt=select_account interrupts single sign-on providing account selection experience listing all the accounts either in session or any remembered account or an option to choose to use a different account altogether.
        /// Available values: "login", "select_account", "none".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#prompt ZeroTrustAccessIdentityProvider#prompt}
        /// </remarks>
        [JsiiProperty(name: "prompt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>OAuth scopes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#scopes ZeroTrustAccessIdentityProvider#scopes}
        /// </remarks>
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Scopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sign the SAML authentication request with Access credentials.</summary>
        /// <remarks>
        /// To verify the signature, use the public key from the Access certs endpoints.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#sign_request ZeroTrustAccessIdentityProvider#sign_request}
        /// </remarks>
        [JsiiProperty(name: "signRequest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SignRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL to send the SAML authentication requests to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#sso_target_url ZeroTrustAccessIdentityProvider#sso_target_url}
        /// </remarks>
        [JsiiProperty(name: "ssoTargetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SsoTargetUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should Cloudflare try to load groups from your account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#support_groups ZeroTrustAccessIdentityProvider#support_groups}
        /// </remarks>
        [JsiiProperty(name: "supportGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SupportGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>The token_endpoint URL of your IdP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#token_url ZeroTrustAccessIdentityProvider#token_url}
        /// </remarks>
        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessIdentityProviderConfigA), fullyQualifiedName: "cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigA")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessIdentityProvider.IZeroTrustAccessIdentityProviderConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Your companies TLD.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#apps_domain ZeroTrustAccessIdentityProvider#apps_domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appsDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppsDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of SAML attribute names that will be added to your signed JWT token and can be used in SAML policy rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#attributes ZeroTrustAccessIdentityProvider#attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Attributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Your okta authorization server id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#authorization_server_id ZeroTrustAccessIdentityProvider#authorization_server_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizationServerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The authorization_endpoint URL of your IdP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#auth_url ZeroTrustAccessIdentityProvider#auth_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Your centrify account url.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#centrify_account ZeroTrustAccessIdentityProvider#centrify_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "centrifyAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CentrifyAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Your centrify app id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#centrify_app_id ZeroTrustAccessIdentityProvider#centrify_app_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "centrifyAppId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CentrifyAppId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The jwks_uri endpoint of your IdP to allow the IdP keys to sign the tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#certs_url ZeroTrustAccessIdentityProvider#certs_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertsUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Custom claims.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#claims ZeroTrustAccessIdentityProvider#claims}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "claims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Claims
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Your OAuth Client ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#client_id ZeroTrustAccessIdentityProvider#client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Your OAuth Client Secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#client_secret ZeroTrustAccessIdentityProvider#client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should Cloudflare try to load authentication contexts from your account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#conditional_access_enabled ZeroTrustAccessIdentityProvider#conditional_access_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conditionalAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ConditionalAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Your Azure directory uuid.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#directory_id ZeroTrustAccessIdentityProvider#directory_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The attribute name for email in the SAML response.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#email_attribute_name ZeroTrustAccessIdentityProvider#email_attribute_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailAttributeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The claim name for email in the id_token response.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#email_claim_name ZeroTrustAccessIdentityProvider#email_claim_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailClaimName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailClaimName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Add a list of attribute names that will be returned in the response header from the Access callback.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#header_attributes ZeroTrustAccessIdentityProvider#header_attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderConfigHeaderAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HeaderAttributes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>X509 certificate to verify the signature in the SAML authentication response.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#idp_public_certs ZeroTrustAccessIdentityProvider#idp_public_certs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idpPublicCerts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdpPublicCerts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>IdP Entity ID or Issuer URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#issuer_url ZeroTrustAccessIdentityProvider#issuer_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IssuerUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Your okta account url.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#okta_account ZeroTrustAccessIdentityProvider#okta_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oktaAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OktaAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Your OneLogin account url.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#onelogin_account ZeroTrustAccessIdentityProvider#onelogin_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oneloginAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OneloginAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Your PingOne environment identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#ping_env_id ZeroTrustAccessIdentityProvider#ping_env_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pingEnvId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PingEnvId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable Proof Key for Code Exchange (PKCE).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#pkce_enabled ZeroTrustAccessIdentityProvider#pkce_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pkceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PkceEnabled
            {
                get => GetInstanceProperty<object?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>OAuth scopes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#scopes ZeroTrustAccessIdentityProvider#scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Scopes
            {
                get => GetInstanceProperty<string[]?>();
            }

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
                get => GetInstanceProperty<object?>();
            }

            /// <summary>URL to send the SAML authentication requests to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#sso_target_url ZeroTrustAccessIdentityProvider#sso_target_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssoTargetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SsoTargetUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should Cloudflare try to load groups from your account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#support_groups ZeroTrustAccessIdentityProvider#support_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supportGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SupportGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The token_endpoint URL of your IdP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_identity_provider#token_url ZeroTrustAccessIdentityProvider#token_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
