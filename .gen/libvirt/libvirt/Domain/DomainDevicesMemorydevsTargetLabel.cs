using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesMemorydevsTargetLabel")]
    public class DomainDevicesMemorydevsTargetLabel : libvirt.Domain.IDomainDevicesMemorydevsTargetLabel
    {
        /// <summary>Sets the size of the label region associated with this memory device target;</summary>
        /// <remarks>
        /// value is user-provided and interpreted together with <c>label.size_unit</c>.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }

        /// <summary>Sets the unit for `label.size` (for example `KiB`, `MiB`, `GiB`); the raw value is user-provided and passed directly to libvirt.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size_unit Domain#size_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SizeUnit
        {
            get;
            set;
        }
    }
}
