using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosOss")]
    public class DomainDevicesAudiosOss : libvirt.Domain.IDomainDevicesAudiosOss
    {
        /// <summary>Configures the OSS backend DSP scheduling policy used for the guest audio device;</summary>
        /// <remarks>
        /// the value is user-provided and passed through to the OSS layer (for example, an integer priority or policy code as expected by the host OSS implementation).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dsp_policy Domain#dsp_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dspPolicy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DspPolicy
        {
            get;
            set;
        }

        /// <summary>Controls whether the OSS backend opens the host audio device in exclusive mode, typically as a yes/no boolean string accepted by QEMU (for example, "on"/"off" or "yes"/"no").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#exclusive Domain#exclusive}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exclusive
        {
            get;
            set;
        }

        /// <summary>Enables and configures the OSS audio output (playback) stream for the guest;</summary>
        /// <remarks>
        /// presence of this block turns on playback via OSS with the specified attributes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosOssInput? Input
        {
            get;
            set;
        }

        /// <summary>Enables and configures the OSS audio output (playback) stream for the guest;</summary>
        /// <remarks>
        /// presence of this block turns on playback via OSS with the specified attributes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosOssOutput? Output
        {
            get;
            set;
        }

        /// <summary>Controls whether the OSS backend attempts to use mmap(2)-based data transfer to the host OSS device, typically as a yes/no boolean string accepted by QEMU.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#try_m_map Domain#try_m_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tryMMap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TryMMap
        {
            get;
            set;
        }
    }
}
