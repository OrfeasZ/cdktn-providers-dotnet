using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlan")]
    public class LinuxVirtualMachineScaleSetPlan : azurestack.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#name LinuxVirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#product LinuxVirtualMachineScaleSet#product}.</summary>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        public string Product
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine_scale_set#publisher LinuxVirtualMachineScaleSet#publisher}.</summary>
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
        public string Publisher
        {
            get;
            set;
        }
    }
}
