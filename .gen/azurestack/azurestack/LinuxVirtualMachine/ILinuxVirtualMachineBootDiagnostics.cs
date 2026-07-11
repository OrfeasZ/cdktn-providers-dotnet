using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineBootDiagnostics), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics")]
    public interface ILinuxVirtualMachineBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#storage_account_uri LinuxVirtualMachine#storage_account_uri}.</summary>
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineBootDiagnostics), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics")]
        internal sealed class _Proxy : DeputyBase, azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#storage_account_uri LinuxVirtualMachine#storage_account_uri}.</summary>
            [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
