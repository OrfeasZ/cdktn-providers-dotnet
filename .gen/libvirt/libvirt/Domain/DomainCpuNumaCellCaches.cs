using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainCpuNumaCellCaches")]
    public class DomainCpuNumaCellCaches : libvirt.Domain.IDomainCpuNumaCellCaches
    {
        /// <summary>Sets the cache associativity policy (for example "direct", "none", or other user-provided policy names) for a memory-side cache in a NUMA cell.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#associativity Domain#associativity}
        /// </remarks>
        [JsiiProperty(name: "associativity", typeJson: "{\"primitive\":\"string\"}")]
        public string Associativity
        {
            get;
            set;
        }

        /// <summary>Specifies the cache level (e.g. 1, 2, 3) for a memory-side cache in a NUMA cell, as a user-provided integer indicating hierarchy depth.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#level Domain#level}
        /// </remarks>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}")]
        public double Level
        {
            get;
            set;
        }

        /// <summary>Defines the caching policy for a memory-side cache (for example "writeback" or "writethrough") controlling how memory traffic is cached.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#policy Domain#policy}
        /// </remarks>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public string Policy
        {
            get;
            set;
        }

        /// <summary>Configures the cache line size for a memory-side cache in a NUMA cell, via a value and unit pair.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#line Domain#line}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "line", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCachesLine\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuNumaCellCachesLine? Line
        {
            get;
            set;
        }

        /// <summary>Configures the total size of a memory-side cache in a NUMA cell, via a value and unit pair.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaCellCachesSize\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuNumaCellCachesSize? Size
        {
            get;
            set;
        }
    }
}
