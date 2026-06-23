using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksGeometry), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksGeometry")]
    public interface IDomainDevicesDisksGeometry
    {
        /// <summary>Sets the number of cylinders in the emulated disk geometry as a positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cylinders Domain#cylinders}
        /// </remarks>
        [JsiiProperty(name: "cylinders", typeJson: "{\"primitive\":\"number\"}")]
        double Cylinders
        {
            get;
        }

        /// <summary>Sets the number of heads in the emulated disk geometry as a positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#headers Domain#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"primitive\":\"number\"}")]
        double Headers
        {
            get;
        }

        /// <summary>Sets the number of sectors per track in the emulated disk geometry as a positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sectors Domain#sectors}
        /// </remarks>
        [JsiiProperty(name: "sectors", typeJson: "{\"primitive\":\"number\"}")]
        double Sectors
        {
            get;
        }

        /// <summary>Sets the translation mode for mapping logical CHS geometry to physical layout, with user-provided values such as "auto", "none", or hypervisor-specific modes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#trans Domain#trans}
        /// </remarks>
        [JsiiProperty(name: "trans", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Trans
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksGeometry), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksGeometry")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksGeometry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the number of cylinders in the emulated disk geometry as a positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cylinders Domain#cylinders}
            /// </remarks>
            [JsiiProperty(name: "cylinders", typeJson: "{\"primitive\":\"number\"}")]
            public double Cylinders
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the number of heads in the emulated disk geometry as a positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#headers Domain#headers}
            /// </remarks>
            [JsiiProperty(name: "headers", typeJson: "{\"primitive\":\"number\"}")]
            public double Headers
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the number of sectors per track in the emulated disk geometry as a positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sectors Domain#sectors}
            /// </remarks>
            [JsiiProperty(name: "sectors", typeJson: "{\"primitive\":\"number\"}")]
            public double Sectors
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the translation mode for mapping logical CHS geometry to physical layout, with user-provided values such as "auto", "none", or hypervisor-specific modes.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#trans Domain#trans}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trans", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Trans
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
