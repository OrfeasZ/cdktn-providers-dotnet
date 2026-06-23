using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesSmartcardsPassthroughUdp")]
    public class DomainDevicesSmartcardsPassthroughUdp : libvirt.Domain.IDomainDevicesSmartcardsPassthroughUdp
    {
        /// <summary>Sets the local host address or hostname to which the UDP socket for the EGD entropy source binds;</summary>
        /// <remarks>
        /// the value is user-provided (for example, "0.0.0.0" or "::").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bind_host Domain#bind_host}
        /// </remarks>
        [JsiiProperty(name: "bindHost", typeJson: "{\"primitive\":\"string\"}")]
        public string BindHost
        {
            get;
            set;
        }

        /// <summary>Sets the local UDP port or service name to which the EGD entropy source binds;</summary>
        /// <remarks>
        /// the value is a user-provided port or service string (for example, "7040").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bind_service Domain#bind_service}
        /// </remarks>
        [JsiiProperty(name: "bindService", typeJson: "{\"primitive\":\"string\"}")]
        public string BindService
        {
            get;
            set;
        }

        /// <summary>Sets the remote host address or hostname that the UDP-based EGD entropy source sends packets to;</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#connect_host Domain#connect_host}
        /// </remarks>
        [JsiiProperty(name: "connectHost", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectHost
        {
            get;
            set;
        }

        /// <summary>Sets the remote UDP port or service name for the EGD entropy sink;</summary>
        /// <remarks>
        /// the value is a user-provided port or service string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#connect_service Domain#connect_service}
        /// </remarks>
        [JsiiProperty(name: "connectService", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectService
        {
            get;
            set;
        }
    }
}
