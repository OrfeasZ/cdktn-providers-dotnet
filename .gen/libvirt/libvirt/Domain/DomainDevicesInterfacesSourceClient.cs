using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceClient")]
    public class DomainDevicesInterfacesSourceClient : libvirt.Domain.IDomainDevicesInterfacesSourceClient
    {
        /// <summary>Sets the remote peer’s IP or hostname for the tunnel client connection (user-provided, e.g. "10.0.0.1" or "example.com").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#tcp-tunnel">https://libvirt.org/formatdomain.html#tcp-tunnel</a>
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
        [JsiiProperty(name: "local", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceClientLocal\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceClientLocal? Local
        {
            get;
            set;
        }

        /// <summary>Sets the remote port number for the tunnel’s client connection, as a decimal TCP or UDP port (for example, 1194).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#tcp-tunnel">https://libvirt.org/formatdomain.html#tcp-tunnel</a>
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
