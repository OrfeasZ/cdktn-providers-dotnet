using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksSourceSlicesSlices), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceSlicesSlices")]
    public interface IDomainDevicesDisksSourceSlicesSlices
    {
        /// <summary>Sets the starting offset (in bytes) of this slice within the underlying backing-store source; must be a non‑negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#offset Domain#offset}
        /// </remarks>
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}")]
        double Offset
        {
            get;
        }

        /// <summary>Sets the size (in bytes) of this slice within the underlying backing-store source; must be a positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Specifies the type of slice mapping to use for this range;</summary>
        /// <remarks>
        /// the value is user‑provided and must match a type supported by the hypervisor (for example, a particular mapping or layout scheme).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksSourceSlicesSlices), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceSlicesSlices")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksSourceSlicesSlices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the starting offset (in bytes) of this slice within the underlying backing-store source; must be a non‑negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#offset Domain#offset}
            /// </remarks>
            [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}")]
            public double Offset
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the size (in bytes) of this slice within the underlying backing-store source; must be a positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size Domain#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Specifies the type of slice mapping to use for this range;</summary>
            /// <remarks>
            /// the value is user‑provided and must match a type supported by the hypervisor (for example, a particular mapping or layout scheme).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
