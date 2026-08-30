using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInputsDriver), fullyQualifiedName: "libvirt.domain.DomainDevicesInputsDriver")]
    public interface IDomainDevicesInputsDriver
    {
        /// <summary>Enables or disables Address Translation Services (ATS) for a virtio input device, using "on" or "off" when the device is behind an emulated IOMMU.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ats Domain#ats}
        /// </remarks>
        [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ats
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables use of an emulated IOMMU for this virtio input device, typically with "on" or "off" when integrating with a guest IOMMU.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iommu Domain#iommu}
        /// </remarks>
        [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Iommu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Toggles use of packed virtqueue format for this virtio input device, usually set to "on" or "off" to match guest driver capabilities.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#packed Domain#packed}
        /// </remarks>
        [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Packed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether each virtqueue of this virtio input device uses a separate page-table mapping, typically "on" or "off" for fine‑grained IOMMU mapping.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#page_per_vq Domain#page_per_vq}
        /// </remarks>
        [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PagePerVq
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInputsDriver), fullyQualifiedName: "libvirt.domain.DomainDevicesInputsDriver")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInputsDriver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables or disables Address Translation Services (ATS) for a virtio input device, using "on" or "off" when the device is behind an emulated IOMMU.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ats Domain#ats}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ats", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ats
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables or disables use of an emulated IOMMU for this virtio input device, typically with "on" or "off" when integrating with a guest IOMMU.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iommu Domain#iommu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iommu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Iommu
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Toggles use of packed virtqueue format for this virtio input device, usually set to "on" or "off" to match guest driver capabilities.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#packed Domain#packed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "packed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Packed
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether each virtqueue of this virtio input device uses a separate page-table mapping, typically "on" or "off" for fine‑grained IOMMU mapping.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtio-related-options">https://libvirt.org/formatdomain.html#virtio-related-options</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#page_per_vq Domain#page_per_vq}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pagePerVq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PagePerVq
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
