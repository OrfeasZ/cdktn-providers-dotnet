using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkDnsForwarders")]
    public class NetworkDnsForwarders : libvirt.Network.INetworkDnsForwarders
    {
        /// <summary>Sets the IP address of an upstream DNS forwarder.</summary>
        /// <remarks>
        /// The value is user-provided and should be a valid IPv4 or IPv6 address (e.g. "8.8.8.8" or "2001:4860:4860::8888").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#addr Network#addr}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Addr
        {
            get;
            set;
        }

        /// <summary>Restricts the forwarder to queries for a specific DNS domain suffix.</summary>
        /// <remarks>
        /// The value is user-provided and should be a valid DNS domain (e.g. "example.com").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#domain Network#domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#port Network#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
