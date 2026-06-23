using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceHostdevUsb), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevUsb")]
    public interface IDomainDevicesInterfacesSourceHostdevUsb
    {
        /// <summary>Specifies the physical USB topology of the host device (bus, device, and/or port) used to select which USB device is passed through.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether a reset is issued to the USB device when it is assigned or re-assigned to the guest;</summary>
        /// <remarks>
        /// value is user-provided (typically <c>on</c>/<c>off</c> or <c>yes</c>/<c>no</c> depending on libvirt version).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#guest_reset Domain#guest_reset}
        /// </remarks>
        [JsiiProperty(name: "guestReset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GuestReset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a USB device for passthrough by its vendor ID, typically used together with `source.product`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#product Domain#product}
        /// </remarks>
        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbProduct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbProduct? Product
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets how strictly libvirt enforces the presence of the USB device at startup;</summary>
        /// <remarks>
        /// accepts values like <c>mandatory</c>, <c>requisite</c>, or <c>optional</c> depending on libvirt support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#start_up_policy Domain#start_up_policy}
        /// </remarks>
        [JsiiProperty(name: "startUpPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartUpPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a USB device for passthrough by its vendor ID, typically used together with `source.product`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vendor Domain#vendor}
        /// </remarks>
        [JsiiProperty(name: "vendor", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbVendor\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbVendor? Vendor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceHostdevUsb), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevUsb")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the physical USB topology of the host device (bus, device, and/or port) used to select which USB device is passed through.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbAddress?>();
            }

            /// <summary>Controls whether a reset is issued to the USB device when it is assigned or re-assigned to the guest;</summary>
            /// <remarks>
            /// value is user-provided (typically <c>on</c>/<c>off</c> or <c>yes</c>/<c>no</c> depending on libvirt version).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#guest_reset Domain#guest_reset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guestReset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuestReset
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects a USB device for passthrough by its vendor ID, typically used together with `source.product`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#product Domain#product}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbProduct\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbProduct? Product
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbProduct?>();
            }

            /// <summary>Sets how strictly libvirt enforces the presence of the USB device at startup;</summary>
            /// <remarks>
            /// accepts values like <c>mandatory</c>, <c>requisite</c>, or <c>optional</c> depending on libvirt support.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#start_up_policy Domain#start_up_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startUpPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartUpPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects a USB device for passthrough by its vendor ID, typically used together with `source.product`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vendor Domain#vendor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vendor", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbVendor\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbVendor? Vendor
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbVendor?>();
            }
        }
    }
}
