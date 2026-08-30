using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosAlsa")]
    public class DomainDevicesAudiosAlsa : libvirt.Domain.IDomainDevicesAudiosAlsa
    {
        /// <summary>Configures ALSA output (playback) settings for the audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosAlsaInput? Input
        {
            get;
            set;
        }

        /// <summary>Configures ALSA output (playback) settings for the audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosAlsaOutput? Output
        {
            get;
            set;
        }
    }
}
