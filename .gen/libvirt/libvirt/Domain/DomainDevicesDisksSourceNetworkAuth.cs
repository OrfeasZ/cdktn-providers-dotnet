using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksSourceNetworkAuth")]
    public class DomainDevicesDisksSourceNetworkAuth : libvirt.Domain.IDomainDevicesDisksSourceNetworkAuth
    {
        /// <summary>Configures the libvirt secret object used to hold the iSCSI authentication password for this hostdev;</summary>
        /// <remarks>
        /// this references an existing libvirt secret, not the clear-text secret.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#secret Domain#secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkAuthSecret\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesDisksSourceNetworkAuthSecret? Secret
        {
            get;
            set;
        }

        /// <summary>Sets the CHAP username used when authenticating to the iSCSI target for this SCSI hostdev;</summary>
        /// <remarks>
        /// the value is user-provided (for example, "chapuser1").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#username Domain#username}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
