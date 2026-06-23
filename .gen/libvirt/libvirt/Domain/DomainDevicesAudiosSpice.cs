using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosSpice")]
    public class DomainDevicesAudiosSpice : libvirt.Domain.IDomainDevicesAudiosSpice
    {
        /// <summary>Declares an output (playback) stream for the SPICE audio backend;</summary>
        /// <remarks>
        /// presence of this block enables SPICE audio playback with default stream properties.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpiceInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosSpiceInput? Input
        {
            get;
            set;
        }

        /// <summary>Declares an output (playback) stream for the SPICE audio backend;</summary>
        /// <remarks>
        /// presence of this block enables SPICE audio playback with default stream properties.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpiceOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosSpiceOutput? Output
        {
            get;
            set;
        }
    }
}
