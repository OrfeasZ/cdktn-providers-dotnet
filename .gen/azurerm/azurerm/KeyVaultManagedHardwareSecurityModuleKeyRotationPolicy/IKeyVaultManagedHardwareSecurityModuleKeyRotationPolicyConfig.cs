using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy
{
    [JsiiInterface(nativeType: typeof(IKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyConfig), fullyQualifiedName: "azurerm.keyVaultManagedHardwareSecurityModuleKeyRotationPolicy.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicyConfig")]
    public interface IKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#expire_after KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#expire_after}.</summary>
        [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}")]
        string ExpireAfter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#managed_hsm_key_id KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#managed_hsm_key_id}.</summary>
        [JsiiProperty(name: "managedHsmKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedHsmKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#id KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#time_after_creation KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#time_after_creation}.</summary>
        [JsiiProperty(name: "timeAfterCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeAfterCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#time_before_expiry KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#time_before_expiry}.</summary>
        [JsiiProperty(name: "timeBeforeExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeBeforeExpiry
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#timeouts KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.keyVaultManagedHardwareSecurityModuleKeyRotationPolicy.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy.IKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyConfig), fullyQualifiedName: "azurerm.keyVaultManagedHardwareSecurityModuleKeyRotationPolicy.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy.IKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#expire_after KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#expire_after}.</summary>
            [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}")]
            public string ExpireAfter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#managed_hsm_key_id KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#managed_hsm_key_id}.</summary>
            [JsiiProperty(name: "managedHsmKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedHsmKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#id KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#time_after_creation KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#time_after_creation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeAfterCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeAfterCreation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#time_before_expiry KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#time_before_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeBeforeExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeBeforeExpiry
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/key_vault_managed_hardware_security_module_key_rotation_policy#timeouts KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.keyVaultManagedHardwareSecurityModuleKeyRotationPolicy.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeouts\"}", isOptional: true)]
            public azurerm.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy.IKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.KeyVaultManagedHardwareSecurityModuleKeyRotationPolicy.IKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeouts?>();
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
