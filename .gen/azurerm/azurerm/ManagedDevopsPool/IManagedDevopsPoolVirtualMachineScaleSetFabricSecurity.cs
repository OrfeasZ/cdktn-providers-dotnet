using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurity")]
    public interface IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#interactive_logon_enabled ManagedDevopsPool#interactive_logon_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "interactiveLogonEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InteractiveLogonEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_vault_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#key_vault_management ManagedDevopsPool#key_vault_management}
        /// </remarks>
        [JsiiProperty(name: "keyVaultManagement", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement? KeyVaultManagement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#interactive_logon_enabled ManagedDevopsPool#interactive_logon_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interactiveLogonEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InteractiveLogonEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>key_vault_management block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#key_vault_management ManagedDevopsPool#key_vault_management}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultManagement", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement\"}", isOptional: true)]
            public azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement? KeyVaultManagement
            {
                get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement?>();
            }
        }
    }
}
