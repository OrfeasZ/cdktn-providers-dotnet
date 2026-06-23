using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceHostdevUsbAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbAddress")]
    public interface IDomainDevicesInterfacesSourceHostdevUsbAddress
    {
        /// <summary>Sets the numeric USB bus on the host where the device is attached;</summary>
        /// <remarks>
        /// value is user-provided as reported by tools like <c>lsusb</c> (for example, <c>1</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bus Domain#bus}
        /// </remarks>
        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Bus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the numeric USB device number on the selected bus;</summary>
        /// <remarks>
        /// value is user-provided based on host enumeration (for example, <c>2</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
        /// </remarks>
        [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Device
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the USB port path on the host (often a dot‑separated string like `1` or `1.2`) to identify the device by its hub/port topology.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceHostdevUsbAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbAddress")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the numeric USB bus on the host where the device is attached;</summary>
            /// <remarks>
            /// value is user-provided as reported by tools like <c>lsusb</c> (for example, <c>1</c>).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bus Domain#bus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Bus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the numeric USB device number on the selected bus;</summary>
            /// <remarks>
            /// value is user-provided based on host enumeration (for example, <c>2</c>).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Device
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the USB port path on the host (often a dot‑separated string like `1` or `1.2`) to identify the device by its hub/port topology.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Port
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
