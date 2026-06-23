using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRngsDriver")]
    public class DomainDevicesRngsDriver : libvirt.Domain.IDomainDevicesRngsDriver
    {
        /// <summary>Enables or disables address translation services (ATS) for the virtio RNG device when used behind an emulated IOMMU;</summary>
        /// <remarks>
        /// accepts "on" or "off".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ats Domain#ats}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ats
        {
            get;
            set;
        }

        /// <summary>Enables or disables use of the emulated IOMMU for the virtio RNG device; accepts "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#iommu Domain#iommu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Iommu
        {
            get;
            set;
        }

        /// <summary>Enables or disables the packed virtqueue layout for the virtio RNG device; accepts "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#packed Domain#packed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Packed
        {
            get;
            set;
        }

        /// <summary>Controls whether each virtqueue of the virtio RNG device uses a dedicated page, which can improve isolation at the cost of memory;</summary>
        /// <remarks>
        /// accepts "on" or "off".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#page_per_vq Domain#page_per_vq}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PagePerVq
        {
            get;
            set;
        }
    }
}
