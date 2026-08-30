using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesVideosDriver), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosDriver")]
    public interface IDomainDevicesVideosDriver
    {
        /// <summary>Controls the virtio Address Translation Service (ATS) feature for the video device when using an emulated IOMMU;</summary>
        /// <remarks>
        /// values are typically <c>on</c> or <c>off</c>.
        ///
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

        /// <summary>Enables or disables the use of an emulated IOMMU for the video device;</summary>
        /// <remarks>
        /// values are typically <c>on</c> or <c>off</c> and require a matching IOMMU device configuration.
        ///
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

        /// <summary>Sets a driver name or variant for the video device;</summary>
        /// <remarks>
        /// the value is user‑provided and specific to the selected video model and hypervisor support.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the virtio device uses packed virtqueue format instead of split queues; values are typically `on` or `off`.</summary>
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

        /// <summary>Controls whether each virtqueue of the device gets its own memory page (page-per-vq optimization);</summary>
        /// <remarks>
        /// values are typically <c>on</c> or <c>off</c>.
        ///
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

        /// <summary>Sets the VGA configuration policy for the video device via the `vgaconf` option (for example `on`, `off`, or `io`), controlling legacy VGA behavior;</summary>
        /// <remarks>
        /// the exact accepted values are hypervisor-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vga_conf Domain#vga_conf}
        /// </remarks>
        [JsiiProperty(name: "vgaConf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VgaConf
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesVideosDriver), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosDriver")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesVideosDriver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
