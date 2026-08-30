using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosSdl), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosSdl")]
    public interface IDomainDevicesAudiosSdl
    {
        /// <summary>Sets the SDL audio driver name to use (mapped to the `SDL_AUDIODRIVER` value);</summary>
        /// <remarks>
        /// the string is user-provided and should match a valid SDL audio driver on the host (for example <c>alsa</c> or <c>pulseaudio</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#sdl-audio-backend">https://libvirt.org/formatdomain.html#sdl-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures output (playback) options for the SDL audio backend, including buffer sizing for the output stream.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdlInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosSdlInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures output (playback) options for the SDL audio backend, including buffer sizing for the output stream.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdlOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosSdlOutput? Output
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosSdl), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosSdl")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosSdl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SDL audio driver name to use (mapped to the `SDL_AUDIODRIVER` value);</summary>
            /// <remarks>
            /// the string is user-provided and should match a valid SDL audio driver on the host (for example <c>alsa</c> or <c>pulseaudio</c>).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#sdl-audio-backend">https://libvirt.org/formatdomain.html#sdl-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Driver
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures output (playback) options for the SDL audio backend, including buffer sizing for the output stream.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdlInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosSdlInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosSdlInput?>();
            }

            /// <summary>Configures output (playback) options for the SDL audio backend, including buffer sizing for the output stream.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdlOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosSdlOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosSdlOutput?>();
            }
        }
    }
}
