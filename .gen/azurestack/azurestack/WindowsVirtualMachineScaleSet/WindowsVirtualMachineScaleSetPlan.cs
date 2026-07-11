using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetPlan")]
    public class WindowsVirtualMachineScaleSetPlan : azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetPlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#name WindowsVirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#product WindowsVirtualMachineScaleSet#product}.</summary>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        public string Product
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#publisher WindowsVirtualMachineScaleSet#publisher}.</summary>
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
        public string Publisher
        {
            get;
            set;
        }
    }
}
