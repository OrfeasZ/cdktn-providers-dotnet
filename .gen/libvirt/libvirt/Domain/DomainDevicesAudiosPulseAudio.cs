using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosPulseAudio")]
    public class DomainDevicesAudiosPulseAudio : libvirt.Domain.IDomainDevicesAudiosPulseAudio
    {
        /// <summary>Enables and configures the PipeWire output (playback) stream for the guest, allowing selection of sink name, stream name, and latency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudioInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosPulseAudioInput? Input
        {
            get;
            set;
        }

        /// <summary>Enables and configures the PipeWire output (playback) stream for the guest, allowing selection of sink name, stream name, and latency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudioOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosPulseAudioOutput? Output
        {
            get;
            set;
        }

        /// <summary>Sets the hostname or address of the PulseAudio server the domain should connect to;</summary>
        /// <remarks>
        /// if omitted, PulseAudio’s default server discovery is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#pulseaudio-audio-backend">https://libvirt.org/formatdomain.html#pulseaudio-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#server_name Domain#server_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerName
        {
            get;
            set;
        }
    }
}
