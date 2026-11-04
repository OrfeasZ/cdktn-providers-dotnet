using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayMcpServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerConfig")]
    public class ActionGatewayMcpServerConfig : digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerConfig
    {
        /// <summary>HTTPS URL of the server's MCP endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#endpoint ActionGatewayMcpServer#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>Identifier for the server, unique within your team. Prefixes the slugs of the server's tools.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#server_ref ActionGatewayMcpServer#server_ref}
        /// </remarks>
        [JsiiProperty(name: "serverRef", typeJson: "{\"primitive\":\"string\"}")]
        public string ServerRef
        {
            get;
            set;
        }

        /// <summary>For credential_ref_source secret: the key or token sent to the server. It is write-only.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#api_key ActionGatewayMcpServer#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiKey
        {
            get;
            set;
        }

        /// <summary>For credential_ref_source secret: reference to a secret your team stores with DigitalOcean.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#credential_ref ActionGatewayMcpServer#credential_ref}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentialRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialRef
        {
            get;
            set;
        }

        /// <summary>How requests to the server authenticate: none (the default), secret, or connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#credential_ref_source ActionGatewayMcpServer#credential_ref_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentialRefSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CredentialRefSource
        {
            get;
            set;
        }

        /// <summary>Description shown on the server's catalog card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#description ActionGatewayMcpServer#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Slugs of the discovered tools to enable, such as &lt;server_ref&gt;_&lt;tool&gt;. Every other tool of the server is disabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#enabled_tools ActionGatewayMcpServer#enabled_tools}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledTools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EnabledTools
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>How long, in seconds, a user's authorization may be reused before they must consent again. 0 means 30 days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_authorization_ttl_seconds ActionGatewayMcpServer#oauth_authorization_ttl_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauthAuthorizationTtlSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OauthAuthorizationTtlSeconds
        {
            get;
            set;
        }

        /// <summary>For credential_ref_source connection: the OAuth authorization endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_authorize_url ActionGatewayMcpServer#oauth_authorize_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauthAuthorizeUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OauthAuthorizeUrl
        {
            get;
            set;
        }

        /// <summary>For credential_ref_source connection: client ID of your team's OAuth client for the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_client_id ActionGatewayMcpServer#oauth_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauthClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OauthClientId
        {
            get;
            set;
        }

        /// <summary>For credential_ref_source connection: client secret of your team's OAuth client. It is write-only.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_client_secret ActionGatewayMcpServer#oauth_client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauthClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OauthClientSecret
        {
            get;
            set;
        }

        /// <summary>For credential_ref_source connection: the scopes to request from each user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_scopes ActionGatewayMcpServer#oauth_scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OauthScopes
        {
            get;
            set;
        }

        /// <summary>For credential_ref_source connection: the OAuth token endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#oauth_token_url ActionGatewayMcpServer#oauth_token_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauthTokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OauthTokenUrl
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#timeouts ActionGatewayMcpServer#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerTimeouts\"}", isOptional: true)]
        public digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>MCP transport. Only streamable_http is supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#transport ActionGatewayMcpServer#transport}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Transport
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
