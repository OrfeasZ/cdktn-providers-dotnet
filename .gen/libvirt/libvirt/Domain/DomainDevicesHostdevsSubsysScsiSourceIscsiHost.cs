using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiHost")]
    public class DomainDevicesHostdevsSubsysScsiSourceIscsiHost : libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiHost
    {
        /// <summary>Sets the hostname or IP address of the iSCSI target portal (for example, "10.0.0.10" or "iscsi.example.com").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Sets the TCP port of the iSCSI target portal; if omitted, libvirt/driver defaults (commonly 3260) are used.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Port
        {
            get;
            set;
        }

        /// <summary>Sets a UNIX domain socket path to connect to an iSCSI target via a local socket instead of TCP;</summary>
        /// <remarks>
        /// value is a user-provided filesystem path.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#socket Domain#socket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "socket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Socket
        {
            get;
            set;
        }

        /// <summary>Sets the transport type used to reach the iSCSI target portal;</summary>
        /// <remarks>
        /// valid values are user-provided strings as supported by the environment (for example, "tcp" or "iser").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#transport Domain#transport}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Transport
        {
            get;
            set;
        }
    }
}
