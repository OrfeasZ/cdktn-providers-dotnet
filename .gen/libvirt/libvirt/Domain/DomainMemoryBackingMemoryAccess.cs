using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainMemoryBackingMemoryAccess")]
    public class DomainMemoryBackingMemoryAccess : libvirt.Domain.IDomainMemoryBackingMemoryAccess
    {
        /// <summary>Sets the memory access mode;</summary>
        /// <remarks>
        /// the value is user-provided and must be one of the modes supported by libvirt for memoryBacking access (for example, platform‑specific NUMA access modes).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }
    }
}
