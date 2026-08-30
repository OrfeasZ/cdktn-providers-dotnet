using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosOssInput")]
    public class DomainDevicesAudiosOssInput : libvirt.Domain.IDomainDevicesAudiosOssInput
    {
        /// <summary>Sets the number of audio buffers used by the OSS output stream;</summary>
        /// <remarks>
        /// the value is a user-provided positive integer controlling playback latency versus smoothness.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#buffer_count Domain#buffer_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bufferCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#buffer_length Domain#buffer_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferLength
        {
            get;
            set;
        }

        /// <summary>Sets the OSS device node used for audio output, as a user-provided path such as "/dev/dsp" or another OSS playback device.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dev
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fixed_settings Domain#fixed_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fixedSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FixedSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mixing_engine Domain#mixing_engine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mixingEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MixingEngine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#settings Domain#settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssInputSettings\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosOssInputSettings? Settings
        {
            get;
            set;
        }

        /// <summary>Controls whether the OSS output stream attempts to use poll-based I/O instead of blocking I/O, typically as a yes/no boolean string accepted by QEMU.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#oss-audio-backend">https://libvirt.org/formatdomain.html#oss-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#try_poll Domain#try_poll}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tryPoll", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TryPoll
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#voices Domain#voices}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "voices", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Voices
        {
            get;
            set;
        }
    }
}
