using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainMemoryBackingMemorySource")]
    public class DomainMemoryBackingMemorySource : libvirt.Domain.IDomainMemoryBackingMemorySource
    {
        /// <summary>Specifies the memory source type;</summary>
        /// <remarks>
        /// the value is user-provided and must be one of the libvirt-supported types for memoryBacking source (e.g. platform-specific values like "anonymous" or "file").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
