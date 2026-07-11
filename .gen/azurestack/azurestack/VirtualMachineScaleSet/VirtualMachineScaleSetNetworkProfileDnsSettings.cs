using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileDnsSettings")]
    public class VirtualMachineScaleSetNetworkProfileDnsSettings : azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfileDnsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#dns_servers VirtualMachineScaleSet#dns_servers}.</summary>
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DnsServers
        {
            get;
            set;
        }
    }
}
