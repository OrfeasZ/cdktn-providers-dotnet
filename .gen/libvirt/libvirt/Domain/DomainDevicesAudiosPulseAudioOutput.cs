using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosPulseAudioOutput")]
    public class DomainDevicesAudiosPulseAudioOutput : libvirt.Domain.IDomainDevicesAudiosPulseAudioOutput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#buffer_length Domain#buffer_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferLength
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

        /// <summary>Sets the desired latency for the PipeWire output stream as a user-provided value (for example, in microseconds or milliseconds as supported by QEMU/PipeWire).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#latency Domain#latency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Latency
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

        /// <summary>Sets the PipeWire sink name that the guest output stream should connect to, as a user-provided string matching a PipeWire node (for example, "alsa_output.pci-0000_00_1b.0").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#settings Domain#settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudioOutputSettings\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosPulseAudioOutputSettings? Settings
        {
            get;
            set;
        }

        /// <summary>Sets the logical stream name used for the PipeWire output stream, as a user-provided label shown in PipeWire clients (for example, "vm-audio").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#stream_name Domain#stream_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamName
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
