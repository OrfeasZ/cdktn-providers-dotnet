using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryCacheRule
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryCacheRuleConfig), fullyQualifiedName: "azurerm.containerRegistryCacheRule.ContainerRegistryCacheRuleConfig")]
    public interface IContainerRegistryCacheRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#container_registry_id ContainerRegistryCacheRule#container_registry_id}.</summary>
        [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerRegistryId
        {
            get;
        }

        /// <summary>The name of the cache rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#name ContainerRegistryCacheRule#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The full source repository path such as 'docker.io/library/ubuntu'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#source_repo ContainerRegistryCacheRule#source_repo}
        /// </remarks>
        [JsiiProperty(name: "sourceRepo", typeJson: "{\"primitive\":\"string\"}")]
        string SourceRepo
        {
            get;
        }

        /// <summary>The target repository namespace such as 'ubuntu'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#target_repo ContainerRegistryCacheRule#target_repo}
        /// </remarks>
        [JsiiProperty(name: "targetRepo", typeJson: "{\"primitive\":\"string\"}")]
        string TargetRepo
        {
            get;
        }

        /// <summary>The ARM resource ID of the credential store which is associated with the cache rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#credential_set_id ContainerRegistryCacheRule#credential_set_id}
        /// </remarks>
        [JsiiProperty(name: "credentialSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialSetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#id ContainerRegistryCacheRule#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#timeouts ContainerRegistryCacheRule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryCacheRule.ContainerRegistryCacheRuleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryCacheRule.IContainerRegistryCacheRuleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryCacheRuleConfig), fullyQualifiedName: "azurerm.containerRegistryCacheRule.ContainerRegistryCacheRuleConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryCacheRule.IContainerRegistryCacheRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#container_registry_id ContainerRegistryCacheRule#container_registry_id}.</summary>
            [JsiiProperty(name: "containerRegistryId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerRegistryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the cache rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#name ContainerRegistryCacheRule#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The full source repository path such as 'docker.io/library/ubuntu'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#source_repo ContainerRegistryCacheRule#source_repo}
            /// </remarks>
            [JsiiProperty(name: "sourceRepo", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceRepo
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The target repository namespace such as 'ubuntu'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#target_repo ContainerRegistryCacheRule#target_repo}
            /// </remarks>
            [JsiiProperty(name: "targetRepo", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetRepo
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ARM resource ID of the credential store which is associated with the cache rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#credential_set_id ContainerRegistryCacheRule#credential_set_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentialSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialSetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#id ContainerRegistryCacheRule#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_registry_cache_rule#timeouts ContainerRegistryCacheRule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryCacheRule.ContainerRegistryCacheRuleTimeouts\"}", isOptional: true)]
            public azurerm.ContainerRegistryCacheRule.IContainerRegistryCacheRuleTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryCacheRule.IContainerRegistryCacheRuleTimeouts?>();
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
