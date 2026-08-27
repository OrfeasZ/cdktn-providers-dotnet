using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineOsProfileWindowsConfig), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfig")]
    public interface IVirtualMachineOsProfileWindowsConfig
    {
        /// <summary>additional_unattend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#additional_unattend_config VirtualMachine#additional_unattend_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "additionalUnattendConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalUnattendConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#enable_automatic_upgrades VirtualMachine#enable_automatic_upgrades}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableAutomaticUpgrades", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableAutomaticUpgrades
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#provision_vm_agent VirtualMachine#provision_vm_agent}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "provisionVmAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProvisionVmAgent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#timezone VirtualMachine#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timezone
        {
            get
            {
                return null;
            }
        }

        /// <summary>winrm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#winrm VirtualMachine#winrm}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfigWinrm" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "winrm", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfigWinrm\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Winrm
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineOsProfileWindowsConfig), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>additional_unattend_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#additional_unattend_config VirtualMachine#additional_unattend_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalUnattendConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalUnattendConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#enable_automatic_upgrades VirtualMachine#enable_automatic_upgrades}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableAutomaticUpgrades", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableAutomaticUpgrades
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#provision_vm_agent VirtualMachine#provision_vm_agent}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisionVmAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ProvisionVmAgent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#timezone VirtualMachine#timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timezone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>winrm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine#winrm VirtualMachine#winrm}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfigWinrm" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "winrm", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfigWinrm\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Winrm
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
