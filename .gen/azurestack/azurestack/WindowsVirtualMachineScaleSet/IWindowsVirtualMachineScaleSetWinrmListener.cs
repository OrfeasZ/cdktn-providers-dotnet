using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineScaleSetWinrmListener), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListener")]
    public interface IWindowsVirtualMachineScaleSetWinrmListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#protocol WindowsVirtualMachineScaleSet#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineScaleSetWinrmListener), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListener")]
        internal sealed class _Proxy : DeputyBase, azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#protocol WindowsVirtualMachineScaleSet#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
