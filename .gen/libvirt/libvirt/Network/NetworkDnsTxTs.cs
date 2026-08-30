using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.network.NetworkDnsTxTs")]
    public class NetworkDnsTxTs : libvirt.Network.INetworkDnsTxTs
    {
        /// <summary>Sets the DNS TXT record name advertised by the virtual network’s built‑in DNS server;</summary>
        /// <remarks>
        /// the value is user‑provided (for example, a hostname or arbitrary label).
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#name Network#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Sets the DNS TXT record value string returned for the given TXT record name;</summary>
        /// <remarks>
        /// the value is user‑provided and may contain any text permitted by DNS TXT records.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#value Network#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
