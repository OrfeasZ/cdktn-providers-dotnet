using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceUdp")]
    public class DomainDevicesInterfacesSourceUdp : libvirt.Domain.IDomainDevicesInterfacesSourceUdp
    {
        /// <summary>Sets the remote UDP endpoint IP address or hostname for the UDP unicast tunnel backing this interface (user-provided address).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#udp-unicast-tunnel">https://libvirt.org/formatdomain.html#udp-unicast-tunnel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Configures the local (listening) endpoint for a UDP tunnel-backed network interface, enabling the guest-side address/port to be fixed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#local Domain#local}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "local", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUdpLocal\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceUdpLocal? Local
        {
            get;
            set;
        }

        /// <summary>Sets the remote UDP port to which the tunnel-backed network interface sends packets;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer (e.g. 5000).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#udp-unicast-tunnel">https://libvirt.org/formatdomain.html#udp-unicast-tunnel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
