using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiByValue(fqn: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceTimeouts")]
    public class SystemCenterVirtualMachineManagerVirtualMachineInstanceTimeouts : azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#create SystemCenterVirtualMachineManagerVirtualMachineInstance#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#delete SystemCenterVirtualMachineManagerVirtualMachineInstance#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#read SystemCenterVirtualMachineManagerVirtualMachineInstance#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#update SystemCenterVirtualMachineManagerVirtualMachineInstance#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
