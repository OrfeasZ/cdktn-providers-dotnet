using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachine.VirtualMachineIdentity")]
    public class VirtualMachineIdentity : azurestack.VirtualMachine.IVirtualMachineIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#type VirtualMachine#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
