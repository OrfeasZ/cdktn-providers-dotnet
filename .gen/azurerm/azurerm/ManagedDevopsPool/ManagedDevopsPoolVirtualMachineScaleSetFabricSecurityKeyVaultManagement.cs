using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement")]
    public class ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement : azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#key_vault_certificate_ids ManagedDevopsPool#key_vault_certificate_ids}.</summary>
        [JsiiProperty(name: "keyVaultCertificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] KeyVaultCertificateIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#certificate_store_location ManagedDevopsPool#certificate_store_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateStoreLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateStoreLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#certificate_store_name ManagedDevopsPool#certificate_store_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateStoreName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateStoreName
        {
            get;
            set;
        }

        private object? _keyExportEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#key_export_enabled ManagedDevopsPool#key_export_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyExportEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? KeyExportEnabled
        {
            get => _keyExportEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keyExportEnabled = value;
            }
        }
    }
}
