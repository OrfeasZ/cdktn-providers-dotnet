using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasApp")]
    public class ZeroTrustAccessApplicationSaasApp : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasApp
    {
        /// <summary>The lifetime of the OIDC Access Token after creation.</summary>
        /// <remarks>
        /// Valid units are m,h. Must be greater than or equal to 1m and less than or equal to 24h.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#access_token_lifetime ZeroTrustAccessApplication#access_token_lifetime}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessTokenLifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessTokenLifetime
        {
            get;
            set;
        }

        private object? _allowPkceWithoutClientSecret;

        /// <summary>If client secret should be required on the token endpoint when authorization_code_with_pkce grant is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allow_pkce_without_client_secret ZeroTrustAccessApplication#allow_pkce_without_client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowPkceWithoutClientSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowPkceWithoutClientSecret
        {
            get => _allowPkceWithoutClientSecret;
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
                _allowPkceWithoutClientSecret = value;
            }
        }

        /// <summary>The URL where this applications tile redirects users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#app_launcher_url ZeroTrustAccessApplication#app_launcher_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appLauncherUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppLauncherUrl
        {
            get;
            set;
        }

        /// <summary>Optional identifier indicating the authentication protocol used for the saas app.</summary>
        /// <remarks>
        /// Required for OIDC. Default if unset is "saml"
        /// Available values: "saml", "oidc".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#auth_type ZeroTrustAccessApplication#auth_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthType
        {
            get;
            set;
        }

        /// <summary>The service provider's endpoint that is responsible for receiving and parsing a SAML assertion.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#consumer_service_url ZeroTrustAccessApplication#consumer_service_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "consumerServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConsumerServiceUrl
        {
            get;
            set;
        }

        private object? _customAttributes;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#custom_attributes ZeroTrustAccessApplication#custom_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomAttributes
        {
            get => _customAttributes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomAttributes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomAttributes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customAttributes = value;
            }
        }

        private object? _customClaims;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#custom_claims ZeroTrustAccessApplication#custom_claims}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customClaims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaims\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomClaims
        {
            get => _customClaims;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaims[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaims).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customClaims = value;
            }
        }

        /// <summary>The URL that the user will be redirected to after a successful login for IDP initiated logins.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#default_relay_state ZeroTrustAccessApplication#default_relay_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRelayState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultRelayState
        {
            get;
            set;
        }

        /// <summary>The OIDC flows supported by this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#grant_types ZeroTrustAccessApplication#grant_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GrantTypes
        {
            get;
            set;
        }

        /// <summary>A regex to filter Cloudflare groups returned in ID token and userinfo endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#group_filter_regex ZeroTrustAccessApplication#group_filter_regex}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupFilterRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupFilterRegex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#hybrid_and_implicit_options ZeroTrustAccessApplication#hybrid_and_implicit_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hybridAndImplicitOptions", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions? HybridAndImplicitOptions
        {
            get;
            set;
        }

        /// <summary>The unique identifier for your SaaS application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#idp_entity_id ZeroTrustAccessApplication#idp_entity_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idpEntityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdpEntityId
        {
            get;
            set;
        }

        /// <summary>The format of the name identifier sent to the SaaS application. Available values: "id", "email".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#name_id_format ZeroTrustAccessApplication#name_id_format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameIdFormat
        {
            get;
            set;
        }

        /// <summary>A [JSONata](https://jsonata.org/) expression that transforms an application's user identities into a NameID value for its SAML assertion. This expression should evaluate to a singular string. The output of this expression can override the `name_id_format` setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#name_id_transform_jsonata ZeroTrustAccessApplication#name_id_transform_jsonata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameIdTransformJsonata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameIdTransformJsonata
        {
            get;
            set;
        }

        /// <summary>The permitted URL's for Cloudflare to return Authorization codes and Access/ID tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#redirect_uris ZeroTrustAccessApplication#redirect_uris}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RedirectUris
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#refresh_token_options ZeroTrustAccessApplication#refresh_token_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refreshTokenOptions", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptions\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppRefreshTokenOptions? RefreshTokenOptions
        {
            get;
            set;
        }

        /// <summary>A [JSONata] (https://jsonata.org/) expression that transforms an application's user identities into attribute assertions in the SAML response. The expression can transform id, email, name, and groups values. It can also transform fields listed in the saml_attributes or oidc_fields of the identity provider used to authenticate. The output of this expression must be a JSON object.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#saml_attribute_transform_jsonata ZeroTrustAccessApplication#saml_attribute_transform_jsonata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "samlAttributeTransformJsonata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SamlAttributeTransformJsonata
        {
            get;
            set;
        }

        /// <summary>Define the user information shared with access, "offline_access" scope will be automatically enabled if refresh tokens are enabled.</summary>
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

        /// <summary>A globally unique name for an identity or service provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#sp_entity_id ZeroTrustAccessApplication#sp_entity_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spEntityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpEntityId
        {
            get;
            set;
        }

        /// <summary>The endpoint where your SaaS application will send login requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#sso_endpoint ZeroTrustAccessApplication#sso_endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssoEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SsoEndpoint
        {
            get;
            set;
        }
    }
}
