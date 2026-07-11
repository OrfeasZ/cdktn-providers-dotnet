using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetOsProfileSecretsVaultCertificates), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsVaultCertificates")]
    public interface IVirtualMachineScaleSetOsProfileSecretsVaultCertificates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#certificate_url VirtualMachineScaleSet#certificate_url}.</summary>
        [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#certificate_store VirtualMachineScaleSet#certificate_store}.</summary>
        [JsiiProperty(name: "certificateStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateStore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetOsProfileSecretsVaultCertificates), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsVaultCertificates")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecretsVaultCertificates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#certificate_url VirtualMachineScaleSet#certificate_url}.</summary>
            [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#certificate_store VirtualMachineScaleSet#certificate_store}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateStore
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
