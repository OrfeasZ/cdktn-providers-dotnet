using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineScaleSetBootDiagnostics), fullyQualifiedName: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnostics")]
    public interface ILinuxVirtualMachineScaleSetBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#storage_account_uri LinuxVirtualMachineScaleSet#storage_account_uri}.</summary>
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineScaleSetBootDiagnostics), fullyQualifiedName: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnostics")]
        internal sealed class _Proxy : DeputyBase, azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#storage_account_uri LinuxVirtualMachineScaleSet#storage_account_uri}.</summary>
            [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
