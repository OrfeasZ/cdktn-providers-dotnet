using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainNumaTuneMemNodes")]
    public class DomainNumaTuneMemNodes : libvirt.Domain.IDomainNumaTuneMemNodes
    {
        /// <summary>Sets the guest NUMA cell (node) index for this mem_nodes entry;</summary>
        /// <remarks>
        /// the value is a non-negative integer matching a defined guest NUMA cell.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cell_id Domain#cell_id}
        /// </remarks>
        [JsiiProperty(name: "cellId", typeJson: "{\"primitive\":\"number\"}")]
        public double CellId
        {
            get;
            set;
        }

        /// <summary>Sets the NUMA memory allocation policy for the specified guest cell, with valid values including preferred, interleave, bind, strict, or other modes accepted by libvirt.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Specifies the host NUMA node or nodes to which the guest cell’s memory policy applies, using libvirt’s nodeset syntax (e.g. "0-2,4").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nodeset Domain#nodeset}
        /// </remarks>
        [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}")]
        public string Nodeset
        {
            get;
            set;
        }
    }
}
