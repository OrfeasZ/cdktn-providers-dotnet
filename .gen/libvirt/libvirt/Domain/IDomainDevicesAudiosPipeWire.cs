using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosPipeWire), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosPipeWire")]
    public interface IDomainDevicesAudiosPipeWire
    {
        /// <summary>Enables and configures the PipeWire output (playback) stream for the guest, allowing selection of sink name, stream name, and latency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosPipeWireInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures the PipeWire output (playback) stream for the guest, allowing selection of sink name, stream name, and latency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosPipeWireOutput? Output
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the directory path used for locating the PipeWire runtime socket and related resources for the PipeWire audio backend;</summary>
        /// <remarks>
        /// the value is a user-provided filesystem path (for example <c>/run/user/1000</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#runtime_dir Domain#runtime_dir}
        /// </remarks>
        [JsiiProperty(name: "runtimeDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuntimeDir
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosPipeWire), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosPipeWire")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosPipeWire
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables and configures the PipeWire output (playback) stream for the guest, allowing selection of sink name, stream name, and latency.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosPipeWireInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosPipeWireInput?>();
            }

            /// <summary>Enables and configures the PipeWire output (playback) stream for the guest, allowing selection of sink name, stream name, and latency.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosPipeWireOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosPipeWireOutput?>();
            }

            /// <summary>Sets the directory path used for locating the PipeWire runtime socket and related resources for the PipeWire audio backend;</summary>
            /// <remarks>
            /// the value is a user-provided filesystem path (for example <c>/run/user/1000</c>).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#runtime_dir Domain#runtime_dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuntimeDir
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
