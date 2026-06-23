using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosJackOutput), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosJackOutput")]
    public interface IDomainDevicesAudiosJackOutput
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

        /// <summary>Sets the Jack client name used for the output stream; the value is user-provided and identifies the Jack client.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#client_name Domain#client_name}
        /// </remarks>
        [JsiiProperty(name: "clientName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the Jack backend automatically connects the output stream to Jack ports (`"yes"` or `"no"`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#connect_ports Domain#connect_ports}
        /// </remarks>
        [JsiiProperty(name: "connectPorts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectPorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether the Jack client name for output must match exactly (`"yes"` or `"no"`), influencing how Jack selects the client.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#exact_name Domain#exact_name}
        /// </remarks>
        [JsiiProperty(name: "exactName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExactName
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

        /// <summary>Sets the Jack server name to which the output stream connects;</summary>
        /// <remarks>
        /// the value is user-provided and must correspond to a running Jack server.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#server_name Domain#server_name}
        /// </remarks>
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#settings Domain#settings}.</summary>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackOutputSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosJackOutputSettings? Settings
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosJackOutput), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosJackOutput")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosJackOutput
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

            /// <summary>Sets the Jack client name used for the output stream; the value is user-provided and identifies the Jack client.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#client_name Domain#client_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the Jack backend automatically connects the output stream to Jack ports (`"yes"` or `"no"`).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#connect_ports Domain#connect_ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectPorts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectPorts
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies whether the Jack client name for output must match exactly (`"yes"` or `"no"`), influencing how Jack selects the client.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#exact_name Domain#exact_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exactName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExactName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#fixed_settings Domain#fixed_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FixedSettings
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mixing_engine Domain#mixing_engine}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mixingEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MixingEngine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the Jack server name to which the output stream connects;</summary>
            /// <remarks>
            /// the value is user-provided and must correspond to a running Jack server.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#server_name Domain#server_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#settings Domain#settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackOutputSettings\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosJackOutputSettings? Settings
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosJackOutputSettings?>();
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
