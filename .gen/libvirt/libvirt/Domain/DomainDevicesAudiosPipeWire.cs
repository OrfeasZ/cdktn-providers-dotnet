using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosPipeWire")]
    public class DomainDevicesAudiosPipeWire : libvirt.Domain.IDomainDevicesAudiosPipeWire
    {
        /// <summary>Enables and configures the PipeWire output (playback) stream for the guest, allowing selection of sink name, stream name, and latency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosPipeWireInput? Input
        {
            get;
            set;
        }

        /// <summary>Enables and configures the PipeWire output (playback) stream for the guest, allowing selection of sink name, stream name, and latency.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosPipeWireOutput? Output
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
