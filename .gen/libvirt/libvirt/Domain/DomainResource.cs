using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainResource")]
    public class DomainResource : libvirt.Domain.IDomainResource
    {
        /// <summary>Configures the Fibre Channel VMID (appid) used by FC/NVMe-FC storage fabrics for QoS and telemetry associated with this domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#fibre_channel Domain#fibre_channel}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fibreChannel", typeJson: "{\"fqn\":\"libvirt.domain.DomainResourceFibreChannel\"}", isOptional: true)]
        public libvirt.Domain.IDomainResourceFibreChannel? FibreChannel
        {
            get;
            set;
        }

        /// <summary>Sets the resource partition name/path that the hypervisor should place this domain into for host-level resource accounting or control;</summary>
        /// <remarks>
        /// the value is user-provided and may be a hierarchical partition identifier (for example, "/machine/qemu/production").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#resource-partitioning">https://libvirt.org/formatdomain.html#resource-partitioning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#partition Domain#partition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "partition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Partition
        {
            get;
            set;
        }
    }
}
