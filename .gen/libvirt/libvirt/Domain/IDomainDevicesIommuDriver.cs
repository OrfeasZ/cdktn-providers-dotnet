using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesIommuDriver), fullyQualifiedName: "libvirt.domain.DomainDevicesIommuDriver")]
    public interface IDomainDevicesIommuDriver
    {
        /// <summary>Sets the IOMMU address width in bits (aw_bits) used for DMA mappings;</summary>
        /// <remarks>
        /// value is a positive integer appropriate to the chosen IOMMU model (for example, 39 or 48).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#aw_bits Domain#aw_bits}
        /// </remarks>
        [JsiiProperty(name: "awBits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AwBits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables IOMMU page table caching mode, with valid values "on" or "off" (presence controls whether the device advertises caching to the guest).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#caching_mode Domain#caching_mode}
        /// </remarks>
        [JsiiProperty(name: "cachingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CachingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether DMA translation is performed by the IOMMU, with valid values "on" or "off" (for example, "off" can approximate passthrough behavior).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dma_translation Domain#dma_translation}
        /// </remarks>
        [JsiiProperty(name: "dmaTranslation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DmaTranslation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Toggles extended interrupt mode (EIM) support for the IOMMU, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#eim Domain#eim}
        /// </remarks>
        [JsiiProperty(name: "eim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Eim
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#granule Domain#granule}.</summary>
        [JsiiProperty(name: "granule", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommuDriverGranule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesIommuDriverGranule? Granule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables interrupt remapping for the IOMMU, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#int_remap Domain#int_remap}
        /// </remarks>
        [JsiiProperty(name: "intRemap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntRemap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the IOMMU exposes an IOTLB (I/O TLB) interface to the guest, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iotlb Domain#iotlb}
        /// </remarks>
        [JsiiProperty(name: "iotlb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Iotlb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects passthrough mode for the IOMMU so that guest devices can bypass translation, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiProperty(name: "passthrough", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Passthrough
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pci_bus Domain#pci_bus}.</summary>
        [JsiiProperty(name: "pciBus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PciBus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Toggles support for extended translation (xtsup) features of the IOMMU, with valid values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#iommu-devices">https://libvirt.org/formatdomain.html#iommu-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xt_sup Domain#xt_sup}
        /// </remarks>
        [JsiiProperty(name: "xtSup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? XtSup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesIommuDriver), fullyQualifiedName: "libvirt.domain.DomainDevicesIommuDriver")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesIommuDriver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#granule Domain#granule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "granule", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommuDriverGranule\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesIommuDriverGranule? Granule
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesIommuDriverGranule?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pci_bus Domain#pci_bus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pciBus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PciBus
            {
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
