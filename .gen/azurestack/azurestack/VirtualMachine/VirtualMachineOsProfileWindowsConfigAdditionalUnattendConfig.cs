using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachine.VirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig")]
    public class VirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig : azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#component VirtualMachine#component}.</summary>
        [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}")]
        public string Component
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#content VirtualMachine#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#pass VirtualMachine#pass}.</summary>
        [JsiiProperty(name: "pass", typeJson: "{\"primitive\":\"string\"}")]
        public string Pass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#setting_name VirtualMachine#setting_name}.</summary>
        [JsiiProperty(name: "settingName", typeJson: "{\"primitive\":\"string\"}")]
        public string SettingName
        {
            get;
            set;
        }
    }
}
