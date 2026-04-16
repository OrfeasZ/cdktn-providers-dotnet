using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationSaasApp), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasApp")]
    public interface IZeroTrustAccessApplicationSaasApp
    {
        /// <summary>The lifetime of the OIDC Access Token after creation.</summary>
        /// <remarks>
        /// Valid units are m,h. Must be greater than or equal to 1m and less than or equal to 24h.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#access_token_lifetime ZeroTrustAccessApplication#access_token_lifetime}
        /// </remarks>
        [JsiiProperty(name: "accessTokenLifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessTokenLifetime
        {
            get
            {
                return null;
            }
        }

        /// <summary>If client secret should be required on the token endpoint when authorization_code_with_pkce grant is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_pkce_without_client_secret ZeroTrustAccessApplication#allow_pkce_without_client_secret}
        /// </remarks>
        [JsiiProperty(name: "allowPkceWithoutClientSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowPkceWithoutClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL where this applications tile redirects users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#app_launcher_url ZeroTrustAccessApplication#app_launcher_url}
        /// </remarks>
        [JsiiProperty(name: "appLauncherUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppLauncherUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional identifier indicating the authentication protocol used for the saas app.</summary>
        /// <remarks>
        /// Required for OIDC. Default if unset is "saml"
        /// Available values: "saml", "oidc".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#auth_type ZeroTrustAccessApplication#auth_type}
        /// </remarks>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The service provider's endpoint that is responsible for receiving and parsing a SAML assertion.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#consumer_service_url ZeroTrustAccessApplication#consumer_service_url}
        /// </remarks>
        [JsiiProperty(name: "consumerServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsumerServiceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#custom_attributes ZeroTrustAccessApplication#custom_attributes}.</summary>
        [JsiiProperty(name: "customAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#custom_claims ZeroTrustAccessApplication#custom_claims}.</summary>
        [JsiiProperty(name: "customClaims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaims\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomClaims
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL that the user will be redirected to after a successful login for IDP initiated logins.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#default_relay_state ZeroTrustAccessApplication#default_relay_state}
        /// </remarks>
        [JsiiProperty(name: "defaultRelayState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRelayState
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OIDC flows supported by this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#grant_types ZeroTrustAccessApplication#grant_types}
        /// </remarks>
        [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GrantTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>A regex to filter Cloudflare groups returned in ID token and userinfo endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#group_filter_regex ZeroTrustAccessApplication#group_filter_regex}
        /// </remarks>
        [JsiiProperty(name: "groupFilterRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupFilterRegex
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#hybrid_and_implicit_options ZeroTrustAccessApplication#hybrid_and_implicit_options}.</summary>
        [JsiiProperty(name: "hybridAndImplicitOptions", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions? HybridAndImplicitOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unique identifier for your SaaS application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#idp_entity_id ZeroTrustAccessApplication#idp_entity_id}
        /// </remarks>
        [JsiiProperty(name: "idpEntityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdpEntityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The format of the name identifier sent to the SaaS application. Available values: "id", "email".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name_id_format ZeroTrustAccessApplication#name_id_format}
        /// </remarks>
        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NameIdFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>A [JSONata](https://jsonata.org/) expression that transforms an application's user identities into a NameID value for its SAML assertion. This expression should evaluate to a singular string. The output of this expression can override the `name_id_format` setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name_id_transform_jsonata ZeroTrustAccessApplication#name_id_transform_jsonata}
        /// </remarks>
        [JsiiProperty(name: "nameIdTransformJsonata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NameIdTransformJsonata
        {
            get
            {
                return null;
            }
        }

        /// <summary>The permitted URL's for Cloudflare to return Authorization codes and Access/ID tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#redirect_uris ZeroTrustAccessApplication#redirect_uris}
        /// </remarks>
        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RedirectUris
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#refresh_token_options ZeroTrustAccessApplication#refresh_token_options}.</summary>
        [JsiiProperty(name: "refreshTokenOptions", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppRefreshTokenOptions? RefreshTokenOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>A [JSONata] (https://jsonata.org/) expression that transforms an application's user identities into attribute assertions in the SAML response. The expression can transform id, email, name, and groups values. It can also transform fields listed in the saml_attributes or oidc_fields of the identity provider used to authenticate. The output of this expression must be a JSON object.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#saml_attribute_transform_jsonata ZeroTrustAccessApplication#saml_attribute_transform_jsonata}
        /// </remarks>
        [JsiiProperty(name: "samlAttributeTransformJsonata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SamlAttributeTransformJsonata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Define the user information shared with access, "offline_access" scope will be automatically enabled if refresh tokens are enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#scopes ZeroTrustAccessApplication#scopes}
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

        /// <summary>A globally unique name for an identity or service provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#sp_entity_id ZeroTrustAccessApplication#sp_entity_id}
        /// </remarks>
        [JsiiProperty(name: "spEntityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpEntityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The endpoint where your SaaS application will send login requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#sso_endpoint ZeroTrustAccessApplication#sso_endpoint}
        /// </remarks>
        [JsiiProperty(name: "ssoEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SsoEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationSaasApp), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasApp")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The lifetime of the OIDC Access Token after creation.</summary>
            /// <remarks>
            /// Valid units are m,h. Must be greater than or equal to 1m and less than or equal to 24h.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#access_token_lifetime ZeroTrustAccessApplication#access_token_lifetime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessTokenLifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessTokenLifetime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If client secret should be required on the token endpoint when authorization_code_with_pkce grant is used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#allow_pkce_without_client_secret ZeroTrustAccessApplication#allow_pkce_without_client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowPkceWithoutClientSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowPkceWithoutClientSecret
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The URL where this applications tile redirects users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#app_launcher_url ZeroTrustAccessApplication#app_launcher_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appLauncherUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppLauncherUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Optional identifier indicating the authentication protocol used for the saas app.</summary>
            /// <remarks>
            /// Required for OIDC. Default if unset is "saml"
            /// Available values: "saml", "oidc".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#auth_type ZeroTrustAccessApplication#auth_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The service provider's endpoint that is responsible for receiving and parsing a SAML assertion.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#consumer_service_url ZeroTrustAccessApplication#consumer_service_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consumerServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsumerServiceUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#custom_attributes ZeroTrustAccessApplication#custom_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomAttributes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#custom_claims ZeroTrustAccessApplication#custom_claims}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customClaims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaims\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomClaims
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The URL that the user will be redirected to after a successful login for IDP initiated logins.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#default_relay_state ZeroTrustAccessApplication#default_relay_state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRelayState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRelayState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The OIDC flows supported by this application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#grant_types ZeroTrustAccessApplication#grant_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GrantTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A regex to filter Cloudflare groups returned in ID token and userinfo endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#group_filter_regex ZeroTrustAccessApplication#group_filter_regex}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupFilterRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupFilterRegex
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#hybrid_and_implicit_options ZeroTrustAccessApplication#hybrid_and_implicit_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hybridAndImplicitOptions", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions? HybridAndImplicitOptions
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions?>();
            }

            /// <summary>The unique identifier for your SaaS application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#idp_entity_id ZeroTrustAccessApplication#idp_entity_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idpEntityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdpEntityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The format of the name identifier sent to the SaaS application. Available values: "id", "email".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name_id_format ZeroTrustAccessApplication#name_id_format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NameIdFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A [JSONata](https://jsonata.org/) expression that transforms an application's user identities into a NameID value for its SAML assertion. This expression should evaluate to a singular string. The output of this expression can override the `name_id_format` setting.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#name_id_transform_jsonata ZeroTrustAccessApplication#name_id_transform_jsonata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nameIdTransformJsonata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NameIdTransformJsonata
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The permitted URL's for Cloudflare to return Authorization codes and Access/ID tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#redirect_uris ZeroTrustAccessApplication#redirect_uris}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RedirectUris
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#refresh_token_options ZeroTrustAccessApplication#refresh_token_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshTokenOptions", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptions\"}", isOptional: true)]
            public cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppRefreshTokenOptions? RefreshTokenOptions
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppRefreshTokenOptions?>();
            }

            /// <summary>A [JSONata] (https://jsonata.org/) expression that transforms an application's user identities into attribute assertions in the SAML response. The expression can transform id, email, name, and groups values. It can also transform fields listed in the saml_attributes or oidc_fields of the identity provider used to authenticate. The output of this expression must be a JSON object.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#saml_attribute_transform_jsonata ZeroTrustAccessApplication#saml_attribute_transform_jsonata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "samlAttributeTransformJsonata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SamlAttributeTransformJsonata
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Define the user information shared with access, "offline_access" scope will be automatically enabled if refresh tokens are enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#scopes ZeroTrustAccessApplication#scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Scopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A globally unique name for an identity or service provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#sp_entity_id ZeroTrustAccessApplication#sp_entity_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spEntityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpEntityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The endpoint where your SaaS application will send login requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#sso_endpoint ZeroTrustAccessApplication#sso_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssoEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SsoEndpoint
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
