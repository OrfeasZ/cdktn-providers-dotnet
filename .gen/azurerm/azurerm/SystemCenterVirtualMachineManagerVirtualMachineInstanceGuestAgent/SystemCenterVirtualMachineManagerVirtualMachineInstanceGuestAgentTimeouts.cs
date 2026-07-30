using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent
{
    [JsiiByValue(fqn: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeouts")]
    public class SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeouts : azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.ISystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#create SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#delete SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#read SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
