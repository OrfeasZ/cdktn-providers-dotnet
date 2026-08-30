using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesMemorydevsTarget")]
    public class DomainDevicesMemorydevsTarget : libvirt.Domain.IDomainDevicesMemorydevsTarget
    {
        /// <summary>Defines the in-guest address for the memory device (such as the guest physical base address for NVDIMM/virtio‑pmem), with sub‑attributes such as base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevsTargetAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemorydevsTargetAddress? Address
        {
            get;
            set;
        }

        /// <summary>Specifies the size value for a memory block unit associated with this memory device (for example, 128 or 512), combined with block_unit to form a full size with units.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block Domain#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Block
        {
            get;
            set;
        }

        /// <summary>Sets the unit for target.block (for example, "MiB" or "GiB"), encoded via the block attribute; the value is user‑provided but must be a valid libvirt size unit.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block_unit Domain#block_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockUnit
        {
            get;
            set;
        }

        /// <summary>Configures the number of dynamic memory slots available for this memory device’s target, controlling how many hotplug operations are allowed;</summary>
        /// <remarks>
        /// value is user-provided and must be a non‑negative integer when specified.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dynamic_memslots Domain#dynamic_memslots}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicMemslots", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DynamicMemslots
        {
            get;
            set;
        }

        /// <summary>Configures the label region for an NVDIMM/pmem-style memory device target, enabling use of a separate label area that stores metadata about the persistent memory namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#label Domain#label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevsTargetLabel\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemorydevsTargetLabel? Label
        {
            get;
            set;
        }

        /// <summary>Selects the NUMA node on which to place the memory provided by this device, using a zero-based node index;</summary>
        /// <remarks>
        /// value is user-provided and must refer to an existing host NUMA node.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#node Domain#node}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeAttribute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NodeAttribute
        {
            get;
            set;
        }

        private object? _readOnly;

        /// <summary>Controls whether this memory device target is exposed as read-only to the guest;</summary>
        /// <remarks>
        /// when set to true the readonly flag is emitted, when false or unset it is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#read_only Domain#read_only}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReadOnly
        {
            get => _readOnly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _readOnly = value;
            }
        }

        /// <summary>Sets the amount of memory the guest initially requests from this device, distinct from the maximum size;</summary>
        /// <remarks>
        /// value is user-provided and interpreted together with <c>requested_unit</c>.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#requested Domain#requested}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requested", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Requested
        {
            get;
            set;
        }

        /// <summary>Sets the unit for `requested` (for example `KiB`, `MiB`, `GiB`);</summary>
        /// <remarks>
        /// the raw value is user-provided and passed directly to libvirt.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#requested_unit Domain#requested_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestedUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestedUnit
        {
            get;
            set;
        }

        /// <summary>Sets the total capacity of this memory device’s target, i.e. how much addressable memory it provides to the guest; value is user-provided and interpreted together with `size_unit`.</summary>
        /// <remarks>
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

        /// <summary>Sets the unit for `size` (for example `KiB`, `MiB`, `GiB`);</summary>
        /// <remarks>
        /// the raw value is user-provided and passed directly to libvirt.
        ///
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
