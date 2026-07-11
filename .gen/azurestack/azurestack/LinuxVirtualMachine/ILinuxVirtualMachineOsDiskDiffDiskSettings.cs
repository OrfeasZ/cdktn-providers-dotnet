using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineOsDiskDiffDiskSettings), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettings")]
    public interface ILinuxVirtualMachineOsDiskDiffDiskSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#option LinuxVirtualMachine#option}.</summary>
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
        string Option
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineOsDiskDiffDiskSettings), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettings")]
        internal sealed class _Proxy : DeputyBase, azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDiskDiffDiskSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#option LinuxVirtualMachine#option}.</summary>
            [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
            public string Option
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
