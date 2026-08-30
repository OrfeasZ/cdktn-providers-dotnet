using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksBlockIo), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBlockIo")]
    public interface IDomainDevicesDisksBlockIo
    {
        /// <summary>Sets the discard (TRIM/UNMAP) granularity in bytes for this disk as seen by the guest;</summary>
        /// <remarks>
        /// the value is a user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#discard_granularity Domain#discard_granularity}
        /// </remarks>
        [JsiiProperty(name: "discardGranularity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiscardGranularity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the logical block size in bytes that the guest sees for this disk;</summary>
        /// <remarks>
        /// the value is a user-provided positive integer, commonly 512 or 4096.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#logical_block_size Domain#logical_block_size}
        /// </remarks>
        [JsiiProperty(name: "logicalBlockSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LogicalBlockSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the physical block size in bytes that the guest sees for this disk, typically matching the underlying storage’s hardware sector size;</summary>
        /// <remarks>
        /// the value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#physical_block_size Domain#physical_block_size}
        /// </remarks>
        [JsiiProperty(name: "physicalBlockSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PhysicalBlockSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksBlockIo), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBlockIo")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksBlockIo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the discard (TRIM/UNMAP) granularity in bytes for this disk as seen by the guest;</summary>
            /// <remarks>
            /// the value is a user-provided non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#discard_granularity Domain#discard_granularity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discardGranularity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiscardGranularity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the logical block size in bytes that the guest sees for this disk;</summary>
            /// <remarks>
            /// the value is a user-provided positive integer, commonly 512 or 4096.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#logical_block_size Domain#logical_block_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logicalBlockSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LogicalBlockSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the physical block size in bytes that the guest sees for this disk, typically matching the underlying storage’s hardware sector size;</summary>
            /// <remarks>
            /// the value is a user-provided positive integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#physical_block_size Domain#physical_block_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "physicalBlockSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PhysicalBlockSize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
