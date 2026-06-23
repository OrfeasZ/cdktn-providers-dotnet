using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosPipeWireOutput), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosPipeWireOutput")]
    public interface IDomainDevicesAudiosPipeWireOutput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#buffer_length Domain#buffer_length}.</summary>
        [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#fixed_settings Domain#fixed_settings}.</summary>
        [JsiiProperty(name: "fixedSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FixedSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the desired latency for the PipeWire output stream as a user-provided value (for example, in microseconds or milliseconds as supported by QEMU/PipeWire).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#latency Domain#latency}
        /// </remarks>
        [JsiiProperty(name: "latency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Latency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mixing_engine Domain#mixing_engine}.</summary>
        [JsiiProperty(name: "mixingEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MixingEngine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PipeWire sink name that the guest output stream should connect to, as a user-provided string matching a PipeWire node (for example, "alsa_output.pci-0000_00_1b.0").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#settings Domain#settings}.</summary>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutputSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosPipeWireOutputSettings? Settings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the logical stream name used for the PipeWire output stream, as a user-provided label shown in PipeWire clients (for example, "vm-audio").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#stream_name Domain#stream_name}
        /// </remarks>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#voices Domain#voices}.</summary>
        [JsiiProperty(name: "voices", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Voices
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosPipeWireOutput), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosPipeWireOutput")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosPipeWireOutput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#buffer_length Domain#buffer_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#fixed_settings Domain#fixed_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FixedSettings
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the desired latency for the PipeWire output stream as a user-provided value (for example, in microseconds or milliseconds as supported by QEMU/PipeWire).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#latency Domain#latency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Latency
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mixing_engine Domain#mixing_engine}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mixingEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MixingEngine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the PipeWire sink name that the guest output stream should connect to, as a user-provided string matching a PipeWire node (for example, "alsa_output.pci-0000_00_1b.0").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#settings Domain#settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutputSettings\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosPipeWireOutputSettings? Settings
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosPipeWireOutputSettings?>();
            }

            /// <summary>Sets the logical stream name used for the PipeWire output stream, as a user-provided label shown in PipeWire clients (for example, "vm-audio").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#pipewire-audio-backend">https://libvirt.org/formatdomain.html#pipewire-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#stream_name Domain#stream_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#voices Domain#voices}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "voices", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Voices
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
