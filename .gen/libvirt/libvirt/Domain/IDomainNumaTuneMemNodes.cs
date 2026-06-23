using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainNumaTuneMemNodes), fullyQualifiedName: "libvirt.domain.DomainNumaTuneMemNodes")]
    public interface IDomainNumaTuneMemNodes
    {
        /// <summary>Sets the guest NUMA cell (node) index for this mem_nodes entry;</summary>
        /// <remarks>
        /// the value is a non-negative integer matching a defined guest NUMA cell.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cell_id Domain#cell_id}
        /// </remarks>
        [JsiiProperty(name: "cellId", typeJson: "{\"primitive\":\"number\"}")]
        double CellId
        {
            get;
        }

        /// <summary>Sets the NUMA memory allocation policy for the specified guest cell, with valid values including preferred, interleave, bind, strict, or other modes accepted by libvirt.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Specifies the host NUMA node or nodes to which the guest cell’s memory policy applies, using libvirt’s nodeset syntax (e.g. "0-2,4").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nodeset Domain#nodeset}
        /// </remarks>
        [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}")]
        string Nodeset
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainNumaTuneMemNodes), fullyQualifiedName: "libvirt.domain.DomainNumaTuneMemNodes")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainNumaTuneMemNodes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the guest NUMA cell (node) index for this mem_nodes entry;</summary>
            /// <remarks>
            /// the value is a non-negative integer matching a defined guest NUMA cell.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cell_id Domain#cell_id}
            /// </remarks>
            [JsiiProperty(name: "cellId", typeJson: "{\"primitive\":\"number\"}")]
            public double CellId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the NUMA memory allocation policy for the specified guest cell, with valid values including preferred, interleave, bind, strict, or other modes accepted by libvirt.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the host NUMA node or nodes to which the guest cell’s memory policy applies, using libvirt’s nodeset syntax (e.g. "0-2,4").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#numa-node-tuning">https://libvirt.org/formatdomain.html#numa-node-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nodeset Domain#nodeset}
            /// </remarks>
            [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}")]
            public string Nodeset
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
