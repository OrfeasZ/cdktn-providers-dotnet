using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy), fullyQualifiedName: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy")]
    public interface IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/windows_virtual_machine_scale_set#automatic_os_upgrade_enabled WindowsVirtualMachineScaleSet#automatic_os_upgrade_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "automaticOsUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AutomaticOsUpgradeEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/windows_virtual_machine_scale_set#automatic_rollback_enabled WindowsVirtualMachineScaleSet#automatic_rollback_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "automaticRollbackEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AutomaticRollbackEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy), fullyQualifiedName: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/windows_virtual_machine_scale_set#automatic_os_upgrade_enabled WindowsVirtualMachineScaleSet#automatic_os_upgrade_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "automaticOsUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AutomaticOsUpgradeEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/windows_virtual_machine_scale_set#automatic_rollback_enabled WindowsVirtualMachineScaleSet#automatic_rollback_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "automaticRollbackEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AutomaticRollbackEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
