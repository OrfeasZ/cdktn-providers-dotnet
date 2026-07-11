using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineWinrmListener), fullyQualifiedName: "azurestack.windowsVirtualMachine.WindowsVirtualMachineWinrmListener")]
    public interface IWindowsVirtualMachineWinrmListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#protocol WindowsVirtualMachine#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineWinrmListener), fullyQualifiedName: "azurestack.windowsVirtualMachine.WindowsVirtualMachineWinrmListener")]
        internal sealed class _Proxy : DeputyBase, azurestack.WindowsVirtualMachine.IWindowsVirtualMachineWinrmListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#protocol WindowsVirtualMachine#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
