using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiByValue(fqn: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure")]
    public class SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure : azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#checkpoint_type SystemCenterVirtualMachineManagerVirtualMachineInstance#checkpoint_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "checkpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CheckpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_cloud_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_cloud_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemCenterVirtualMachineManagerCloudId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SystemCenterVirtualMachineManagerCloudId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_inventory_item_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_inventory_item_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemCenterVirtualMachineManagerInventoryItemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SystemCenterVirtualMachineManagerInventoryItemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_template_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_template_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemCenterVirtualMachineManagerTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SystemCenterVirtualMachineManagerTemplateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_virtual_machine_server_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_virtual_machine_server_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemCenterVirtualMachineManagerVirtualMachineServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SystemCenterVirtualMachineManagerVirtualMachineServerId
        {
            get;
            set;
        }
    }
}
