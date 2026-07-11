using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret")]
    public class LinuxVirtualMachineScaleSetSecret : azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret
    {
        private object _certificate;

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#certificate LinuxVirtualMachineScaleSet#certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecretCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretCertificate\"},\"kind\":\"array\"}}]}}")]
        public object Certificate
        {
            get => _certificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecretCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecretCertificate).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecretCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _certificate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#key_vault_id LinuxVirtualMachineScaleSet#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultId
        {
            get;
            set;
        }
    }
}
