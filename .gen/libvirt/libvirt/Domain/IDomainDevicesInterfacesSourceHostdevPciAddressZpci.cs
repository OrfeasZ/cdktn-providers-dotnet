using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceHostdevPciAddressZpci), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressZpci")]
    public interface IDomainDevicesInterfacesSourceHostdevPciAddressZpci
    {
        /// <summary>Sets the function ID (fid) for a zPCI device on s390x, identifying the specific zPCI function to passthrough;</summary>
        /// <remarks>
        /// the value is user-provided and must match the host's zPCI configuration.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#fid Domain#fid}
        /// </remarks>
        [JsiiProperty(name: "fid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Fid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the zPCI function UID for a passed-through PCI device on s390x, identifying the zPCI function within the guest;</summary>
        /// <remarks>
        /// the value is user-provided and must match the host zPCI configuration.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#uid Domain#uid}
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Uid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceHostdevPciAddressZpci), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressZpci")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddressZpci
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the function ID (fid) for a zPCI device on s390x, identifying the specific zPCI function to passthrough;</summary>
            /// <remarks>
            /// the value is user-provided and must match the host's zPCI configuration.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#device-addresses">https://libvirt.org/formatdomain.html#device-addresses</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#fid Domain#fid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Fid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the zPCI function UID for a passed-through PCI device on s390x, identifying the zPCI function within the guest;</summary>
            /// <remarks>
            /// the value is user-provided and must match the host zPCI configuration.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#uid Domain#uid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Uid
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
