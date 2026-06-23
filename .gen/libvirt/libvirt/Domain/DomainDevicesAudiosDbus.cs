using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosDbus")]
    public class DomainDevicesAudiosDbus : libvirt.Domain.IDomainDevicesAudiosDbus
    {
        /// <summary>Enables and configures output (playback) for the D‑Bus audio backend; no additional attributes are defined beyond presence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbusInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosDbusInput? Input
        {
            get;
            set;
        }

        /// <summary>Enables and configures output (playback) for the D‑Bus audio backend; no additional attributes are defined beyond presence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbusOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosDbusOutput? Output
        {
            get;
            set;
        }
    }
}
