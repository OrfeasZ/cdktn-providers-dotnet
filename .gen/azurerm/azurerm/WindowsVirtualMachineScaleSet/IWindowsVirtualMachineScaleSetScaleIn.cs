using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineScaleSetScaleIn), fullyQualifiedName: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetScaleIn")]
    public interface IWindowsVirtualMachineScaleSetScaleIn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_virtual_machine_scale_set#force_deletion_enabled WindowsVirtualMachineScaleSet#force_deletion_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "forceDeletionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceDeletionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_virtual_machine_scale_set#rule WindowsVirtualMachineScaleSet#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Rule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineScaleSetScaleIn), fullyQualifiedName: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetScaleIn")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetScaleIn
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_virtual_machine_scale_set#force_deletion_enabled WindowsVirtualMachineScaleSet#force_deletion_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forceDeletionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForceDeletionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_virtual_machine_scale_set#rule WindowsVirtualMachineScaleSet#rule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Rule
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
