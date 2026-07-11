using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContent")]
    public class WindowsVirtualMachineScaleSetAdditionalUnattendContent : azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#content WindowsVirtualMachineScaleSet#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#setting WindowsVirtualMachineScaleSet#setting}.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
        public string Setting
        {
            get;
            set;
        }
    }
}
