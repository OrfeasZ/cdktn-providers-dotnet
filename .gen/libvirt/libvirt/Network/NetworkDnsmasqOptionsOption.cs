using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.network.NetworkDnsmasqOptionsOption")]
    public class NetworkDnsmasqOptionsOption : libvirt.Network.INetworkDnsmasqOptionsOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#value Network#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
