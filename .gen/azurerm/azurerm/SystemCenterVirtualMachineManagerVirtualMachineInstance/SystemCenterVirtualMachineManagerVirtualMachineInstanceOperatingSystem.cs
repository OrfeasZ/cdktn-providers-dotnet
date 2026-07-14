using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiByValue(fqn: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystem")]
    public class SystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystem : azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#admin_password SystemCenterVirtualMachineManagerVirtualMachineInstance#admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#computer_name SystemCenterVirtualMachineManagerVirtualMachineInstance#computer_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputerName
        {
            get;
            set;
        }
    }
}
