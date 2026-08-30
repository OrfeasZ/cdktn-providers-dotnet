using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceServer")]
    public class DomainDevicesInterfacesSourceServer : libvirt.Domain.IDomainDevicesInterfacesSourceServer
    {
        /// <summary>Sets the remote or local TCP IP address for the TCP-tunnel server endpoint backing this interface (user-provided IP or hostname).</summary>
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
        [JsiiProperty(name: "local", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceServerLocal\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceServerLocal? Local
        {
            get;
            set;
        }

        /// <summary>Sets the remote or listening TCP port used for the TCP tunnel backing this interface (user-provided integer port).</summary>
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
