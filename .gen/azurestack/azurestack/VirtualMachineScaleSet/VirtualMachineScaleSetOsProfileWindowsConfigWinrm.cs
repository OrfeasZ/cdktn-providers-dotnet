using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigWinrm")]
    public class VirtualMachineScaleSetOsProfileWindowsConfigWinrm : azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfigWinrm
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#protocol VirtualMachineScaleSet#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#certificate_url VirtualMachineScaleSet#certificate_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateUrl
        {
            get;
            set;
        }
    }
}
