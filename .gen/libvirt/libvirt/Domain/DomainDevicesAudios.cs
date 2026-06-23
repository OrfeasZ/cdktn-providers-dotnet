using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudios")]
    public class DomainDevicesAudios : libvirt.Domain.IDomainDevicesAudios
    {
        /// <summary>Exposes the libvirt-assigned ID of the audio device;</summary>
        /// <remarks>
        /// this is computed by libvirt and cannot be set by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public double Id
        {
            get;
            set;
        }

        /// <summary>Configures an ALSA audio backend, delegating guest audio I/O to the host ALSA framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alsa Domain#alsa}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alsa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsa\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosAlsa? Alsa
        {
            get;
            set;
        }

        /// <summary>Configures a CoreAudio audio backend, delegating guest audio I/O to the macOS CoreAudio framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#core_audio Domain#core_audio}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coreAudio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudio\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosCoreAudio? CoreAudio
        {
            get;
            set;
        }

        /// <summary>Configures a D‑Bus audio backend, which exposes audio via D‑Bus rather than a host audio framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbus\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosDbus? Dbus
        {
            get;
            set;
        }

        /// <summary>Configures the file-based audio backend, which records guest audio streams to a host file instead of a real audio device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFile\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosFile? File
        {
            get;
            set;
        }

        /// <summary>Configures the Jack audio backend, delegating guest audio I/O to a Jack daemon.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#jack Domain#jack}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jack", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJack\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosJack? Jack
        {
            get;
            set;
        }

        /// <summary>Configures the dummy `"none"` audio backend, which does not use any host audio framework but still allows remote desktop protocols to carry audio.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#none Domain#none}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosNone\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosNone? None
        {
            get;
            set;
        }

        /// <summary>Configures the OSS audio backend, delegating guest audio I/O to the host OSS framework and allowing additional OSS-specific options on the audio element.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#oss Domain#oss}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oss", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOss\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosOss? Oss
        {
            get;
            set;
        }

        /// <summary>Enables and configures a PipeWire audio backend for the guest, delegating audio I/O to a PipeWire daemon with optional per-stream settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pipe_wire Domain#pipe_wire}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeWire", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWire\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosPipeWire? PipeWire
        {
            get;
            set;
        }

        /// <summary>Enables configuration of a PulseAudio audio backend attached to the domain, allowing you to specify connection and stream properties for PulseAudio input/output.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pulse_audio Domain#pulse_audio}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pulseAudio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudio\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosPulseAudio? PulseAudio
        {
            get;
            set;
        }

        /// <summary>Enables configuration of an SDL-based audio backend for the domain, allowing you to tune the underlying SDL audio driver and buffer settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sdl Domain#sdl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sdl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdl\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosSdl? Sdl
        {
            get;
            set;
        }

        /// <summary>Enables configuration of a SPICE-only audio backend, which routes audio exclusively through a SPICE server without using a host audio framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#spice Domain#spice}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spice", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpice\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosSpice? Spice
        {
            get;
            set;
        }

        /// <summary>Sets the audio backend timer period in milliseconds, controlling how often audio buffers are processed;</summary>
        /// <remarks>
        /// the value is user-provided and should be a positive integer supported by the chosen backend.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#timer_period Domain#timer_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimerPeriod
        {
            get;
            set;
        }
    }
}
