using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineBootDiagnostics), fullyQualifiedName: "azurestack.windowsVirtualMachine.WindowsVirtualMachineBootDiagnostics")]
    public interface IWindowsVirtualMachineBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#storage_account_uri WindowsVirtualMachine#storage_account_uri}.</summary>
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineBootDiagnostics), fullyQualifiedName: "azurestack.windowsVirtualMachine.WindowsVirtualMachineBootDiagnostics")]
        internal sealed class _Proxy : DeputyBase, azurestack.WindowsVirtualMachine.IWindowsVirtualMachineBootDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#storage_account_uri WindowsVirtualMachine#storage_account_uri}.</summary>
            [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
