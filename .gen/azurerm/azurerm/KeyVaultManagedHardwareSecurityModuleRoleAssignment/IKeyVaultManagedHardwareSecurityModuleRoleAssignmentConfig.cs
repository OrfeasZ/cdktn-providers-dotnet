using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment
{
    [JsiiInterface(nativeType: typeof(IKeyVaultManagedHardwareSecurityModuleRoleAssignmentConfig), fullyQualifiedName: "azurerm.keyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignmentConfig")]
    public interface IKeyVaultManagedHardwareSecurityModuleRoleAssignmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#managed_hsm_id KeyVaultManagedHardwareSecurityModuleRoleAssignment#managed_hsm_id}.</summary>
        [JsiiProperty(name: "managedHsmId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedHsmId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#name KeyVaultManagedHardwareSecurityModuleRoleAssignment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#principal_id KeyVaultManagedHardwareSecurityModuleRoleAssignment#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#role_definition_id KeyVaultManagedHardwareSecurityModuleRoleAssignment#role_definition_id}.</summary>
        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleDefinitionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#scope KeyVaultManagedHardwareSecurityModuleRoleAssignment#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#id KeyVaultManagedHardwareSecurityModuleRoleAssignment#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#timeouts KeyVaultManagedHardwareSecurityModuleRoleAssignment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.keyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.IKeyVaultManagedHardwareSecurityModuleRoleAssignmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultManagedHardwareSecurityModuleRoleAssignmentConfig), fullyQualifiedName: "azurerm.keyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignmentConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.IKeyVaultManagedHardwareSecurityModuleRoleAssignmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#managed_hsm_id KeyVaultManagedHardwareSecurityModuleRoleAssignment#managed_hsm_id}.</summary>
            [JsiiProperty(name: "managedHsmId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedHsmId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#name KeyVaultManagedHardwareSecurityModuleRoleAssignment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#principal_id KeyVaultManagedHardwareSecurityModuleRoleAssignment#principal_id}.</summary>
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#role_definition_id KeyVaultManagedHardwareSecurityModuleRoleAssignment#role_definition_id}.</summary>
            [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleDefinitionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#scope KeyVaultManagedHardwareSecurityModuleRoleAssignment#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#id KeyVaultManagedHardwareSecurityModuleRoleAssignment#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#timeouts KeyVaultManagedHardwareSecurityModuleRoleAssignment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.keyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignmentTimeouts\"}", isOptional: true)]
            public azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.IKeyVaultManagedHardwareSecurityModuleRoleAssignmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.IKeyVaultManagedHardwareSecurityModuleRoleAssignmentTimeouts?>();
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
