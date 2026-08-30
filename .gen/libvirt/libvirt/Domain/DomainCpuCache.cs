using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainCpuCache")]
    public class DomainCpuCache : libvirt.Domain.IDomainCpuCache
    {
        /// <summary>Sets the cache configuration mode, with typical values such as "emulate" or "passthrough" depending on hypervisor support;</summary>
        /// <remarks>
        /// value must be one of the cache modes allowed by libvirt for the selected CPU model.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Sets which cache level (for example 1, 2, or 3) the cache configuration applies to;</summary>
        /// <remarks>
        /// value is a user-provided positive integer corresponding to a CPU cache level.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
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
    }
}
