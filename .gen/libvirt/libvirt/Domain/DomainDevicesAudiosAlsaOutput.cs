using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosAlsaOutput")]
    public class DomainDevicesAudiosAlsaOutput : libvirt.Domain.IDomainDevicesAudiosAlsaOutput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#buffer_length Domain#buffer_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferLength
        {
            get;
            set;
        }

        /// <summary>Sets the ALSA device node used for audio output, as a host path string such as /dev/snd/pcmC0D0p.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#alsa-audio-backend">https://libvirt.org/formatdomain.html#alsa-audio-backend</a>
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
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutputSettings\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosAlsaOutputSettings? Settings
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
