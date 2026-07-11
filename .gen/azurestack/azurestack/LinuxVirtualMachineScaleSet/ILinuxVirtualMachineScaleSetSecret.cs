using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineScaleSetSecret), fullyQualifiedName: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret")]
    public interface ILinuxVirtualMachineScaleSetSecret
    {
        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#certificate LinuxVirtualMachineScaleSet#certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecretCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretCertificate\"},\"kind\":\"array\"}}]}}")]
        object Certificate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#key_vault_id LinuxVirtualMachineScaleSet#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineScaleSetSecret), fullyQualifiedName: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret")]
        internal sealed class _Proxy : DeputyBase, azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#certificate LinuxVirtualMachineScaleSet#certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecretCertificate" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretCertificate\"},\"kind\":\"array\"}}]}}")]
            public object Certificate
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#key_vault_id LinuxVirtualMachineScaleSet#key_vault_id}.</summary>
            [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
