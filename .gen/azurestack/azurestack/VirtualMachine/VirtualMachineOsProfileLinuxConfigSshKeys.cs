using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachine.VirtualMachineOsProfileLinuxConfigSshKeys")]
    public class VirtualMachineOsProfileLinuxConfigSshKeys : azurestack.VirtualMachine.IVirtualMachineOsProfileLinuxConfigSshKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#key_data VirtualMachine#key_data}.</summary>
        [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#path VirtualMachine#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
