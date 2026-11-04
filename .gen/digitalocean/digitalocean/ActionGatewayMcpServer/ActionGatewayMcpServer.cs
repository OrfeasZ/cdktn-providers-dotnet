using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayMcpServer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server digitalocean_action_gateway_mcp_server}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.ActionGatewayMcpServer.ActionGatewayMcpServer), fullyQualifiedName: "digitalocean.actionGatewayMcpServer.ActionGatewayMcpServer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerConfig\"}}]")]
    public class ActionGatewayMcpServer : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server digitalocean_action_gateway_mcp_server} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ActionGatewayMcpServer(Constructs.Construct scope, string id, digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActionGatewayMcpServer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActionGatewayMcpServer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ActionGatewayMcpServer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ActionGatewayMcpServer to import.</param>
        /// <param name="importFromId">The id of the existing ActionGatewayMcpServer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ActionGatewayMcpServer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ActionGatewayMcpServer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ActionGatewayMcpServer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ActionGatewayMcpServer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.ActionGatewayMcpServer.ActionGatewayMcpServer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerTimeouts\"}}]")]
        public virtual void PutTimeouts(digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiKey")]
        public virtual void ResetApiKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialRef")]
        public virtual void ResetCredentialRef()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialRefSource")]
        public virtual void ResetCredentialRefSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabledTools")]
        public virtual void ResetEnabledTools()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthAuthorizationTtlSeconds")]
        public virtual void ResetOauthAuthorizationTtlSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthAuthorizeUrl")]
        public virtual void ResetOauthAuthorizeUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthClientId")]
        public virtual void ResetOauthClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthClientSecret")]
        public virtual void ResetOauthClientSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthScopes")]
        public virtual void ResetOauthScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthTokenUrl")]
        public virtual void ResetOauthTokenUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSyncUserId")]
        public virtual void ResetSyncUserId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransport")]
        public virtual void ResetTransport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(digitalocean.ActionGatewayMcpServer.ActionGatewayMcpServer))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "discoveredTools", typeJson: "{\"fqn\":\"digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerDiscoveredToolsList\"}")]
        public virtual digitalocean.ActionGatewayMcpServer.ActionGatewayMcpServerDiscoveredToolsList DiscoveredTools
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayMcpServer.ActionGatewayMcpServerDiscoveredToolsList>()!;
        }

        [JsiiProperty(name: "lastSyncedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastSyncedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protocolVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "syncError", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncError
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "syncStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerTimeoutsOutputReference\"}")]
        public virtual digitalocean.ActionGatewayMcpServer.ActionGatewayMcpServerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayMcpServer.ActionGatewayMcpServerTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "toolCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ToolCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialRefInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialRefInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialRefSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialRefSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledToolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledToolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthAuthorizationTtlSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OauthAuthorizationTtlSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthAuthorizeUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OauthAuthorizeUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthClientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OauthClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthClientSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OauthClientSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthScopesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OauthScopesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthTokenUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OauthTokenUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverRefInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerRefInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "syncUserIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SyncUserIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransportInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "credentialRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialRef
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "credentialRefSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialRefSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabledTools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledTools
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oauthAuthorizationTtlSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OauthAuthorizationTtlSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oauthAuthorizeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OauthAuthorizeUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oauthClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OauthClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oauthClientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OauthClientSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OauthScopes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oauthTokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OauthTokenUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerRef
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "syncUserId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncUserId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Transport
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
