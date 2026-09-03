using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryCredentialSet
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryCredentialSetConfig), fullyQualifiedName: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetConfig")]
    public interface IContainerRegistryCredentialSetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>authentication_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#authentication_credentials ContainerRegistryCredentialSet#authentication_credentials}
        /// </remarks>
        [JsiiProperty(name: "authenticationCredentials", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentials\"}")]
        azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials AuthenticationCredentials
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#container_registry_id ContainerRegistryCredentialSet#container_registry_id}.</summary>
        [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerRegistryId
        {
            get;
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#identity ContainerRegistryCredentialSet#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetIdentity\"}")]
        azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity Identity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#login_server ContainerRegistryCredentialSet#login_server}.</summary>
        [JsiiProperty(name: "loginServer", typeJson: "{\"primitive\":\"string\"}")]
        string LoginServer
        {
            get;
        }

        /// <summary>The name of the credential set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#name ContainerRegistryCredentialSet#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#id ContainerRegistryCredentialSet#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#timeouts ContainerRegistryCredentialSet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryCredentialSetConfig), fullyQualifiedName: "azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authentication_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#authentication_credentials ContainerRegistryCredentialSet#authentication_credentials}
            /// </remarks>
            [JsiiProperty(name: "authenticationCredentials", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetAuthenticationCredentials\"}")]
            public azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials AuthenticationCredentials
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetAuthenticationCredentials>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#container_registry_id ContainerRegistryCredentialSet#container_registry_id}.</summary>
            [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerRegistryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#identity ContainerRegistryCredentialSet#identity}
            /// </remarks>
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetIdentity\"}")]
            public azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity Identity
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetIdentity>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#login_server ContainerRegistryCredentialSet#login_server}.</summary>
            [JsiiProperty(name: "loginServer", typeJson: "{\"primitive\":\"string\"}")]
            public string LoginServer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the credential set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#name ContainerRegistryCredentialSet#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#id ContainerRegistryCredentialSet#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_credential_set#timeouts ContainerRegistryCredentialSet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryCredentialSet.ContainerRegistryCredentialSetTimeouts\"}", isOptional: true)]
            public azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryCredentialSet.IContainerRegistryCredentialSetTimeouts?>();
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
