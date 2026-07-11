using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics")]
    public class WindowsVirtualMachineScaleSetBootDiagnostics : azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#storage_account_uri WindowsVirtualMachineScaleSet#storage_account_uri}.</summary>
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountUri
        {
            get;
            set;
        }
    }
}
