using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsCapsMisc")]
    public class DomainDevicesHostdevsCapsMisc : libvirt.Domain.IDomainDevicesHostdevsCapsMisc
    {
        /// <summary>Defines the source configuration for the miscellaneous capability, such as underlying host resources or paths needed by that capability.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsMiscSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsCapsMiscSource? Source
        {
            get;
            set;
        }
    }
}
