using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainNumaTuneMemory")]
    public class DomainNumaTuneMemory : libvirt.Domain.IDomainNumaTuneMemory
    {
        /// <summary>Sets the overall NUMA memory allocation policy for the domain, with valid values including preferred, interleave, bind, strict, or other modes accepted by libvirt.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
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

        /// <summary>Specifies the host NUMA node or nodes used by the global memory policy, using libvirt’s nodeset syntax (e.g. "0-1" or "0,2,4").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nodeset Domain#nodeset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Nodeset
        {
            get;
            set;
        }

        /// <summary>Controls whether libvirt automatically selects NUMA nodes for the domain’s memory (auto) or uses an explicit nodeset (static), with valid values being auto or static.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#placement Domain#placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Placement
        {
            get;
            set;
        }
    }
}
