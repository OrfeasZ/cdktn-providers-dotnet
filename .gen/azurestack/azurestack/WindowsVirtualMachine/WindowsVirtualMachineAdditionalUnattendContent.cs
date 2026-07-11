using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.windowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContent")]
    public class WindowsVirtualMachineAdditionalUnattendContent : azurestack.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalUnattendContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#content WindowsVirtualMachine#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#setting WindowsVirtualMachine#setting}.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
        public string Setting
        {
            get;
            set;
        }
    }
}
