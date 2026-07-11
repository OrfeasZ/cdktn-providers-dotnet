using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineScaleSetSecretCertificate), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecretCertificate")]
    public interface IWindowsVirtualMachineScaleSetSecretCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#store WindowsVirtualMachineScaleSet#store}.</summary>
        [JsiiProperty(name: "store", typeJson: "{\"primitive\":\"string\"}")]
        string Store
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineScaleSetSecretCertificate), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecretCertificate")]
        internal sealed class _Proxy : DeputyBase, azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecretCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#store WindowsVirtualMachineScaleSet#store}.</summary>
            [JsiiProperty(name: "store", typeJson: "{\"primitive\":\"string\"}")]
            public string Store
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
