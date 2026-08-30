using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainUpdate")]
    public class DomainUpdate : libvirt.Domain.IDomainUpdate
    {
        /// <summary>Experimental: request a guest shutdown and wait for shutoff before forcing a stop during update.</summary>
        /// <remarks>
        /// Subject to change in future releases.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#shutdown Domain#shutdown}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shutdown", typeJson: "{\"fqn\":\"libvirt.domain.DomainUpdateShutdown\"}", isOptional: true)]
        public libvirt.Domain.IDomainUpdateShutdown? Shutdown
        {
            get;
            set;
        }
    }
}
