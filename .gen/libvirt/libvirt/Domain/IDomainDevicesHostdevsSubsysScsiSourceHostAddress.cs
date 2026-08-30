using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceHostAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHostAddress")]
    public interface IDomainDevicesHostdevsSubsysScsiSourceHostAddress
    {
        /// <summary>Sets the SCSI bus number of the host device to passthrough;</summary>
        /// <remarks>
        /// the value is a user-provided non-negative integer matching the host SCSI topology (e.g. "0").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bus Domain#bus}
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

        /// <summary>Sets the SCSI controller number of the host device to passthrough;</summary>
        /// <remarks>
        /// the value is a user-provided non-negative integer matching the host SCSI topology.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#controller Domain#controller}
        /// </remarks>
        [JsiiProperty(name: "controller", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Controller
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the SCSI target ID on the host bus for the device to be passed through;</summary>
        /// <remarks>
        /// the value is a user-provided non-negative integer (e.g. "0" or "1").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the SCSI LUN/unit number of the host device to passthrough;</summary>
        /// <remarks>
        /// the value is a user-provided non-negative integer matching the host LUN (e.g. "0").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unit Domain#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Unit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceHostAddress), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceHostAddress")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceHostAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SCSI bus number of the host device to passthrough;</summary>
            /// <remarks>
            /// the value is a user-provided non-negative integer matching the host SCSI topology (e.g. "0").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bus Domain#bus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Bus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the SCSI controller number of the host device to passthrough;</summary>
            /// <remarks>
            /// the value is a user-provided non-negative integer matching the host SCSI topology.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#controller Domain#controller}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controller", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Controller
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the SCSI target ID on the host bus for the device to be passed through;</summary>
            /// <remarks>
            /// the value is a user-provided non-negative integer (e.g. "0" or "1").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Target
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the SCSI LUN/unit number of the host device to passthrough;</summary>
            /// <remarks>
            /// the value is a user-provided non-negative integer matching the host LUN (e.g. "0").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#usb-pci-scsi-devices">https://libvirt.org/formatdomain.html#usb-pci-scsi-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unit Domain#unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Unit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
