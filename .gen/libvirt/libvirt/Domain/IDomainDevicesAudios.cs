using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudios), fullyQualifiedName: "libvirt.domain.DomainDevicesAudios")]
    public interface IDomainDevicesAudios
    {
        /// <summary>Exposes the libvirt-assigned ID of the audio device;</summary>
        /// <remarks>
        /// this is computed by libvirt and cannot be set by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        double Id
        {
            get;
        }

        /// <summary>Configures an ALSA audio backend, delegating guest audio I/O to the host ALSA framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alsa Domain#alsa}
        /// </remarks>
        [JsiiProperty(name: "alsa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsa\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosAlsa? Alsa
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a CoreAudio audio backend, delegating guest audio I/O to the macOS CoreAudio framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#core_audio Domain#core_audio}
        /// </remarks>
        [JsiiProperty(name: "coreAudio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudio\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosCoreAudio? CoreAudio
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a D‑Bus audio backend, which exposes audio via D‑Bus rather than a host audio framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dbus Domain#dbus}
        /// </remarks>
        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbus\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosDbus? Dbus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the file-based audio backend, which records guest audio streams to a host file instead of a real audio device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosFile? File
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the Jack audio backend, delegating guest audio I/O to a Jack daemon.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#jack Domain#jack}
        /// </remarks>
        [JsiiProperty(name: "jack", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJack\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosJack? Jack
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the dummy `"none"` audio backend, which does not use any host audio framework but still allows remote desktop protocols to carry audio.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#none Domain#none}
        /// </remarks>
        [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosNone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosNone? None
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the OSS audio backend, delegating guest audio I/O to the host OSS framework and allowing additional OSS-specific options on the audio element.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#oss Domain#oss}
        /// </remarks>
        [JsiiProperty(name: "oss", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOss\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosOss? Oss
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures a PipeWire audio backend for the guest, delegating audio I/O to a PipeWire daemon with optional per-stream settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pipe_wire Domain#pipe_wire}
        /// </remarks>
        [JsiiProperty(name: "pipeWire", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWire\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosPipeWire? PipeWire
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of a PulseAudio audio backend attached to the domain, allowing you to specify connection and stream properties for PulseAudio input/output.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pulse_audio Domain#pulse_audio}
        /// </remarks>
        [JsiiProperty(name: "pulseAudio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudio\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosPulseAudio? PulseAudio
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of an SDL-based audio backend for the domain, allowing you to tune the underlying SDL audio driver and buffer settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sdl Domain#sdl}
        /// </remarks>
        [JsiiProperty(name: "sdl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosSdl? Sdl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of a SPICE-only audio backend, which routes audio exclusively through a SPICE server without using a host audio framework.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice Domain#spice}
        /// </remarks>
        [JsiiProperty(name: "spice", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosSpice? Spice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the audio backend timer period in milliseconds, controlling how often audio buffers are processed;</summary>
        /// <remarks>
        /// the value is user-provided and should be a positive integer supported by the chosen backend.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timer_period Domain#timer_period}
        /// </remarks>
        [JsiiProperty(name: "timerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimerPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudios), fullyQualifiedName: "libvirt.domain.DomainDevicesAudios")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudios
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Exposes the libvirt-assigned ID of the audio device;</summary>
            /// <remarks>
            /// this is computed by libvirt and cannot be set by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
            public double Id
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Configures an ALSA audio backend, delegating guest audio I/O to the host ALSA framework.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alsa Domain#alsa}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alsa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsa\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosAlsa? Alsa
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosAlsa?>();
            }

            /// <summary>Configures a CoreAudio audio backend, delegating guest audio I/O to the macOS CoreAudio framework.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#core_audio Domain#core_audio}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coreAudio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudio\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosCoreAudio? CoreAudio
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosCoreAudio?>();
            }

            /// <summary>Configures a D‑Bus audio backend, which exposes audio via D‑Bus rather than a host audio framework.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dbus Domain#dbus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbus\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosDbus? Dbus
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosDbus?>();
            }

            /// <summary>Configures the file-based audio backend, which records guest audio streams to a host file instead of a real audio device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFile\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosFile? File
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosFile?>();
            }

            /// <summary>Configures the Jack audio backend, delegating guest audio I/O to a Jack daemon.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#jack Domain#jack}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jack", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJack\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosJack? Jack
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosJack?>();
            }

            /// <summary>Configures the dummy `"none"` audio backend, which does not use any host audio framework but still allows remote desktop protocols to carry audio.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#none Domain#none}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosNone\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosNone? None
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosNone?>();
            }

            /// <summary>Configures the OSS audio backend, delegating guest audio I/O to the host OSS framework and allowing additional OSS-specific options on the audio element.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#oss Domain#oss}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oss", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOss\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosOss? Oss
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosOss?>();
            }

            /// <summary>Enables and configures a PipeWire audio backend for the guest, delegating audio I/O to a PipeWire daemon with optional per-stream settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pipe_wire Domain#pipe_wire}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipeWire", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWire\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosPipeWire? PipeWire
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosPipeWire?>();
            }

            /// <summary>Enables configuration of a PulseAudio audio backend attached to the domain, allowing you to specify connection and stream properties for PulseAudio input/output.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pulse_audio Domain#pulse_audio}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pulseAudio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudio\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosPulseAudio? PulseAudio
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosPulseAudio?>();
            }

            /// <summary>Enables configuration of an SDL-based audio backend for the domain, allowing you to tune the underlying SDL audio driver and buffer settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sdl Domain#sdl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sdl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdl\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosSdl? Sdl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosSdl?>();
            }

            /// <summary>Enables configuration of a SPICE-only audio backend, which routes audio exclusively through a SPICE server without using a host audio framework.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#spice Domain#spice}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spice", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpice\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosSpice? Spice
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosSpice?>();
            }

            /// <summary>Sets the audio backend timer period in milliseconds, controlling how often audio buffers are processed;</summary>
            /// <remarks>
            /// the value is user-provided and should be a positive integer supported by the chosen backend.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timer_period Domain#timer_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimerPeriod
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
