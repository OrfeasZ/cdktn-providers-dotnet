using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineOsProfileSecrets), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileSecrets")]
    public interface IVirtualMachineOsProfileSecrets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#source_vault_id VirtualMachine#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        /// <summary>vault_certificates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#vault_certificates VirtualMachine#vault_certificates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachine.IVirtualMachineOsProfileSecretsVaultCertificates" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vaultCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileSecretsVaultCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VaultCertificates
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineOsProfileSecrets), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileSecrets")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachine.IVirtualMachineOsProfileSecrets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#source_vault_id VirtualMachine#source_vault_id}.</summary>
            [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceVaultId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>vault_certificates block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/virtual_machine#vault_certificates VirtualMachine#vault_certificates}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachine.IVirtualMachineOsProfileSecretsVaultCertificates" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vaultCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileSecretsVaultCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VaultCertificates
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
