using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosOss), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosOss")]
    public interface IDomainDevicesAudiosOss
    {
        /// <summary>Configures the OSS backend DSP scheduling policy used for the guest audio device;</summary>
        /// <remarks>
        /// the value is user-provided and passed through to the OSS layer (for example, an integer priority or policy code as expected by the host OSS implementation).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dsp_policy Domain#dsp_policy}
        /// </remarks>
        [JsiiProperty(name: "dspPolicy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DspPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the OSS backend opens the host audio device in exclusive mode, typically as a yes/no boolean string accepted by QEMU (for example, "on"/"off" or "yes"/"no").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#exclusive Domain#exclusive}
        /// </remarks>
        [JsiiProperty(name: "exclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exclusive
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures the OSS audio output (playback) stream for the guest;</summary>
        /// <remarks>
        /// presence of this block turns on playback via OSS with the specified attributes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosOssInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures the OSS audio output (playback) stream for the guest;</summary>
        /// <remarks>
        /// presence of this block turns on playback via OSS with the specified attributes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosOssOutput? Output
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the OSS backend attempts to use mmap(2)-based data transfer to the host OSS device, typically as a yes/no boolean string accepted by QEMU.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#try_m_map Domain#try_m_map}
        /// </remarks>
        [JsiiProperty(name: "tryMMap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TryMMap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosOss), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosOss")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosOss
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the OSS backend DSP scheduling policy used for the guest audio device;</summary>
            /// <remarks>
            /// the value is user-provided and passed through to the OSS layer (for example, an integer priority or policy code as expected by the host OSS implementation).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dsp_policy Domain#dsp_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dspPolicy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DspPolicy
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Controls whether the OSS backend opens the host audio device in exclusive mode, typically as a yes/no boolean string accepted by QEMU (for example, "on"/"off" or "yes"/"no").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#exclusive Domain#exclusive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exclusive
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables and configures the OSS audio output (playback) stream for the guest;</summary>
            /// <remarks>
            /// presence of this block turns on playback via OSS with the specified attributes.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosOssInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosOssInput?>();
            }

            /// <summary>Enables and configures the OSS audio output (playback) stream for the guest;</summary>
            /// <remarks>
            /// presence of this block turns on playback via OSS with the specified attributes.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosOssOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosOssOutput?>();
            }

            /// <summary>Controls whether the OSS backend attempts to use mmap(2)-based data transfer to the host OSS device, typically as a yes/no boolean string accepted by QEMU.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#try_m_map Domain#try_m_map}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tryMMap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TryMMap
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
