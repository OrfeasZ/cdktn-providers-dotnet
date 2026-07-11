using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDisk")]
    public class LinuxVirtualMachineOsDisk : azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#caching LinuxVirtualMachine#caching}.</summary>
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}")]
        public string Caching
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#storage_account_type LinuxVirtualMachine#storage_account_type}.</summary>
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountType
        {
            get;
            set;
        }

        /// <summary>diff_disk_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#diff_disk_settings LinuxVirtualMachine#diff_disk_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diffDiskSettings", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettings\"}", isOptional: true)]
        public azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDiskDiffDiskSettings? DiffDiskSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#disk_encryption_set_id LinuxVirtualMachine#disk_encryption_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskEncryptionSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#disk_size_gb LinuxVirtualMachine#disk_size_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskSizeGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#name LinuxVirtualMachine#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        private object? _writeAcceleratorEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#write_accelerator_enabled LinuxVirtualMachine#write_accelerator_enabled}.</summary>
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
