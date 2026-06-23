using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.OauthClient
{
    [JsiiInterface(nativeType: typeof(IOauthClientConfig), fullyQualifiedName: "cloudflare.oauthClient.OauthClientConfig")]
    public interface IOauthClientConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Account identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#account_id OauthClient#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Human-readable name of the OAuth client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#client_name OauthClient#client_name}
        /// </remarks>
        [JsiiProperty(name: "clientName", typeJson: "{\"primitive\":\"string\"}")]
        string ClientName
        {
            get;
        }

        /// <summary>Array of OAuth grant types the client is allowed to use. `authorization_code` is required; `refresh_token` may be included optionally.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#grant_types OauthClient#grant_types}
        /// </remarks>
        [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] GrantTypes
        {
            get;
        }

        /// <summary>Array of allowed redirect URIs for the client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#redirect_uris OauthClient#redirect_uris}
        /// </remarks>
        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RedirectUris
        {
            get;
        }

        /// <summary>Array of OAuth response types the client is allowed to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#response_types OauthClient#response_types}
        /// </remarks>
        [JsiiProperty(name: "responseTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ResponseTypes
        {
            get;
        }

        /// <summary>Array of OAuth scopes the client is allowed to request.</summary>
        /// <remarks>
        /// Colon-delimited scopes are not accepted. Dot-delimited scopes are validated against available OAuth API scopes; simple identity scopes are allowed. Protocol scopes <c>offline_access</c> and <c>openid</c> are added or removed automatically based on <c>grant_types</c> and <c>response_types</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#scopes OauthClient#scopes}
        /// </remarks>
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Scopes
        {
            get;
        }

        /// <summary>The authentication method the client uses at the token endpoint. Available values: "none", "client_secret_basic", "client_secret_post".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#token_endpoint_auth_method OauthClient#token_endpoint_auth_method}
        /// </remarks>
        [JsiiProperty(name: "tokenEndpointAuthMethod", typeJson: "{\"primitive\":\"string\"}")]
        string TokenEndpointAuthMethod
        {
            get;
        }

        /// <summary>Array of allowed CORS origins.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#allowed_cors_origins OauthClient#allowed_cors_origins}
        /// </remarks>
        [JsiiProperty(name: "allowedCorsOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedCorsOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the home page of the client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#client_uri OauthClient#client_uri}
        /// </remarks>
        [JsiiProperty(name: "clientUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the client's logo.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#logo_uri OauthClient#logo_uri}
        /// </remarks>
        [JsiiProperty(name: "logoUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unique identifier for an OAuth client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#oauth_client_id OauthClient#oauth_client_id}
        /// </remarks>
        [JsiiProperty(name: "oauthClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OauthClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL that points to a privacy policy document.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#policy_uri OauthClient#policy_uri}
        /// </remarks>
        [JsiiProperty(name: "policyUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of allowed post-logout redirect URIs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#post_logout_redirect_uris OauthClient#post_logout_redirect_uris}
        /// </remarks>
        [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PostLogoutRedirectUris
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL that points to a terms of service document.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#tos_uri OauthClient#tos_uri}
        /// </remarks>
        [JsiiProperty(name: "tosUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TosUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Promote the OAuth client from private to public visibility.</summary>
        /// <remarks>
        /// Only <c>public</c> is accepted; demotion to <c>private</c> is not supported. Promotion requires a non-empty client name, logo URI, verified client URI host, and at least one non-identity scope.
        /// Available values: "public".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#visibility OauthClient#visibility}
        /// </remarks>
        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Visibility
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOauthClientConfig), fullyQualifiedName: "cloudflare.oauthClient.OauthClientConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.OauthClient.IOauthClientConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Account identifier tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#account_id OauthClient#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Human-readable name of the OAuth client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#client_name OauthClient#client_name}
            /// </remarks>
            [JsiiProperty(name: "clientName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Array of OAuth grant types the client is allowed to use. `authorization_code` is required; `refresh_token` may be included optionally.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#grant_types OauthClient#grant_types}
            /// </remarks>
            [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] GrantTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Array of allowed redirect URIs for the client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#redirect_uris OauthClient#redirect_uris}
            /// </remarks>
            [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RedirectUris
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Array of OAuth response types the client is allowed to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#response_types OauthClient#response_types}
            /// </remarks>
            [JsiiProperty(name: "responseTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ResponseTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Array of OAuth scopes the client is allowed to request.</summary>
            /// <remarks>
            /// Colon-delimited scopes are not accepted. Dot-delimited scopes are validated against available OAuth API scopes; simple identity scopes are allowed. Protocol scopes <c>offline_access</c> and <c>openid</c> are added or removed automatically based on <c>grant_types</c> and <c>response_types</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#scopes OauthClient#scopes}
            /// </remarks>
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Scopes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The authentication method the client uses at the token endpoint. Available values: "none", "client_secret_basic", "client_secret_post".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#token_endpoint_auth_method OauthClient#token_endpoint_auth_method}
            /// </remarks>
            [JsiiProperty(name: "tokenEndpointAuthMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string TokenEndpointAuthMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Array of allowed CORS origins.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#allowed_cors_origins OauthClient#allowed_cors_origins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedCorsOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedCorsOrigins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>URL of the home page of the client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#client_uri OauthClient#client_uri}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL of the client's logo.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#logo_uri OauthClient#logo_uri}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logoUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The unique identifier for an OAuth client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#oauth_client_id OauthClient#oauth_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OauthClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL that points to a privacy policy document.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#policy_uri OauthClient#policy_uri}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policyUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Array of allowed post-logout redirect URIs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#post_logout_redirect_uris OauthClient#post_logout_redirect_uris}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PostLogoutRedirectUris
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>URL that points to a terms of service document.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#tos_uri OauthClient#tos_uri}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tosUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TosUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Promote the OAuth client from private to public visibility.</summary>
            /// <remarks>
            /// Only <c>public</c> is accepted; demotion to <c>private</c> is not supported. Promotion requires a non-empty client name, logo URI, verified client URI host, and at least one non-identity scope.
            /// Available values: "public".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/oauth_client#visibility OauthClient#visibility}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Visibility
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
