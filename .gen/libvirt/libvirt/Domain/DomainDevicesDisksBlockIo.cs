using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksBlockIo")]
    public class DomainDevicesDisksBlockIo : libvirt.Domain.IDomainDevicesDisksBlockIo
    {
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
