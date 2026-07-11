using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDiskDiffDiskSettings")]
    public class WindowsVirtualMachineScaleSetOsDiskDiffDiskSettings : azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetOsDiskDiffDiskSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#option WindowsVirtualMachineScaleSet#option}.</summary>
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
        public string Option
        {
            get;
            set;
        }
    }
}
