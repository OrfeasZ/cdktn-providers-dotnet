using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineScaleSetOsDiskDiffDiskSettings), fullyQualifiedName: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskDiffDiskSettings")]
    public interface ILinuxVirtualMachineScaleSetOsDiskDiffDiskSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#option LinuxVirtualMachineScaleSet#option}.</summary>
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
        string Option
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineScaleSetOsDiskDiffDiskSettings), fullyQualifiedName: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskDiffDiskSettings")]
        internal sealed class _Proxy : DeputyBase, azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDiskDiffDiskSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#option LinuxVirtualMachineScaleSet#option}.</summary>
            [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
            public string Option
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
