using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigSshKeys")]
    public class VirtualMachineScaleSetOsProfileLinuxConfigSshKeys : azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfigSshKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#path VirtualMachineScaleSet#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#key_data VirtualMachineScaleSet#key_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyData
        {
            get;
            set;
        }
    }
}
