using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachine.VirtualMachineOsProfileSecrets")]
    public class VirtualMachineOsProfileSecrets : azurestack.VirtualMachine.IVirtualMachineOsProfileSecrets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#source_vault_id VirtualMachine#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceVaultId
        {
            get;
            set;
        }

        private object? _vaultCertificates;

        /// <summary>vault_certificates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#vault_certificates VirtualMachine#vault_certificates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineOsProfileSecretsVaultCertificates" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vaultCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileSecretsVaultCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VaultCertificates
        {
            get => _vaultCertificates;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.VirtualMachine.IVirtualMachineOsProfileSecretsVaultCertificates[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachine.IVirtualMachineOsProfileSecretsVaultCertificates).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vaultCertificates = value;
            }
        }
    }
}
