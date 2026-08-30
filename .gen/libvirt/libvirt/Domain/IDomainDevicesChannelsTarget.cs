using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesChannelsTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsTarget")]
    public interface IDomainDevicesChannelsTarget
    {
        /// <summary>Configures a guestfwd-style channel target that forwards guest TCP connections to a host-side TCP endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#guest_fwd Domain#guest_fwd}
        /// </remarks>
        [JsiiProperty(name: "guestFwd", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetGuestFwd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesChannelsTargetGuestFwd? GuestFwd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a virtio-based channel target, making the channel visible as a virtio-serial device in the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#virt_io Domain#virt_io}
        /// </remarks>
        [JsiiProperty(name: "virtIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetVirtIo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesChannelsTargetVirtIo? VirtIo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a Xen-style channel target, exposing the channel via the Xen guest interface mechanism.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xen Domain#xen}
        /// </remarks>
        [JsiiProperty(name: "xen", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetXen\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesChannelsTargetXen? Xen
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesChannelsTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsTarget")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesChannelsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures a guestfwd-style channel target that forwards guest TCP connections to a host-side TCP endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#guest_fwd Domain#guest_fwd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guestFwd", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetGuestFwd\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesChannelsTargetGuestFwd? GuestFwd
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesChannelsTargetGuestFwd?>();
            }

            /// <summary>Configures a virtio-based channel target, making the channel visible as a virtio-serial device in the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#virt_io Domain#virt_io}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetVirtIo\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesChannelsTargetVirtIo? VirtIo
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesChannelsTargetVirtIo?>();
            }

            /// <summary>Configures a Xen-style channel target, exposing the channel via the Xen guest interface mechanism.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xen Domain#xen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xen", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetXen\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesChannelsTargetXen? Xen
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesChannelsTargetXen?>();
            }
        }
    }
}
