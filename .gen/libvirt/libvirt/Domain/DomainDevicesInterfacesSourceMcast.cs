using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceMcast")]
    public class DomainDevicesInterfacesSourceMcast : libvirt.Domain.IDomainDevicesInterfacesSourceMcast
    {
        /// <summary>Sets the remote multicast group IP address that this interface joins for the multicast tunnel (user-provided unicast/multicast address, e.g. 239.x.x.x).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#multicast-tunnel">https://libvirt.org/formatdomain.html#multicast-tunnel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#local Domain#local}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "local", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceMcastLocal\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceMcastLocal? Local
        {
            get;
            set;
        }

        /// <summary>Sets the remote UDP port used for the multicast tunnel (user-provided integer port number, e.g. 5000).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#multicast-tunnel">https://libvirt.org/formatdomain.html#multicast-tunnel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
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
