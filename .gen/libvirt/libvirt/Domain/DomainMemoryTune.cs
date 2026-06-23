using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainMemoryTune")]
    public class DomainMemoryTune : libvirt.Domain.IDomainMemoryTune
    {
        /// <summary>Sets an upper hard limit on the domain’s memory usage;</summary>
        /// <remarks>
        /// the value is a user-provided positive integer in libvirt memory units (typically KiB) and must not be lower than other required limits.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-tuning">https://libvirt.org/formatdomain.html#memory-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hard_limit Domain#hard_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hardLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HardLimit
        {
            get;
            set;
        }

        /// <summary>Sets the unit for the memory_tune hard_limit value, typically as a memory size unit such as KiB, MiB, or GiB;</summary>
        /// <remarks>
        /// the string is user-provided and must match libvirt’s accepted memory units.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-tuning">https://libvirt.org/formatdomain.html#memory-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hard_limit_unit Domain#hard_limit_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hardLimitUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HardLimitUnit
        {
            get;
            set;
        }

        /// <summary>Sets the minimum amount of memory that the hypervisor guarantees to keep available for the guest, expressed in the unit given by min_guarantee_unit.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-tuning">https://libvirt.org/formatdomain.html#memory-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#min_guarantee Domain#min_guarantee}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minGuarantee", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinGuarantee
        {
            get;
            set;
        }

        /// <summary>Sets the unit for the memory_tune min_guarantee value, typically as a memory size unit such as KiB, MiB, or GiB;</summary>
        /// <remarks>
        /// the string is user-provided and must match libvirt’s accepted memory units.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-tuning">https://libvirt.org/formatdomain.html#memory-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#min_guarantee_unit Domain#min_guarantee_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minGuaranteeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinGuaranteeUnit
        {
            get;
            set;
        }

        /// <summary>Sets a soft memory usage limit for the guest, above which its memory may be preferentially reclaimed, expressed in the unit given by soft_limit_unit.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-tuning">https://libvirt.org/formatdomain.html#memory-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#soft_limit Domain#soft_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "softLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SoftLimit
        {
            get;
            set;
        }

        /// <summary>Sets the unit for the memory_tune soft_limit value, typically as a memory size unit such as KiB, MiB, or GiB;</summary>
        /// <remarks>
        /// the string is user-provided and must match libvirt’s accepted memory units.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-tuning">https://libvirt.org/formatdomain.html#memory-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#soft_limit_unit Domain#soft_limit_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "softLimitUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SoftLimitUnit
        {
            get;
            set;
        }

        /// <summary>Sets an upper limit on the guest’s combined RAM+swap usage, expressed in the unit given by swap_hard_limit_unit, beyond which further allocation is refused.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-tuning">https://libvirt.org/formatdomain.html#memory-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#swap_hard_limit Domain#swap_hard_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "swapHardLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SwapHardLimit
        {
            get;
            set;
        }

        /// <summary>Sets the unit for the memory_tune swap_hard_limit value, typically as a memory size unit such as KiB, MiB, or GiB;</summary>
        /// <remarks>
        /// the string is user-provided and must match libvirt’s accepted memory units.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-tuning">https://libvirt.org/formatdomain.html#memory-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#swap_hard_limit_unit Domain#swap_hard_limit_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "swapHardLimitUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SwapHardLimitUnit
        {
            get;
            set;
        }
    }
}
