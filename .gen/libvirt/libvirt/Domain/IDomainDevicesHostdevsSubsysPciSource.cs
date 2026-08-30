using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysPciSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysPciSource")]
    public interface IDomainDevicesHostdevsSubsysPciSource
    {
        /// <summary>Defines the host PCI address of the device to passthrough, typically via domain, bus, slot, and function (and optional zPCI info on s390x).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciSourceAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysPciSourceAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether write filtering is enabled for a PCI passthrough device, typically to restrict or filter MMIO/PCI configuration writes;</summary>
        /// <remarks>
        /// accepts user-provided value as defined by libvirt (for example "on" or "off").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_filtering Domain#write_filtering}
        /// </remarks>
        [JsiiProperty(name: "writeFiltering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WriteFiltering
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysPciSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysPciSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysPciSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the host PCI address of the device to passthrough, typically via domain, bus, slot, and function (and optional zPCI info on s390x).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciSourceAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysPciSourceAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysPciSourceAddress?>();
            }

            /// <summary>Controls whether write filtering is enabled for a PCI passthrough device, typically to restrict or filter MMIO/PCI configuration writes;</summary>
            /// <remarks>
            /// accepts user-provided value as defined by libvirt (for example "on" or "off").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#write_filtering Domain#write_filtering}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeFiltering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WriteFiltering
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
