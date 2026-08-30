using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysUsbSourceVendor), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceVendor")]
    public interface IDomainDevicesHostdevsSubsysUsbSourceVendor
    {
        /// <summary>Reports or sets the USB vendor ID (a 4‑digit hexadecimal string like `0x046d`) used to match the device;</summary>
        /// <remarks>
        /// when computed, it is derived from the host device metadata.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysUsbSourceVendor), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceVendor")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceVendor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Reports or sets the USB vendor ID (a 4‑digit hexadecimal string like `0x046d`) used to match the device;</summary>
            /// <remarks>
            /// when computed, it is derived from the host device metadata.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
