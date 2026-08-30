using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsDriver")]
    public class DomainDevicesFilesystemsDriver : libvirt.Domain.IDomainDevicesFilesystemsDriver
    {
        /// <summary>Enables or disables Address Translation Service for a virtio-based filesystem device; valid values are "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ats Domain#ats}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ats
        {
            get;
            set;
        }

        /// <summary>Sets an optional driver-specific format identifier for the filesystem backend;</summary>
        /// <remarks>
        /// the value is user-provided and depends on the underlying driver.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }

        /// <summary>Enables or disables use of an emulated IOMMU for the virtio filesystem device; valid values are "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iommu Domain#iommu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Iommu
        {
            get;
            set;
        }

        /// <summary>Sets the backend driver name for the filesystem device (for example a specific virtiofs or 9p implementation);</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Enables or disables virtio packed ring layout for the filesystem device; valid values are "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#packed Domain#packed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Packed
        {
            get;
            set;
        }

        /// <summary>Enables or disables use of a separate notification page per virtqueue for the virtio filesystem device;</summary>
        /// <remarks>
        /// valid values are "on" or "off".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#page_per_vq Domain#page_per_vq}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PagePerVq
        {
            get;
            set;
        }

        /// <summary>Sets a driver-specific queue-related parameter (such as number or size of queues) for the filesystem device;</summary>
        /// <remarks>
        /// the value is user-provided and must be a non-negative integer when used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queue Domain#queue}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Queue
        {
            get;
            set;
        }

        /// <summary>Selects the filesystem driver type, such as "virtiofs" or "path", determining how the host directory is exposed to the guest;</summary>
        /// <remarks>
        /// the exact valid values are driver-dependent.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Sets the write policy for the filesystem backend (for example "immediate" or "delayed") controlling how writes are flushed to host storage;</summary>
        /// <remarks>
        /// the value is user-provided and driver-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wr_policy Domain#wr_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wrPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WrPolicy
        {
            get;
            set;
        }
    }
}
