using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetNetworkProfileDnsSettings), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileDnsSettings")]
    public interface IVirtualMachineScaleSetNetworkProfileDnsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#dns_servers VirtualMachineScaleSet#dns_servers}.</summary>
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsServers
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetNetworkProfileDnsSettings), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileDnsSettings")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfileDnsSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#dns_servers VirtualMachineScaleSet#dns_servers}.</summary>
            [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsServers
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
