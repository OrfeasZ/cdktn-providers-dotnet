using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainCpuMaxPhysAddr")]
    public class DomainCpuMaxPhysAddr : libvirt.Domain.IDomainCpuMaxPhysAddr
    {
        /// <summary>Selects how the max physical address limit is applied, with valid values documented by libvirt such as "emulate", "passthrough", or similar driver-specific modes;</summary>
        /// <remarks>
        /// this attribute is required whenever a max_phys_addr limit is defined.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Sets the maximum number of physical address bits exposed to the guest CPU (for example 36, 40, or 48);</summary>
        /// <remarks>
        /// value must be a positive integer not exceeding the host capability.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bits Domain#bits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Bits
        {
            get;
            set;
        }

        /// <summary>Sets the maximum guest-visible physical address bit width (e.g. 46) when limiting the CPU's physical address space; the value is user-provided and interpreted according to the selected mode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#limit Domain#limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Limit
        {
            get;
            set;
        }
    }
}
