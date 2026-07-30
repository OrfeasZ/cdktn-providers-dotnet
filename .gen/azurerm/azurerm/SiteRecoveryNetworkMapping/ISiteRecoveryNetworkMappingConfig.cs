using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryNetworkMapping
{
    [JsiiInterface(nativeType: typeof(ISiteRecoveryNetworkMappingConfig), fullyQualifiedName: "azurerm.siteRecoveryNetworkMapping.SiteRecoveryNetworkMappingConfig")]
    public interface ISiteRecoveryNetworkMappingConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#name SiteRecoveryNetworkMapping#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#recovery_vault_name SiteRecoveryNetworkMapping#recovery_vault_name}.</summary>
        [JsiiProperty(name: "recoveryVaultName", typeJson: "{\"primitive\":\"string\"}")]
        string RecoveryVaultName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#resource_group_name SiteRecoveryNetworkMapping#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#source_network_id SiteRecoveryNetworkMapping#source_network_id}.</summary>
        [JsiiProperty(name: "sourceNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceNetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#source_recovery_fabric_name SiteRecoveryNetworkMapping#source_recovery_fabric_name}.</summary>
        [JsiiProperty(name: "sourceRecoveryFabricName", typeJson: "{\"primitive\":\"string\"}")]
        string SourceRecoveryFabricName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#target_network_id SiteRecoveryNetworkMapping#target_network_id}.</summary>
        [JsiiProperty(name: "targetNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetNetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#target_recovery_fabric_name SiteRecoveryNetworkMapping#target_recovery_fabric_name}.</summary>
        [JsiiProperty(name: "targetRecoveryFabricName", typeJson: "{\"primitive\":\"string\"}")]
        string TargetRecoveryFabricName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#id SiteRecoveryNetworkMapping#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#timeouts SiteRecoveryNetworkMapping#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.siteRecoveryNetworkMapping.SiteRecoveryNetworkMappingTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SiteRecoveryNetworkMapping.ISiteRecoveryNetworkMappingTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISiteRecoveryNetworkMappingConfig), fullyQualifiedName: "azurerm.siteRecoveryNetworkMapping.SiteRecoveryNetworkMappingConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SiteRecoveryNetworkMapping.ISiteRecoveryNetworkMappingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#name SiteRecoveryNetworkMapping#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#recovery_vault_name SiteRecoveryNetworkMapping#recovery_vault_name}.</summary>
            [JsiiProperty(name: "recoveryVaultName", typeJson: "{\"primitive\":\"string\"}")]
            public string RecoveryVaultName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#resource_group_name SiteRecoveryNetworkMapping#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#source_network_id SiteRecoveryNetworkMapping#source_network_id}.</summary>
            [JsiiProperty(name: "sourceNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#source_recovery_fabric_name SiteRecoveryNetworkMapping#source_recovery_fabric_name}.</summary>
            [JsiiProperty(name: "sourceRecoveryFabricName", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceRecoveryFabricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#target_network_id SiteRecoveryNetworkMapping#target_network_id}.</summary>
            [JsiiProperty(name: "targetNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#target_recovery_fabric_name SiteRecoveryNetworkMapping#target_recovery_fabric_name}.</summary>
            [JsiiProperty(name: "targetRecoveryFabricName", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetRecoveryFabricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#id SiteRecoveryNetworkMapping#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_network_mapping#timeouts SiteRecoveryNetworkMapping#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.siteRecoveryNetworkMapping.SiteRecoveryNetworkMappingTimeouts\"}", isOptional: true)]
            public azurerm.SiteRecoveryNetworkMapping.ISiteRecoveryNetworkMappingTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SiteRecoveryNetworkMapping.ISiteRecoveryNetworkMappingTimeouts?>();
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
