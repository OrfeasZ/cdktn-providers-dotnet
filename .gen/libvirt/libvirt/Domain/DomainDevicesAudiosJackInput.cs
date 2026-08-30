using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosJackInput")]
    public class DomainDevicesAudiosJackInput : libvirt.Domain.IDomainDevicesAudiosJackInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#buffer_length Domain#buffer_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferLength
        {
            get;
            set;
        }

        /// <summary>Sets the Jack client name used for the output stream; the value is user-provided and identifies the Jack client.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#client_name Domain#client_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientName
        {
            get;
            set;
        }

        /// <summary>Controls whether the Jack backend automatically connects the output stream to Jack ports (`"yes"` or `"no"`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#connect_ports Domain#connect_ports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectPorts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectPorts
        {
            get;
            set;
        }

        /// <summary>Specifies whether the Jack client name for output must match exactly (`"yes"` or `"no"`), influencing how Jack selects the client.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#exact_name Domain#exact_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exactName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExactName
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

        /// <summary>Sets the Jack server name to which the output stream connects;</summary>
        /// <remarks>
        /// the value is user-provided and must correspond to a running Jack server.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#jack-audio-backend">https://libvirt.org/formatdomain.html#jack-audio-backend</a>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#settings Domain#settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackInputSettings\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosJackInputSettings? Settings
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
