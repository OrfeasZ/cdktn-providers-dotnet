using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IOrchestratedVirtualMachineScaleSetDataDisk), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetDataDisk")]
    public interface IOrchestratedVirtualMachineScaleSetDataDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#caching OrchestratedVirtualMachineScaleSet#caching}.</summary>
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}")]
        string Caching
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#storage_account_type OrchestratedVirtualMachineScaleSet#storage_account_type}.</summary>
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#create_option OrchestratedVirtualMachineScaleSet#create_option}.</summary>
        [JsiiProperty(name: "createOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreateOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#disk_encryption_set_id OrchestratedVirtualMachineScaleSet#disk_encryption_set_id}.</summary>
        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiskEncryptionSetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#disk_iops_read_write OrchestratedVirtualMachineScaleSet#disk_iops_read_write}.</summary>
        [JsiiProperty(name: "diskIopsReadWrite", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskIopsReadWrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#disk_mbps_read_write OrchestratedVirtualMachineScaleSet#disk_mbps_read_write}.</summary>
        [JsiiProperty(name: "diskMbpsReadWrite", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskMbpsReadWrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#disk_size_gb OrchestratedVirtualMachineScaleSet#disk_size_gb}.</summary>
        [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskSizeGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#lun OrchestratedVirtualMachineScaleSet#lun}.</summary>
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Lun
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#write_accelerator_enabled OrchestratedVirtualMachineScaleSet#write_accelerator_enabled}.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IOrchestratedVirtualMachineScaleSetDataDisk), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetDataDisk")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetDataDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#caching OrchestratedVirtualMachineScaleSet#caching}.</summary>
            [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}")]
            public string Caching
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#storage_account_type OrchestratedVirtualMachineScaleSet#storage_account_type}.</summary>
            [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#create_option OrchestratedVirtualMachineScaleSet#create_option}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreateOption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#disk_encryption_set_id OrchestratedVirtualMachineScaleSet#disk_encryption_set_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiskEncryptionSetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#disk_iops_read_write OrchestratedVirtualMachineScaleSet#disk_iops_read_write}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskIopsReadWrite", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskIopsReadWrite
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#disk_mbps_read_write OrchestratedVirtualMachineScaleSet#disk_mbps_read_write}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskMbpsReadWrite", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskMbpsReadWrite
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#disk_size_gb OrchestratedVirtualMachineScaleSet#disk_size_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskSizeGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#lun OrchestratedVirtualMachineScaleSet#lun}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Lun
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#write_accelerator_enabled OrchestratedVirtualMachineScaleSet#write_accelerator_enabled}.</summary>
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
