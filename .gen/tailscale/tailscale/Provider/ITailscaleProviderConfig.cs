using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.Provider
{
    [JsiiInterface(nativeType: typeof(ITailscaleProviderConfig), fullyQualifiedName: "tailscale.provider.TailscaleProviderConfig")]
    public interface ITailscaleProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#alias TailscaleProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>The API key to use for authenticating requests to the API.</summary>
        /// <remarks>
        /// Can be set via the TAILSCALE_API_KEY environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the API key. Conflicts with 'oauth_client_id' and 'oauth_client_secret'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#api_key TailscaleProvider#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OIDC audience to request when discovering an identity token from the runtime (GitHub Actions, AWS, or GCP) for workload identity federation.</summary>
        /// <remarks>
        /// Can be set via the TAILSCALE_AUDIENCE environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the audience. Requires 'oauth_client_id'. Conflicts with 'api_key', 'oauth_client_secret', 'identity_token', and 'identity_token_environment_variable_name'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#audience TailscaleProvider#audience}
        /// </remarks>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Audience
        {
            get
            {
                return null;
            }
        }

        /// <summary>The base URL of the Tailscale API. Defaults to https://api.tailscale.com. Can be set via the TAILSCALE_BASE_URL environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#base_url TailscaleProvider#base_url}
        /// </remarks>
        [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The jwt identity token to exchange for a Tailscale API token when using a federated identity.</summary>
        /// <remarks>
        /// Can be set via the TAILSCALE_IDENTITY_TOKEN environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the identity token. Conflicts with 'api_key', 'oauth_client_secret', and 'identity_token_environment_variable_name'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#identity_token TailscaleProvider#identity_token}
        /// </remarks>
        [JsiiProperty(name: "identityToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of an environment variable to read the identity token from.</summary>
        /// <remarks>
        /// This is useful when the identity token is provided by an external system (such as Terraform Cloud workload identity) in an environment variable you do not control. If the resolved value of the environment variable starts with 'file:' then it is treated as a path to a file on disk that contains identity token. Conflicts with 'identity_token'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#identity_token_environment_variable_name TailscaleProvider#identity_token_environment_variable_name}
        /// </remarks>
        [JsiiProperty(name: "identityTokenEnvironmentVariableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityTokenEnvironmentVariableName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OAuth application or federated identity's ID when using OAuth client credentials or workload identity federation.</summary>
        /// <remarks>
        /// Can be set via the TAILSCALE_OAUTH_CLIENT_ID environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the client ID. Either 'oauth_client_secret' or 'identity_token' must be set alongside 'oauth_client_id'. Conflicts with 'api_key'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#oauth_client_id TailscaleProvider#oauth_client_id}
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

        /// <summary>The OAuth application's secret when using OAuth client credentials.</summary>
        /// <remarks>
        /// Can be set via the TAILSCALE_OAUTH_CLIENT_SECRET environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the client secret. Conflicts with 'api_key' and 'identity_token'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#oauth_client_secret TailscaleProvider#oauth_client_secret}
        /// </remarks>
        [JsiiProperty(name: "oauthClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OauthClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OAuth 2.0 scopes to request when generating the access token using the supplied OAuth client credentials. See https://tailscale.com/kb/1623/trust-credentials#scopes for available scopes. Only valid when both 'oauth_client_id' and 'oauth_client_secret', or both are set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#scopes TailscaleProvider#scopes}
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

        /// <summary>The tailnet ID.</summary>
        /// <remarks>
        /// Tailnets created before Oct 2025 can still use the legacy ID, but the Tailnet ID is the preferred identifier. Can be set via the TAILSCALE_TAILNET environment variable. Default is the tailnet that owns API credentials passed to the provider.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#tailnet TailscaleProvider#tailnet}
        /// </remarks>
        [JsiiProperty(name: "tailnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tailnet
        {
            get
            {
                return null;
            }
        }

        /// <summary>User-Agent header for API requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#user_agent TailscaleProvider#user_agent}
        /// </remarks>
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAgent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITailscaleProviderConfig), fullyQualifiedName: "tailscale.provider.TailscaleProviderConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.Provider.ITailscaleProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#alias TailscaleProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The API key to use for authenticating requests to the API.</summary>
            /// <remarks>
            /// Can be set via the TAILSCALE_API_KEY environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the API key. Conflicts with 'oauth_client_id' and 'oauth_client_secret'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#api_key TailscaleProvider#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The OIDC audience to request when discovering an identity token from the runtime (GitHub Actions, AWS, or GCP) for workload identity federation.</summary>
            /// <remarks>
            /// Can be set via the TAILSCALE_AUDIENCE environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the audience. Requires 'oauth_client_id'. Conflicts with 'api_key', 'oauth_client_secret', 'identity_token', and 'identity_token_environment_variable_name'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#audience TailscaleProvider#audience}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Audience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The base URL of the Tailscale API. Defaults to https://api.tailscale.com. Can be set via the TAILSCALE_BASE_URL environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#base_url TailscaleProvider#base_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The jwt identity token to exchange for a Tailscale API token when using a federated identity.</summary>
            /// <remarks>
            /// Can be set via the TAILSCALE_IDENTITY_TOKEN environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the identity token. Conflicts with 'api_key', 'oauth_client_secret', and 'identity_token_environment_variable_name'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#identity_token TailscaleProvider#identity_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of an environment variable to read the identity token from.</summary>
            /// <remarks>
            /// This is useful when the identity token is provided by an external system (such as Terraform Cloud workload identity) in an environment variable you do not control. If the resolved value of the environment variable starts with 'file:' then it is treated as a path to a file on disk that contains identity token. Conflicts with 'identity_token'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#identity_token_environment_variable_name TailscaleProvider#identity_token_environment_variable_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityTokenEnvironmentVariableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityTokenEnvironmentVariableName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The OAuth application or federated identity's ID when using OAuth client credentials or workload identity federation.</summary>
            /// <remarks>
            /// Can be set via the TAILSCALE_OAUTH_CLIENT_ID environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the client ID. Either 'oauth_client_secret' or 'identity_token' must be set alongside 'oauth_client_id'. Conflicts with 'api_key'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#oauth_client_id TailscaleProvider#oauth_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OauthClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The OAuth application's secret when using OAuth client credentials.</summary>
            /// <remarks>
            /// Can be set via the TAILSCALE_OAUTH_CLIENT_SECRET environment variable. If the value starts with 'file:' then it is treated as a path to a file on disk that contains the client secret. Conflicts with 'api_key' and 'identity_token'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#oauth_client_secret TailscaleProvider#oauth_client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OauthClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The OAuth 2.0 scopes to request when generating the access token using the supplied OAuth client credentials. See https://tailscale.com/kb/1623/trust-credentials#scopes for available scopes. Only valid when both 'oauth_client_id' and 'oauth_client_secret', or both are set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#scopes TailscaleProvider#scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Scopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The tailnet ID.</summary>
            /// <remarks>
            /// Tailnets created before Oct 2025 can still use the legacy ID, but the Tailnet ID is the preferred identifier. Can be set via the TAILSCALE_TAILNET environment variable. Default is the tailnet that owns API credentials passed to the provider.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#tailnet TailscaleProvider#tailnet}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tailnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tailnet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-Agent header for API requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#user_agent TailscaleProvider#user_agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAgent
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
