using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettings")]
    public class LinuxVirtualMachineOsDiskDiffDiskSettings : azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDiskDiffDiskSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#option LinuxVirtualMachine#option}.</summary>
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
        public string Option
        {
            get;
            set;
        }
    }
}
