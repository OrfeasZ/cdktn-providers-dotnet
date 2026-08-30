using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesIommUsDriver")]
    public class DomainDevicesIommUsDriver : libvirt.Domain.IDomainDevicesIommUsDriver
    {
        /// <summary>Sets the IOMMU address width in bits (aw_bits) used for DMA mappings;</summary>
        /// <remarks>
        /// value is a positive integer appropriate to the chosen IOMMU model (for example, 39 or 48).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#aw_bits Domain#aw_bits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awBits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AwBits
        {
            get;
            set;
        }

        /// <summary>Enables or disables IOMMU page table caching mode, with valid values "on" or "off" (presence controls whether the device advertises caching to the guest).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#caching_mode Domain#caching_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cachingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CachingMode
        {
            get;
            set;
        }

        /// <summary>Controls whether DMA translation is performed by the IOMMU, with valid values "on" or "off" (for example, "off" can approximate passthrough behavior).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dma_translation Domain#dma_translation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dmaTranslation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DmaTranslation
        {
            get;
            set;
        }

        /// <summary>Toggles extended interrupt mode (EIM) support for the IOMMU, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#eim Domain#eim}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Eim
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#granule Domain#granule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "granule", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommUsDriverGranule\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesIommUsDriverGranule? Granule
        {
            get;
            set;
        }

        /// <summary>Enables or disables interrupt remapping for the IOMMU, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#int_remap Domain#int_remap}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intRemap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IntRemap
        {
            get;
            set;
        }

        /// <summary>Controls whether the IOMMU exposes an IOTLB (I/O TLB) interface to the guest, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iotlb Domain#iotlb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iotlb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Iotlb
        {
            get;
            set;
        }

        /// <summary>Selects passthrough mode for the IOMMU so that guest devices can bypass translation, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passthrough", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Passthrough
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pci_bus Domain#pci_bus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pciBus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PciBus
        {
            get;
            set;
        }

        /// <summary>Toggles support for extended translation (xtsup) features of the IOMMU, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xt_sup Domain#xt_sup}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xtSup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? XtSup
        {
            get;
            set;
        }
    }
}
