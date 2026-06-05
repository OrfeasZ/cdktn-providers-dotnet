using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.Provider
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs tailscale}.</summary>
    [JsiiClass(nativeType: typeof(tailscale.Provider.TailscaleProvider), fullyQualifiedName: "tailscale.provider.TailscaleProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"tailscale.provider.TailscaleProviderConfig\"}}]")]
    public class TailscaleProvider : Io.Cdktn.TerraformProvider
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs tailscale} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TailscaleProvider(Constructs.Construct scope, string id, tailscale.Provider.ITailscaleProviderConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, tailscale.Provider.ITailscaleProviderConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TailscaleProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TailscaleProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a TailscaleProvider resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the TailscaleProvider to import.</param>
        /// <param name="importFromId">The id of the existing TailscaleProvider that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the TailscaleProvider to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the TailscaleProvider to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing TailscaleProvider that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the TailscaleProvider to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(tailscale.Provider.TailscaleProvider), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiKey")]
        public virtual void ResetApiKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudience")]
        public virtual void ResetAudience()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBaseUrl")]
        public virtual void ResetBaseUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityToken")]
        public virtual void ResetIdentityToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityTokenEnvironmentVariableName")]
        public virtual void ResetIdentityTokenEnvironmentVariableName()
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

        [JsiiMethod(name: "resetScopes")]
        public virtual void ResetScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTailnet")]
        public virtual void ResetTailnet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserAgent")]
        public virtual void ResetUserAgent()
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
        = GetStaticProperty<string>(typeof(tailscale.Provider.TailscaleProvider))!;

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audienceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudienceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityTokenEnvironmentVariableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityTokenEnvironmentVariableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityTokenInput
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
        [JsiiProperty(name: "scopesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ScopesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tailnetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TailnetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAgentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserAgentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public override string? Alias
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiKey
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Audience
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseUrl
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityToken
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityTokenEnvironmentVariableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityTokenEnvironmentVariableName
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OauthClientId
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OauthClientSecret
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Scopes
        {
            get => GetInstanceProperty<string[]?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "tailnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tailnet
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserAgent
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }
    }
}
