using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineOsProfileWindowsConfigWinrm), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachineOsProfileWindowsConfigWinrm")]
    public interface IVirtualMachineOsProfileWindowsConfigWinrm
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#protocol VirtualMachine#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#certificate_url VirtualMachine#certificate_url}.</summary>
        [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineOsProfileWindowsConfigWinrm), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachineOsProfileWindowsConfigWinrm")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfigWinrm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#protocol VirtualMachine#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#certificate_url VirtualMachine#certificate_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
