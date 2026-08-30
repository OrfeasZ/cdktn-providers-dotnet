using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesVideosDriver")]
    public class DomainDevicesVideosDriver : libvirt.Domain.IDomainDevicesVideosDriver
    {
        /// <summary>Controls the virtio Address Translation Service (ATS) feature for the video device when using an emulated IOMMU;</summary>
        /// <remarks>
        /// values are typically <c>on</c> or <c>off</c>.
        ///
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

        /// <summary>Enables or disables the use of an emulated IOMMU for the video device;</summary>
        /// <remarks>
        /// values are typically <c>on</c> or <c>off</c> and require a matching IOMMU device configuration.
        ///
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

        /// <summary>Sets a driver name or variant for the video device;</summary>
        /// <remarks>
        /// the value is user‑provided and specific to the selected video model and hypervisor support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
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

        /// <summary>Controls whether the virtio device uses packed virtqueue format instead of split queues; values are typically `on` or `off`.</summary>
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

        /// <summary>Controls whether each virtqueue of the device gets its own memory page (page-per-vq optimization);</summary>
        /// <remarks>
        /// values are typically <c>on</c> or <c>off</c>.
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

        /// <summary>Sets the VGA configuration policy for the video device via the `vgaconf` option (for example `on`, `off`, or `io`), controlling legacy VGA behavior;</summary>
        /// <remarks>
        /// the exact accepted values are hypervisor-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vga_conf Domain#vga_conf}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vgaConf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VgaConf
        {
            get;
            set;
        }
    }
}
