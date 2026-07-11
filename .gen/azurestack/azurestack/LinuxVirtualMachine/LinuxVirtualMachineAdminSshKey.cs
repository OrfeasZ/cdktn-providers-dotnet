using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.linuxVirtualMachine.LinuxVirtualMachineAdminSshKey")]
    public class LinuxVirtualMachineAdminSshKey : azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdminSshKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#public_key LinuxVirtualMachine#public_key}.</summary>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#username LinuxVirtualMachine#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
