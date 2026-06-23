using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystems")]
    public class DomainDevicesFilesystems : libvirt.Domain.IDomainDevicesFilesystems
    {
        /// <summary>Sets how the guest accesses the host filesystem, typically "passthrough", "mapped", or "squash" for directory-based filesystems.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#access_mode Domain#access_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessMode
        {
            get;
            set;
        }

        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Configures a virtiofsd-like helper binary used to export the host filesystem to the guest, including its path and runtime limits.</summary>
        /// <remarks>
        /// When omitted, libvirt or the hypervisor default behavior for the filesystem backend is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#binary Domain#binary}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "binary", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinary\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsBinary? Binary
        {
            get;
            set;
        }

        /// <summary>Enables boot-order control for this redirected device, allowing it to participate in the device boot sequence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#boot Domain#boot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBoot\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsBoot? Boot
        {
            get;
            set;
        }

        /// <summary>Sets the default directory permission bits (in octal, e.g. 0755) that libvirt applies to newly created directories inside the guest-visible mount of this filesystem.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dmode Domain#dmode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dmode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dmode
        {
            get;
            set;
        }

        /// <summary>Configures driver-specific options for the filesystem device, including implementation type and virtio transport tuning for applicable models.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsDriver\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsDriver? Driver
        {
            get;
            set;
        }

        /// <summary>Sets the default file permission bits (in octal, e.g. 0644) that libvirt applies to newly created regular files inside the guest-visible mount of this filesystem.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#fmode Domain#fmode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fmode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fmode
        {
            get;
            set;
        }

        /// <summary>Configures user and group ID mapping for this filesystem device, allowing remapping of guest UIDs/GIDs to different host IDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id_map Domain#id_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idMap", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsIdMap\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsIdMap? IdMap
        {
            get;
            set;
        }

        /// <summary>Sets the filesystem device model presented to the guest, typically `virtio` for paravirtualized filesystems;</summary>
        /// <remarks>
        /// the exact value is user-provided but must be supported by the hypervisor (e.g. <c>virtiofs</c> for type <c>virtiofs</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Model
        {
            get;
            set;
        }

        /// <summary>Controls how the guest is allowed to access multiple backing devices under a single shared filesystem, using libvirt’s `multidevs` policy such as `default`, `remap`, `forbid`, or `warn`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#multi_devs Domain#multi_devs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multiDevs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultiDevs
        {
            get;
            set;
        }

        private object? _readOnly;

        /// <summary>Controls whether the filesystem is attached read-only to the guest;</summary>
        /// <remarks>
        /// when true the <c>&lt;readonly&gt;</c> element is emitted, otherwise it is omitted and the filesystem is writable if supported.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#read_only Domain#read_only}
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

        /// <summary>Groups the specification of the host-side filesystem source, with exactly one of the child variants (`bind`, `block`, `file`, `mount`, `ram`, or `template`) used depending on the filesystem `type`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsSource? Source
        {
            get;
            set;
        }

        /// <summary>Sets a hard limit on the amount of host storage space that the filesystem device may consume;</summary>
        /// <remarks>
        /// the numeric value is interpreted together with space_hard_limit_unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#space_hard_limit Domain#space_hard_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spaceHardLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SpaceHardLimit
        {
            get;
            set;
        }

        /// <summary>Sets the unit for space_hard_limit (for example, "bytes", "KiB", "MiB", "GiB");</summary>
        /// <remarks>
        /// the value is a libvirt size unit string and must be consistent with the numeric limit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#space_hard_limit_unit Domain#space_hard_limit_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spaceHardLimitUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpaceHardLimitUnit
        {
            get;
            set;
        }

        /// <summary>Sets a soft (advisory) limit on the amount of host storage space that the filesystem device should use;</summary>
        /// <remarks>
        /// the numeric value is interpreted together with space_soft_limit_unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#space_soft_limit Domain#space_soft_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spaceSoftLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SpaceSoftLimit
        {
            get;
            set;
        }

        /// <summary>Sets the unit for space_soft_limit (for example, "bytes", "KiB", "MiB", "GiB");</summary>
        /// <remarks>
        /// the value is a libvirt size unit string and must be consistent with the numeric limit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#space_soft_limit_unit Domain#space_soft_limit_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spaceSoftLimitUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpaceSoftLimitUnit
        {
            get;
            set;
        }

        /// <summary>Configures how and where the filesystem is exposed inside the guest by providing the guest-side mount target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsTarget\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsTarget? Target
        {
            get;
            set;
        }
    }
}
