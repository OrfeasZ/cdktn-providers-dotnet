using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosJack")]
    public class DomainDevicesAudiosJack : libvirt.Domain.IDomainDevicesAudiosJack
    {
        /// <summary>Enables and configures the output (playback) side of the Jack audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosJackInput? Input
        {
            get;
            set;
        }

        /// <summary>Enables and configures the output (playback) side of the Jack audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosJackOutput? Output
        {
            get;
            set;
        }
    }
}
