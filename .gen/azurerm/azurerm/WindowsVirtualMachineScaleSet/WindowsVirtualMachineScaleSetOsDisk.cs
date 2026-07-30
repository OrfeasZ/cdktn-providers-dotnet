using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDisk")]
    public class WindowsVirtualMachineScaleSetOsDisk : azurerm.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetOsDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/windows_virtual_machine_scale_set#caching WindowsVirtualMachineScaleSet#caching}.</summary>
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}")]
        public string Caching
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/windows_virtual_machine_scale_set#storage_account_type WindowsVirtualMachineScaleSet#storage_account_type}.</summary>
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountType
        {
            get;
            set;
        }

        /// <summary>diff_disk_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/windows_virtual_machine_scale_set#diff_disk_settings WindowsVirtualMachineScaleSet#diff_disk_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diffDiskSettings", typeJson: "{\"fqn\":\"azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDiskDiffDiskSettings\"}", isOptional: true)]
        public azurerm.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetOsDiskDiffDiskSettings? DiffDiskSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/windows_virtual_machine_scale_set#disk_encryption_set_id WindowsVirtualMachineScaleSet#disk_encryption_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskEncryptionSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/windows_virtual_machine_scale_set#disk_size_gb WindowsVirtualMachineScaleSet#disk_size_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskSizeGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/windows_virtual_machine_scale_set#secure_vm_disk_encryption_set_id WindowsVirtualMachineScaleSet#secure_vm_disk_encryption_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secureVmDiskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecureVmDiskEncryptionSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/windows_virtual_machine_scale_set#security_encryption_type WindowsVirtualMachineScaleSet#security_encryption_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityEncryptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityEncryptionType
        {
            get;
            set;
        }

        private object? _writeAcceleratorEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/windows_virtual_machine_scale_set#write_accelerator_enabled WindowsVirtualMachineScaleSet#write_accelerator_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "writeAcceleratorEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? WriteAcceleratorEnabled
        {
            get => _writeAcceleratorEnabled;
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
                _writeAcceleratorEnabled = value;
            }
        }
    }
}
