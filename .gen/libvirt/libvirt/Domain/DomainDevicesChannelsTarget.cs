using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesChannelsTarget")]
    public class DomainDevicesChannelsTarget : libvirt.Domain.IDomainDevicesChannelsTarget
    {
        /// <summary>Configures a guestfwd-style channel target that forwards guest TCP connections to a host-side TCP endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#guest_fwd Domain#guest_fwd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guestFwd", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetGuestFwd\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesChannelsTargetGuestFwd? GuestFwd
        {
            get;
            set;
        }

        /// <summary>Configures a virtio-based channel target, making the channel visible as a virtio-serial device in the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#virt_io Domain#virt_io}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetVirtIo\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesChannelsTargetVirtIo? VirtIo
        {
            get;
            set;
        }

        /// <summary>Configures a Xen-style channel target, exposing the channel via the Xen guest interface mechanism.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xen Domain#xen}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xen", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetXen\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesChannelsTargetXen? Xen
        {
            get;
            set;
        }
    }
}
