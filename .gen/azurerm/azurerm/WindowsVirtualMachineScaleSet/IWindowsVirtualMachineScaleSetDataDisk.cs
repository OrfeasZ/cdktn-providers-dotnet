using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineScaleSetDataDisk), fullyQualifiedName: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDisk")]
    public interface IWindowsVirtualMachineScaleSetDataDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#caching WindowsVirtualMachineScaleSet#caching}.</summary>
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}")]
        string Caching
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#disk_size_gb WindowsVirtualMachineScaleSet#disk_size_gb}.</summary>
        [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}")]
        double DiskSizeGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#lun WindowsVirtualMachineScaleSet#lun}.</summary>
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}")]
        double Lun
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#storage_account_type WindowsVirtualMachineScaleSet#storage_account_type}.</summary>
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#create_option WindowsVirtualMachineScaleSet#create_option}.</summary>
        [JsiiProperty(name: "createOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreateOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#disk_encryption_set_id WindowsVirtualMachineScaleSet#disk_encryption_set_id}.</summary>
        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiskEncryptionSetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#disk_iops_read_write WindowsVirtualMachineScaleSet#disk_iops_read_write}.</summary>
        [JsiiProperty(name: "diskIopsReadWrite", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskIopsReadWrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#disk_mbps_read_write WindowsVirtualMachineScaleSet#disk_mbps_read_write}.</summary>
        [JsiiProperty(name: "diskMbpsReadWrite", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskMbpsReadWrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#name WindowsVirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#write_accelerator_enabled WindowsVirtualMachineScaleSet#write_accelerator_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "writeAcceleratorEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WriteAcceleratorEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineScaleSetDataDisk), fullyQualifiedName: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDisk")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#caching WindowsVirtualMachineScaleSet#caching}.</summary>
            [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}")]
            public string Caching
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#disk_size_gb WindowsVirtualMachineScaleSet#disk_size_gb}.</summary>
            [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}")]
            public double DiskSizeGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#lun WindowsVirtualMachineScaleSet#lun}.</summary>
            [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}")]
            public double Lun
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#storage_account_type WindowsVirtualMachineScaleSet#storage_account_type}.</summary>
            [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#create_option WindowsVirtualMachineScaleSet#create_option}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreateOption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#disk_encryption_set_id WindowsVirtualMachineScaleSet#disk_encryption_set_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiskEncryptionSetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#disk_iops_read_write WindowsVirtualMachineScaleSet#disk_iops_read_write}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskIopsReadWrite", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskIopsReadWrite
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#disk_mbps_read_write WindowsVirtualMachineScaleSet#disk_mbps_read_write}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskMbpsReadWrite", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskMbpsReadWrite
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#name WindowsVirtualMachineScaleSet#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/windows_virtual_machine_scale_set#write_accelerator_enabled WindowsVirtualMachineScaleSet#write_accelerator_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeAcceleratorEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WriteAcceleratorEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
