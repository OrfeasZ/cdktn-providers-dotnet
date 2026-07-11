using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineScaleSetAdditionalCapabilities), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilities")]
    public interface IWindowsVirtualMachineScaleSetAdditionalCapabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#ultra_ssd_enabled WindowsVirtualMachineScaleSet#ultra_ssd_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ultraSsdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UltraSsdEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineScaleSetAdditionalCapabilities), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilities")]
        internal sealed class _Proxy : DeputyBase, azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalCapabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#ultra_ssd_enabled WindowsVirtualMachineScaleSet#ultra_ssd_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ultraSsdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UltraSsdEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
