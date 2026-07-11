using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig")]
    public class VirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig : azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#component VirtualMachineScaleSet#component}.</summary>
        [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}")]
        public string Component
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#content VirtualMachineScaleSet#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#pass VirtualMachineScaleSet#pass}.</summary>
        [JsiiProperty(name: "pass", typeJson: "{\"primitive\":\"string\"}")]
        public string Pass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#setting_name VirtualMachineScaleSet#setting_name}.</summary>
        [JsiiProperty(name: "settingName", typeJson: "{\"primitive\":\"string\"}")]
        public string SettingName
        {
            get;
            set;
        }
    }
}
