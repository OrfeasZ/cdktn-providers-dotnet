using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayMcpServer
{
    [JsiiInterface(nativeType: typeof(IActionGatewayMcpServerConfig), fullyQualifiedName: "digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerConfig")]
    public interface IActionGatewayMcpServerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>HTTPS URL of the server's MCP endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#endpoint ActionGatewayMcpServer#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        /// <summary>Identifier for the server, unique within your team. Prefixes the slugs of the server's tools.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#server_ref ActionGatewayMcpServer#server_ref}
        /// </remarks>
        [JsiiProperty(name: "serverRef", typeJson: "{\"primitive\":\"string\"}")]
        string ServerRef
        {
            get;
        }

        /// <summary>For credential_ref_source secret: the key or token sent to the server. It is write-only.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#api_key ActionGatewayMcpServer#api_key}
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

        /// <summary>For credential_ref_source secret: reference to a secret your team stores with DigitalOcean.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#credential_ref ActionGatewayMcpServer#credential_ref}
        /// </remarks>
        [JsiiProperty(name: "credentialRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>How requests to the server authenticate: none (the default), secret, or connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#credential_ref_source ActionGatewayMcpServer#credential_ref_source}
        /// </remarks>
        [JsiiProperty(name: "credentialRefSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialRefSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description shown on the server's catalog card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#description ActionGatewayMcpServer#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Slugs of the discovered tools to enable, such as &lt;server_ref&gt;_&lt;tool&gt;. Every other tool of the server is disabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#enabled_tools ActionGatewayMcpServer#enabled_tools}
        /// </remarks>
        [JsiiProperty(name: "enabledTools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EnabledTools
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#id ActionGatewayMcpServer#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>How long, in seconds, a user's authorization may be reused before they must consent again. 0 means 30 days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_authorization_ttl_seconds ActionGatewayMcpServer#oauth_authorization_ttl_seconds}
        /// </remarks>
        [JsiiProperty(name: "oauthAuthorizationTtlSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OauthAuthorizationTtlSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>For credential_ref_source connection: the OAuth authorization endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_authorize_url ActionGatewayMcpServer#oauth_authorize_url}
        /// </remarks>
        [JsiiProperty(name: "oauthAuthorizeUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OauthAuthorizeUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>For credential_ref_source connection: client ID of your team's OAuth client for the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_client_id ActionGatewayMcpServer#oauth_client_id}
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

        /// <summary>For credential_ref_source connection: client secret of your team's OAuth client. It is write-only.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_client_secret ActionGatewayMcpServer#oauth_client_secret}
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

        /// <summary>For credential_ref_source connection: the scopes to request from each user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_scopes ActionGatewayMcpServer#oauth_scopes}
        /// </remarks>
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OauthScopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>For credential_ref_source connection: the OAuth token endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_token_url ActionGatewayMcpServer#oauth_token_url}
        /// </remarks>
        [JsiiProperty(name: "oauthTokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OauthTokenUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>For credential_ref_source connection: the user whose authorization is used to discover and verify the server's tools.</summary>
        /// <remarks>
        /// Adding or changing it discovers the tools again.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#sync_user_id ActionGatewayMcpServer#sync_user_id}
        /// </remarks>
        [JsiiProperty(name: "syncUserId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SyncUserId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#timeouts ActionGatewayMcpServer#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>MCP transport. Only streamable_http is supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#transport ActionGatewayMcpServer#transport}
        /// </remarks>
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Transport
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayMcpServerConfig), fullyQualifiedName: "digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>HTTPS URL of the server's MCP endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#endpoint ActionGatewayMcpServer#endpoint}
            /// </remarks>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier for the server, unique within your team. Prefixes the slugs of the server's tools.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#server_ref ActionGatewayMcpServer#server_ref}
            /// </remarks>
            [JsiiProperty(name: "serverRef", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerRef
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>For credential_ref_source secret: the key or token sent to the server. It is write-only.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#api_key ActionGatewayMcpServer#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For credential_ref_source secret: reference to a secret your team stores with DigitalOcean.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#credential_ref ActionGatewayMcpServer#credential_ref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentialRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialRef
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>How requests to the server authenticate: none (the default), secret, or connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#credential_ref_source ActionGatewayMcpServer#credential_ref_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentialRefSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialRefSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Description shown on the server's catalog card.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#description ActionGatewayMcpServer#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Slugs of the discovered tools to enable, such as &lt;server_ref&gt;_&lt;tool&gt;. Every other tool of the server is disabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#enabled_tools ActionGatewayMcpServer#enabled_tools}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabledTools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EnabledTools
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#id ActionGatewayMcpServer#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>How long, in seconds, a user's authorization may be reused before they must consent again. 0 means 30 days.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_authorization_ttl_seconds ActionGatewayMcpServer#oauth_authorization_ttl_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthAuthorizationTtlSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OauthAuthorizationTtlSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>For credential_ref_source connection: the OAuth authorization endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_authorize_url ActionGatewayMcpServer#oauth_authorize_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthAuthorizeUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OauthAuthorizeUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For credential_ref_source connection: client ID of your team's OAuth client for the server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_client_id ActionGatewayMcpServer#oauth_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OauthClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For credential_ref_source connection: client secret of your team's OAuth client. It is write-only.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_client_secret ActionGatewayMcpServer#oauth_client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OauthClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For credential_ref_source connection: the scopes to request from each user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_scopes ActionGatewayMcpServer#oauth_scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OauthScopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>For credential_ref_source connection: the OAuth token endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_token_url ActionGatewayMcpServer#oauth_token_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthTokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OauthTokenUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For credential_ref_source connection: the user whose authorization is used to discover and verify the server's tools.</summary>
            /// <remarks>
            /// Adding or changing it discovers the tools again.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#sync_user_id ActionGatewayMcpServer#sync_user_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "syncUserId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SyncUserId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#timeouts ActionGatewayMcpServer#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerTimeouts\"}", isOptional: true)]
            public digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerTimeouts? Timeouts
            {
                get => GetInstanceProperty<digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerTimeouts?>();
            }

            /// <summary>MCP transport. Only streamable_http is supported.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#transport ActionGatewayMcpServer#transport}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Transport
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
