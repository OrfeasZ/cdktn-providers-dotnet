using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.windowsVirtualMachine.WindowsVirtualMachinePlan")]
    public class WindowsVirtualMachinePlan : azurestack.WindowsVirtualMachine.IWindowsVirtualMachinePlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#name WindowsVirtualMachine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#product WindowsVirtualMachine#product}.</summary>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        public string Product
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#publisher WindowsVirtualMachine#publisher}.</summary>
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
        public string Publisher
        {
            get;
            set;
        }
    }
}
