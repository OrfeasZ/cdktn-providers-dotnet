using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineSecretCertificate), fullyQualifiedName: "azurestack.windowsVirtualMachine.WindowsVirtualMachineSecretCertificate")]
    public interface IWindowsVirtualMachineSecretCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#store WindowsVirtualMachine#store}.</summary>
        [JsiiProperty(name: "store", typeJson: "{\"primitive\":\"string\"}")]
        string Store
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineSecretCertificate), fullyQualifiedName: "azurestack.windowsVirtualMachine.WindowsVirtualMachineSecretCertificate")]
        internal sealed class _Proxy : DeputyBase, azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSecretCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#store WindowsVirtualMachine#store}.</summary>
            [JsiiProperty(name: "store", typeJson: "{\"primitive\":\"string\"}")]
            public string Store
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
