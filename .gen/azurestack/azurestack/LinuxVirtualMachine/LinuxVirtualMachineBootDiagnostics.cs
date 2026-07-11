using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics")]
    public class LinuxVirtualMachineBootDiagnostics : azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#storage_account_uri LinuxVirtualMachine#storage_account_uri}.</summary>
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountUri
        {
            get;
            set;
        }
    }
}
