using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosSdl")]
    public class DomainDevicesAudiosSdl : libvirt.Domain.IDomainDevicesAudiosSdl
    {
        /// <summary>Sets the SDL audio driver name to use (mapped to the `SDL_AUDIODRIVER` value);</summary>
        /// <remarks>
        /// the string is user-provided and should match a valid SDL audio driver on the host (for example <c>alsa</c> or <c>pulseaudio</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#sdl-audio-backend">https://libvirt.org/formatdomain.html#sdl-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Driver
        {
            get;
            set;
        }

        /// <summary>Configures output (playback) options for the SDL audio backend, including buffer sizing for the output stream.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdlInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosSdlInput? Input
        {
            get;
            set;
        }

        /// <summary>Configures output (playback) options for the SDL audio backend, including buffer sizing for the output stream.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdlOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosSdlOutput? Output
        {
            get;
            set;
        }
    }
}
