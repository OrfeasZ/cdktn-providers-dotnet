using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetOsProfileSecrets), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets")]
    public interface IVirtualMachineScaleSetOsProfileSecrets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#source_vault_id VirtualMachineScaleSet#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        /// <summary>vault_certificates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#vault_certificates VirtualMachineScaleSet#vault_certificates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecretsVaultCertificates" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vaultCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsVaultCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VaultCertificates
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetOsProfileSecrets), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#source_vault_id VirtualMachineScaleSet#source_vault_id}.</summary>
            [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceVaultId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>vault_certificates block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#vault_certificates VirtualMachineScaleSet#vault_certificates}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecretsVaultCertificates" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vaultCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsVaultCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VaultCertificates
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
