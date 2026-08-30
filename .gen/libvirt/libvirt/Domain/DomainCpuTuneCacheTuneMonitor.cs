using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainCpuTuneCacheTuneMonitor")]
    public class DomainCpuTuneCacheTuneMonitor : libvirt.Domain.IDomainCpuTuneCacheTuneMonitor
    {
        /// <summary>Sets the cache hierarchy level that the cache monitoring group applies to, as an integer level number (for example, 1 for L1, 2 for L2);</summary>
        /// <remarks>
        /// the value is user-provided and must match a cache level supported by the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#level Domain#level}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Level
        {
            get;
            set;
        }

        /// <summary>Specifies the set of vCPU indexes that belong to this cache monitoring group, using the same comma-separated and range syntax as other cpuset strings (for example, "0,2-3");</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Vcpus
        {
            get;
            set;
        }
    }
}
