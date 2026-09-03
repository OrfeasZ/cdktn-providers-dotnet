using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiByValue(fqn: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDisk")]
    public class SystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDisk : azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#bus SystemCenterVirtualMachineManagerVirtualMachineInstance#bus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Bus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#bus_type SystemCenterVirtualMachineManagerVirtualMachineInstance#bus_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "busType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BusType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#disk_size_gb SystemCenterVirtualMachineManagerVirtualMachineInstance#disk_size_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskSizeGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#lun SystemCenterVirtualMachineManagerVirtualMachineInstance#lun}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Lun
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#name SystemCenterVirtualMachineManagerVirtualMachineInstance#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#storage_qos_policy_name SystemCenterVirtualMachineManagerVirtualMachineInstance#storage_qos_policy_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageQosPolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageQosPolicyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#template_disk_id SystemCenterVirtualMachineManagerVirtualMachineInstance#template_disk_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateDiskId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#vhd_type SystemCenterVirtualMachineManagerVirtualMachineInstance#vhd_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vhdType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VhdType
        {
            get;
            set;
        }
    }
}
