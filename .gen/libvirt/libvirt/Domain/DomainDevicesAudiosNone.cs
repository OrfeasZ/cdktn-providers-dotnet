using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosNone")]
    public class DomainDevicesAudiosNone : libvirt.Domain.IDomainDevicesAudiosNone
    {
        /// <summary>Enables a logical output side for the `"none"` audio backend;</summary>
        /// <remarks>
        /// presence is for symmetry and does not connect to a real host output device.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosNoneInput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosNoneInput? Input
        {
            get;
            set;
        }

        /// <summary>Enables a logical output side for the `"none"` audio backend;</summary>
        /// <remarks>
        /// presence is for symmetry and does not connect to a real host output device.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosNoneOutput\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesAudiosNoneOutput? Output
        {
            get;
            set;
        }
    }
}
