using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosCoreAudio")]
    public class DomainDevicesAudiosCoreAudio : libvirt.Domain.IDomainDevicesAudiosCoreAudio
    {
        /// <summary>Configures CoreAudio output (playback) parameters for the audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudioInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosCoreAudioInput? Input
        {
            get;
            set;
        }

        /// <summary>Configures CoreAudio output (playback) parameters for the audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudioOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosCoreAudioOutput? Output
        {
            get;
            set;
        }
    }
}
