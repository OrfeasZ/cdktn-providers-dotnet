using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkDomain")]
    public class NetworkDomain : libvirt.Network.INetworkDomain
    {
        /// <summary>Controls whether the network domain is used only for local name resolution inside libvirt’s DNS (\"yes\" for local-only, \"no\" to allow external registration), with the value stored as a string flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#local_only Network#local_only}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalOnly
        {
            get;
            set;
        }

        /// <summary>Sets the DNS domain name associated with this virtual network (for example, \"virt.example.com\") that is appended to hostnames and exposed via DHCP/DNS.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#name Network#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
