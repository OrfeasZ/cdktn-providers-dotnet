using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsNvRamSourceDataStore")]
    public class DomainOsNvRamSourceDataStore : libvirt.Domain.IDomainOsNvRamSourceDataStore
    {
        /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#format Domain#format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDataStoreFormat\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSourceDataStoreFormat? Format
        {
            get;
            set;
        }
    }
}
