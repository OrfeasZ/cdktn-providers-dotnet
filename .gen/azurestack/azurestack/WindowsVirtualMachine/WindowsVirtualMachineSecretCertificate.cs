using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.windowsVirtualMachine.WindowsVirtualMachineSecretCertificate")]
    public class WindowsVirtualMachineSecretCertificate : azurestack.WindowsVirtualMachine.IWindowsVirtualMachineSecretCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine#store WindowsVirtualMachine#store}.</summary>
        [JsiiProperty(name: "store", typeJson: "{\"primitive\":\"string\"}")]
        public string Store
        {
            get;
            set;
        }
    }
}
