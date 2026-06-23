using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesVideosModel), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosModel")]
    public interface IDomainDevicesVideosModel
    {
        /// <summary>Configures hardware acceleration options for the video model, enabling or disabling 2D/3D acceleration if supported by the chosen model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#accel Domain#accel}
        /// </remarks>
        [JsiiProperty(name: "accel", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelAccel\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesVideosModelAccel? Accel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the video device exposes a framebuffer "blob" resource to the guest; accepts "on" or "off" where supported.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#blob Domain#blob}
        /// </remarks>
        [JsiiProperty(name: "blob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Blob
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether an EDID block is exposed to the guest display for this video device; accepts "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#edid Domain#edid}
        /// </remarks>
        [JsiiProperty(name: "edid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Edid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of display heads (monitors) exposed by this video device model; expects a positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#heads Domain#heads}
        /// </remarks>
        [JsiiProperty(name: "heads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Heads
        {
            get
            {
                return null;
            }
        }

        /// <summary>Marks this video device as the primary adapter when set to "yes" and as non-primary when set to "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#primary Domain#primary}
        /// </remarks>
        [JsiiProperty(name: "primary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Primary
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the amount of RAM (in KiB) assigned to the video device, controlling the total memory available to the model;</summary>
        /// <remarks>
        /// expects a non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ram Domain#ram}
        /// </remarks>
        [JsiiProperty(name: "ram", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ram
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a fixed default resolution for the video device via its x and y dimensions;</summary>
        /// <remarks>
        /// only effective when both coordinates are provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#resolution Domain#resolution}
        /// </remarks>
        [JsiiProperty(name: "resolution", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelResolution\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesVideosModelResolution? Resolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the emulated video card model (for example "vga", "qxl", "virtio");</summary>
        /// <remarks>
        /// the value is user-provided and passed through to the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the amount of legacy VGA memory (in KiB) exposed by the adapter (vgamem); expects a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vga_mem Domain#vga_mem}
        /// </remarks>
        [JsiiProperty(name: "vgaMem", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VgaMem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the amount of video RAM (in KiB) exposed to the guest for this adapter; expects a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vram Domain#vram}
        /// </remarks>
        [JsiiProperty(name: "vram", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vram
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the additional 64-bit-accessible video RAM (in KiB) for this adapter where supported; expects a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vram64 Domain#vram64}
        /// </remarks>
        [JsiiProperty(name: "vram64", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vram64
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesVideosModel), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosModel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesVideosModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures hardware acceleration options for the video model, enabling or disabling 2D/3D acceleration if supported by the chosen model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#accel Domain#accel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accel", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelAccel\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesVideosModelAccel? Accel
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesVideosModelAccel?>();
            }

            /// <summary>Controls whether the video device exposes a framebuffer "blob" resource to the guest; accepts "on" or "off" where supported.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#blob Domain#blob}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Blob
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether an EDID block is exposed to the guest display for this video device; accepts "on" or "off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#edid Domain#edid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "edid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Edid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the number of display heads (monitors) exposed by this video device model; expects a positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#heads Domain#heads}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "heads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Heads
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Marks this video device as the primary adapter when set to "yes" and as non-primary when set to "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#primary Domain#primary}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "primary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Primary
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the amount of RAM (in KiB) assigned to the video device, controlling the total memory available to the model;</summary>
            /// <remarks>
            /// expects a non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ram Domain#ram}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ram", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ram
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures a fixed default resolution for the video device via its x and y dimensions;</summary>
            /// <remarks>
            /// only effective when both coordinates are provided.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#resolution Domain#resolution}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resolution", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVideosModelResolution\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesVideosModelResolution? Resolution
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesVideosModelResolution?>();
            }

            /// <summary>Selects the emulated video card model (for example "vga", "qxl", "virtio");</summary>
            /// <remarks>
            /// the value is user-provided and passed through to the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the amount of legacy VGA memory (in KiB) exposed by the adapter (vgamem); expects a non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vga_mem Domain#vga_mem}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vgaMem", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VgaMem
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the amount of video RAM (in KiB) exposed to the guest for this adapter; expects a non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vram Domain#vram}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vram", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vram
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the additional 64-bit-accessible video RAM (in KiB) for this adapter where supported; expects a non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vram64 Domain#vram64}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vram64", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vram64
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
