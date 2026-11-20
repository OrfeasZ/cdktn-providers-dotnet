using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayProviderCredential
{
    [JsiiInterface(nativeType: typeof(IActionGatewayProviderCredentialConfig), fullyQualifiedName: "digitalocean.actionGatewayProviderCredential.ActionGatewayProviderCredentialConfig")]
    public interface IActionGatewayProviderCredentialConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Label, unique among your team's credentials for the tool provider, ignoring case.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#display_name ActionGatewayProviderCredential#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Kind of credential: oauth_client or api_key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#kind ActionGatewayProviderCredential#kind}
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Slug of the tool provider the credential is for, such as github or jira.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#tool_provider ActionGatewayProviderCredential#tool_provider}
        /// </remarks>
        [JsiiProperty(name: "toolProvider", typeJson: "{\"primitive\":\"string\"}")]
        string ToolProvider
        {
            get;
        }

        /// <summary>For kind api_key: the key or token sent to the tool provider.</summary>
        /// <remarks>
        /// It is write-only, and changing it rotates the key in place.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#api_key ActionGatewayProviderCredential#api_key}
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

        /// <summary>HTTPS origin of the tool provider's API, for a provider that accepts one.</summary>
        /// <remarks>
        /// Derived from credential_parameters when those are set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#base_url ActionGatewayProviderCredential#base_url}
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

        /// <summary>For kind oauth_client: client ID of your OAuth client at the tool provider. Changing it replaces the credential.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#client_id ActionGatewayProviderCredential#client_id}
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

        /// <summary>For kind oauth_client: client secret of your OAuth client.</summary>
        /// <remarks>
        /// It is write-only, and changing it rotates the secret in place.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#client_secret ActionGatewayProviderCredential#client_secret}
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

        /// <summary>For kind api_key: values for the credential parameters the tool provider declares, such as subdomain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#credential_parameters ActionGatewayProviderCredential#credential_parameters}
        /// </remarks>
        [JsiiProperty(name: "credentialParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CredentialParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#id ActionGatewayProviderCredential#id}.</summary>
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

        /// <summary>For kind oauth_client: HTTPS redirect URI registered with your OAuth client. Omit it to use DigitalOcean's callback.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#redirect_url ActionGatewayProviderCredential#redirect_url}
        /// </remarks>
        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedirectUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether everyone on your team can see and use the credential instead of only its creator.</summary>
        /// <remarks>
        /// Sharing cannot be undone, so turning it off replaces the credential.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#reusable_by_team ActionGatewayProviderCredential#reusable_by_team}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "reusableByTeam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReusableByTeam
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayProviderCredentialConfig), fullyQualifiedName: "digitalocean.actionGatewayProviderCredential.ActionGatewayProviderCredentialConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayProviderCredential.IActionGatewayProviderCredentialConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Label, unique among your team's credentials for the tool provider, ignoring case.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#display_name ActionGatewayProviderCredential#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Kind of credential: oauth_client or api_key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#kind ActionGatewayProviderCredential#kind}
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Slug of the tool provider the credential is for, such as github or jira.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#tool_provider ActionGatewayProviderCredential#tool_provider}
            /// </remarks>
            [JsiiProperty(name: "toolProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string ToolProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>For kind api_key: the key or token sent to the tool provider.</summary>
            /// <remarks>
            /// It is write-only, and changing it rotates the key in place.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#api_key ActionGatewayProviderCredential#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>HTTPS origin of the tool provider's API, for a provider that accepts one.</summary>
            /// <remarks>
            /// Derived from credential_parameters when those are set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#base_url ActionGatewayProviderCredential#base_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For kind oauth_client: client ID of your OAuth client at the tool provider. Changing it replaces the credential.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#client_id ActionGatewayProviderCredential#client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For kind oauth_client: client secret of your OAuth client.</summary>
            /// <remarks>
            /// It is write-only, and changing it rotates the secret in place.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#client_secret ActionGatewayProviderCredential#client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For kind api_key: values for the credential parameters the tool provider declares, such as subdomain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#credential_parameters ActionGatewayProviderCredential#credential_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentialParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CredentialParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#id ActionGatewayProviderCredential#id}.</summary>
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

            /// <summary>For kind oauth_client: HTTPS redirect URI registered with your OAuth client. Omit it to use DigitalOcean's callback.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#redirect_url ActionGatewayProviderCredential#redirect_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedirectUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether everyone on your team can see and use the credential instead of only its creator.</summary>
            /// <remarks>
            /// Sharing cannot be undone, so turning it off replaces the credential.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.109.0/docs/resources/action_gateway_provider_credential#reusable_by_team ActionGatewayProviderCredential#reusable_by_team}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reusableByTeam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReusableByTeam
            {
                get => GetInstanceProperty<object?>();
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
