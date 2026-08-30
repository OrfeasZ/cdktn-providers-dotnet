using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainQemuDeprecation")]
    public class DomainQemuDeprecation : libvirt.Domain.IDomainQemuDeprecation
    {
        /// <summary>Sets the deprecation handling mode requested from libvirt for QEMU-specific deprecated behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#behavior Domain#behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Behavior
        {
            get;
            set;
        }
    }
}
