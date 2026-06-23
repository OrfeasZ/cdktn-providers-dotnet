using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsCapsStorage")]
    public class DomainDevicesHostdevsCapsStorage : libvirt.Domain.IDomainDevicesHostdevsCapsStorage
    {
        /// <summary>Defines the storage source information for the passthrough host device, typically pointing to a host block device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsStorageSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsCapsStorageSource? Source
        {
            get;
            set;
        }
    }
}
