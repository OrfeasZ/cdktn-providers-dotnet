using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainMemoryBackingMemoryAllocation")]
    public class DomainMemoryBackingMemoryAllocation : libvirt.Domain.IDomainMemoryBackingMemoryAllocation
    {
        /// <summary>Sets the allocation mode for backing memory;</summary>
        /// <remarks>
        /// the value is user-provided and must be one of the modes supported by libvirt (for example, immediate vs. on‑demand allocation depending on hypervisor support).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Specifies the number of threads to use when performing the chosen memory allocation mode;</summary>
        /// <remarks>
        /// the value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-backing">https://libvirt.org/formatdomain.html#memory-backing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#threads Domain#threads}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Threads
        {
            get;
            set;
        }
    }
}
