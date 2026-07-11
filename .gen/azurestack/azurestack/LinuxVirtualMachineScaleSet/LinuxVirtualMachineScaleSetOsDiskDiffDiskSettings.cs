using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskDiffDiskSettings")]
    public class LinuxVirtualMachineScaleSetOsDiskDiffDiskSettings : azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDiskDiffDiskSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#option LinuxVirtualMachineScaleSet#option}.</summary>
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
        public string Option
        {
            get;
            set;
        }
    }
}
