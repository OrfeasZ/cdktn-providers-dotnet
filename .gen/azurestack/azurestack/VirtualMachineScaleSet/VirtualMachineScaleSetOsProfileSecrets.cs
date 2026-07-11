using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets")]
    public class VirtualMachineScaleSetOsProfileSecrets : azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#source_vault_id VirtualMachineScaleSet#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceVaultId
        {
            get;
            set;
        }

        private object? _vaultCertificates;

        /// <summary>vault_certificates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#vault_certificates VirtualMachineScaleSet#vault_certificates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecretsVaultCertificates" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vaultCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsVaultCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecretsVaultCertificates[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecretsVaultCertificates).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vaultCertificates = value;
            }
        }
    }
}
