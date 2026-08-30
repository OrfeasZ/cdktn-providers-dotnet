using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainConfig")]
    public class DomainConfig : libvirt.Domain.IDomainConfig
    {
        /// <summary>Sets the domain’s short name, which must be unique on the host and consist only of alphanumeric characters.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Sets the hypervisor type used to run the domain (for example "kvm", "qemu", or "xen");</summary>
        /// <remarks>
        /// this is required and must be a valid libvirt domain driver name for the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#element-and-attribute-overview">https://libvirt.org/formatdomain.html#element-and-attribute-overview</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _autostart;

        /// <summary>Whether the domain should be started automatically when the host boots.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#autostart Domain#autostart}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Autostart
        {
            get => _autostart;
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
                _autostart = value;
            }
        }

        /// <summary>Configures bhyve-specific command-line passthrough for a domain, allowing extra arguments and environment variables to be appended through the bhyve XML namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bhyve_commandline Domain#bhyve_commandline}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bhyveCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainBhyveCommandline\"}", isOptional: true)]
        public libvirt.Domain.IDomainBhyveCommandline? BhyveCommandline
        {
            get;
            set;
        }

        /// <summary>Configures block I/O cgroup tuning for the whole domain, such as global I/O weight or per-device throttling limits.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block_io_tune Domain#block_io_tune}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockIoTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainBlockIoTune\"}", isOptional: true)]
        public libvirt.Domain.IDomainBlockIoTune? BlockIoTune
        {
            get;
            set;
        }

        /// <summary>Specifies the host-side bootloader program to invoke instead of firmware/BIOS when starting the guest (e.g. `pygrub` for Xen or `bhyveload` for bhyve); the value is user-provided and driver-specific.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-bootloader">https://libvirt.org/formatdomain.html#host-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bootloader Domain#bootloader}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootloader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bootloader
        {
            get;
            set;
        }

        /// <summary>Provides additional command-line arguments passed to the host bootloader defined by `bootloader`;</summary>
        /// <remarks>
        /// the value is a free-form string interpreted by the bootloader.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-bootloader">https://libvirt.org/formatdomain.html#host-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bootloader_args Domain#bootloader_args}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootloaderArgs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BootloaderArgs
        {
            get;
            set;
        }

        /// <summary>Configures the guest’s clock source and base time behavior, including offset, starting point, and timers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clock Domain#clock}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clock", typeJson: "{\"fqn\":\"libvirt.domain.DomainClock\"}", isOptional: true)]
        public libvirt.Domain.IDomainClock? Clock
        {
            get;
            set;
        }

        /// <summary>Configures the virtual CPU model, features, cache, topology, and related behavior presented to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cpu Domain#cpu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpu\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpu? Cpu
        {
            get;
            set;
        }

        /// <summary>Configures CPU scheduling and tuning parameters for the domain, including vCPU pinning, quotas, cache tuning, and IOThread scheduling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cpu_tune Domain#cpu_tune}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTune\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuTune? CpuTune
        {
            get;
            set;
        }

        /// <summary>Start behavior flags passed to libvirt when running is true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#create Domain#create}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.domain.DomainCreate\"}", isOptional: true)]
        public libvirt.Domain.IDomainCreate? Create
        {
            get;
            set;
        }

        /// <summary>Sets the amount of guest memory that is actually allocated at boot (in the specified unit), which may be less than the maximum `memory` to allow for memory hotplug.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#current_memory Domain#current_memory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currentMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CurrentMemory
        {
            get;
            set;
        }

        /// <summary>Sets the unit of measurement for the domain's currentMemory value (for example KiB or MiB);</summary>
        /// <remarks>
        /// if omitted, libvirt uses its default unit (usually KiB).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#current_memory_unit Domain#current_memory_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currentMemoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrentMemoryUnit
        {
            get;
            set;
        }

        /// <summary>Configures the default IOThread settings for the domain, including optional thread pool sizing for IOThreads created implicitly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#default_io_thread Domain#default_io_thread}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultIoThread", typeJson: "{\"fqn\":\"libvirt.domain.DomainDefaultIoThread\"}", isOptional: true)]
        public libvirt.Domain.IDomainDefaultIoThread? DefaultIoThread
        {
            get;
            set;
        }

        /// <summary>Sets a free‑form human‑readable description for the domain; content is user‑provided text without strict constraints.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#description Domain#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Destroy behavior when Terraform removes the domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#destroy Domain#destroy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destroy", typeJson: "{\"fqn\":\"libvirt.domain.DomainDestroy\"}", isOptional: true)]
        public libvirt.Domain.IDomainDestroy? Destroy
        {
            get;
            set;
        }

        /// <summary>Groups all device definitions attached to the domain, including disks, interfaces, audio, video, and other hardware devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#devices Domain#devices}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevices\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevices? Devices
        {
            get;
            set;
        }

        /// <summary>Enables and configures hypervisor and CPU‑related features for the domain, such as ACPI, AIA, and other optional capabilities.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#features Domain#features}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeatures\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeatures? Features
        {
            get;
            set;
        }

        /// <summary>Sets the VM generation ID (genid) exposed to the guest, used by some operating systems to detect cloning;</summary>
        /// <remarks>
        /// value must be a user-provided 128‑bit identifier in UUID-like hexadecimal format.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gen_id Domain#gen_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "genId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GenId
        {
            get;
            set;
        }

        /// <summary>Sets the hardware UUID reported to the guest firmware/OS, typically reflected in SMBIOS;</summary>
        /// <remarks>
        /// value is user-provided and should be a standard UUID string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#hwuuid Domain#hwuuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hwuuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hwuuid
        {
            get;
            set;
        }

        /// <summary>Configures user and group ID mapping between host and guest for container-style virtualization;</summary>
        /// <remarks>
        /// presence of this block enables explicit uid/gid mapping.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id_map Domain#id_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idMap", typeJson: "{\"fqn\":\"libvirt.domain.DomainIdMap\"}", isOptional: true)]
        public libvirt.Domain.IDomainIdMap? IdMap
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#iommufd Domain#iommufd}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iommufd", typeJson: "{\"fqn\":\"libvirt.domain.DomainIommufd\"}", isOptional: true)]
        public libvirt.Domain.IDomainIommufd? Iommufd
        {
            get;
            set;
        }

        /// <summary>Configures the set of IOThread IDs available to the domain, allowing explicit control over which IOThreads exist.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_thread_i_ds Domain#io_thread_i_ds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThreadIDs", typeJson: "{\"fqn\":\"libvirt.domain.DomainIoThreadIDs\"}", isOptional: true)]
        public libvirt.Domain.IDomainIoThreadIDs? IoThreadIDs
        {
            get;
            set;
        }

        /// <summary>Sets the total number of IOThreads allocated for the domain, improving block I/O scalability;</summary>
        /// <remarks>
        /// the value is user‑provided (positive integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#io_threads Domain#io_threads}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IoThreads
        {
            get;
            set;
        }

        /// <summary>Configures whether the guest is allowed to perform s390 key-wrapping cryptographic operations and which ciphers are permitted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#key_wrap Domain#key_wrap}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyWrap", typeJson: "{\"fqn\":\"libvirt.domain.DomainKeyWrap\"}", isOptional: true)]
        public libvirt.Domain.IDomainKeyWrap? KeyWrap
        {
            get;
            set;
        }

        /// <summary>Configures hardware-backed launch or confidential-computing security for the domain (such as s390-pv, AMD SEV, or SEV-SNP), with sub-blocks selecting the specific technology.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#launch_security Domain#launch_security}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchSecurity", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecurity\"}", isOptional: true)]
        public libvirt.Domain.IDomainLaunchSecurity? LaunchSecurity
        {
            get;
            set;
        }

        /// <summary>Configures inherited Linux namespaces for LXC guests, allowing selected namespaces to be shared with another process or namespace provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#lxc_namespace Domain#lxc_namespace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lxcNamespace", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespace\"}", isOptional: true)]
        public libvirt.Domain.IDomainLxcNamespace? LxcNamespace
        {
            get;
            set;
        }

        /// <summary>Sets the maximum hot-pluggable memory capacity for the guest (maxMemory value), in units given by domain.maximum_memory_unit; must be greater than or equal to the initial memory size.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#maximum_memory Domain#maximum_memory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximumMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumMemory
        {
            get;
            set;
        }

        /// <summary>Sets the number of memory slots available for hot-plugging guest memory devices, corresponding to the slots attribute of maxMemory;</summary>
        /// <remarks>
        /// value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#maximum_memory_slots Domain#maximum_memory_slots}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximumMemorySlots", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumMemorySlots
        {
            get;
            set;
        }

        /// <summary>Sets the unit for the maximum hot-pluggable memory value (for example, "KiB", "MiB", or "GiB"), corresponding to the unit attribute of maxMemory;</summary>
        /// <remarks>
        /// value is user-provided but must be a libvirt-supported memory unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#maximum_memory_unit Domain#maximum_memory_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximumMemoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumMemoryUnit
        {
            get;
            set;
        }

        /// <summary>Sets the maximum memory allocation for the guest at boot time;</summary>
        /// <remarks>
        /// the value is user-provided and interpreted in libvirt memory units (typically KiB unless a unit is specified elsewhere).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory Domain#memory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Memory
        {
            get;
            set;
        }

        /// <summary>Configures how the guest’s RAM is backed by host memory, including huge pages, locking, sharing, access policy, allocation policy, and discard behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_backing Domain#memory_backing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryBacking", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBacking\"}", isOptional: true)]
        public libvirt.Domain.IDomainMemoryBacking? MemoryBacking
        {
            get;
            set;
        }

        /// <summary>Controls whether guest memory is included in the core dump when the domain crashes, by setting the memory attribute (dumpCore) on the domain element;</summary>
        /// <remarks>
        /// valid values are user-provided according to libvirt’s dumpCore policy (e.g. enabling or disabling memory dumping).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_dump_core Domain#memory_dump_core}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryDumpCore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MemoryDumpCore
        {
            get;
            set;
        }

        /// <summary>Configures memory tuning parameters for the guest, including soft, hard, and swap limits and minimum guarantees.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_tune Domain#memory_tune}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryTune\"}", isOptional: true)]
        public libvirt.Domain.IDomainMemoryTune? MemoryTune
        {
            get;
            set;
        }

        /// <summary>Sets the unit for the domain’s main memory value, typically as a memory size unit such as KiB, MiB, or GiB;</summary>
        /// <remarks>
        /// the string is user-provided and must match libvirt’s accepted memory units.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#memory_unit Domain#memory_unit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MemoryUnit
        {
            get;
            set;
        }

        /// <summary>Configures an arbitrary metadata block associated with the domain, typically used to store application- or tool-specific XML or other structured data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#metadata Domain#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"libvirt.domain.DomainMetadata\"}", isOptional: true)]
        public libvirt.Domain.IDomainMetadata? Metadata
        {
            get;
            set;
        }

        /// <summary>Configures NUMA policy for the domain process and its memory, controlling how guest CPUs and memory are placed on host NUMA nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#numa_tune Domain#numa_tune}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numaTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainNumaTune\"}", isOptional: true)]
        public libvirt.Domain.IDomainNumaTune? NumaTune
        {
            get;
            set;
        }

        /// <summary>Sets the action libvirt takes when the guest crashes;</summary>
        /// <remarks>
        /// valid values include "destroy", "restart", "preserve", "coredump-destroy", "coredump-restart", "rename-restart", "ignore", or "pause". Example: "coredump-restart" keeps a crash dump and then restarts the domain.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#on_crash Domain#on_crash}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onCrash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnCrash
        {
            get;
            set;
        }

        /// <summary>Sets the action libvirt takes when the guest issues a poweroff/shutdown;</summary>
        /// <remarks>
        /// valid values include "destroy", "restart", "preserve", or "rename-restart". If unset, the hypervisor default is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#on_poweroff Domain#on_poweroff}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onPoweroff", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnPoweroff
        {
            get;
            set;
        }

        /// <summary>Sets the action libvirt takes when the guest reboots;</summary>
        /// <remarks>
        /// valid values include "destroy", "restart", "preserve", "rename-restart", "ignore", or "pause". If unset, the hypervisor default is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#on_reboot Domain#on_reboot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onReboot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnReboot
        {
            get;
            set;
        }

        /// <summary>Groups configuration of how the guest operating system is booted, including firmware, BIOS, boot devices, kernel parameters, and related options.</summary>
        /// <remarks>
        /// All sub-attributes are optional and user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#os Domain#os}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "os", typeJson: "{\"fqn\":\"libvirt.domain.DomainOs\"}", isOptional: true)]
        public libvirt.Domain.IDomainOs? Os
        {
            get;
            set;
        }

        /// <summary>Enables configuration of performance monitoring events exposed to the guest and collected by the hypervisor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#perf Domain#perf}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perf", typeJson: "{\"fqn\":\"libvirt.domain.DomainPerf\"}", isOptional: true)]
        public libvirt.Domain.IDomainPerf? Perf
        {
            get;
            set;
        }

        /// <summary>Configures power management behavior advertised to the guest, such as support for suspend-to-RAM and suspend-to-disk.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pm Domain#pm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pm", typeJson: "{\"fqn\":\"libvirt.domain.DomainPm\"}", isOptional: true)]
        public libvirt.Domain.IDomainPm? Pm
        {
            get;
            set;
        }

        /// <summary>Configures QEMU capability toggles through the QEMU namespace, allowing named capabilities to be explicitly added to or removed from the launched device model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_capabilities Domain#qemu_capabilities}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuCapabilities", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuCapabilities\"}", isOptional: true)]
        public libvirt.Domain.IDomainQemuCapabilities? QemuCapabilities
        {
            get;
            set;
        }

        /// <summary>Configures QEMU-specific command-line passthrough for a domain, allowing explicit extra arguments and environment variables to be passed through the dedicated QEMU XML namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_commandline Domain#qemu_commandline}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuCommandline\"}", isOptional: true)]
        public libvirt.Domain.IDomainQemuCommandline? QemuCommandline
        {
            get;
            set;
        }

        /// <summary>Configures the QEMU namespace deprecation behavior for the domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_deprecation Domain#qemu_deprecation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuDeprecation", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuDeprecation\"}", isOptional: true)]
        public libvirt.Domain.IDomainQemuDeprecation? QemuDeprecation
        {
            get;
            set;
        }

        /// <summary>Configures QEMU frontend property overrides in the QEMU namespace, targeting specific devices by alias and setting named frontend properties.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#qemu_override Domain#qemu_override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuOverride\"}", isOptional: true)]
        public libvirt.Domain.IDomainQemuOverride? QemuOverride
        {
            get;
            set;
        }

        /// <summary>Groups resource-partitioning settings that associate the domain with hypervisor-specific resource partitions or classes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#resource Domain#resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"libvirt.domain.DomainResource\"}", isOptional: true)]
        public libvirt.Domain.IDomainResource? Resource
        {
            get;
            set;
        }

        private object? _running;

        /// <summary>Whether the domain should be started after creation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#running Domain#running}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "running", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Running
        {
            get => _running;
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
                _running = value;
            }
        }

        private object? _secLabel;

        /// <summary>Configures one security label configuration for the domain, controlling how a security driver (such as SELinux or DAC) labels and isolates the domain and its resources.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sec_label Domain#sec_label}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSecLabel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecLabel
        {
            get => _secLabel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainSecLabel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSecLabel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secLabel = value;
            }
        }

        private object? _sysInfo;

        /// <summary>Configures system information presented to the guest (such as SMBIOS and fw_cfg data), allowing customization of what hardware/firmware details the guest sees.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_info Domain#sys_info}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfo" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SysInfo
        {
            get => _sysInfo;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainSysInfo[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfo).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sysInfo = value;
            }
        }

        /// <summary>Enables configuration of one or more named disk I/O throttle groups that can be referenced by disk `throttlefilters` to apply shared I/O rate limits.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#throttle_groups Domain#throttle_groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "throttleGroups", typeJson: "{\"fqn\":\"libvirt.domain.DomainThrottleGroups\"}", isOptional: true)]
        public libvirt.Domain.IDomainThrottleGroups? ThrottleGroups
        {
            get;
            set;
        }

        /// <summary>Sets a human‑readable title for the domain, which is user‑provided free text and may be used by management tools but has no functional effect on the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#title Domain#title}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Title
        {
            get;
            set;
        }

        /// <summary>Update behavior when Terraform must stop the domain before redefining it.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#update Domain#update}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"fqn\":\"libvirt.domain.DomainUpdate\"}", isOptional: true)]
        public libvirt.Domain.IDomainUpdate? Update
        {
            get;
            set;
        }

        /// <summary>Sets the maximum number of virtual CPUs configured for the guest, as a positive integer within the hypervisor’s supported range (for example 1–255).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu Domain#vcpu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Vcpu
        {
            get;
            set;
        }

        /// <summary>Sets the optional CPU affinity for all vCPUs using a cpuset expression (for example "0-3,8"), corresponding to the vcpu element’s cpuset attribute.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu_cpuset Domain#vcpu_cpuset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpuCpuset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VcpuCpuset
        {
            get;
            set;
        }

        /// <summary>Sets the number of vCPUs that are initially online at boot via the vcpu element’s current attribute, as a positive integer not exceeding domain.vcpu.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu_current Domain#vcpu_current}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpuCurrent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VcpuCurrent
        {
            get;
            set;
        }

        /// <summary>Sets the vCPU placement policy via the vcpu element’s placement attribute, typically "static" or "auto", controlling whether libvirt chooses NUMA/CPU placement automatically.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpu_placement Domain#vcpu_placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpuPlacement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VcpuPlacement
        {
            get;
            set;
        }

        /// <summary>Enables per‑vCPU configuration;</summary>
        /// <remarks>
        /// when present, it contains one or more vcpu entries that can individually control online state and pinning.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpus", typeJson: "{\"fqn\":\"libvirt.domain.DomainVcpus\"}", isOptional: true)]
        public libvirt.Domain.IDomainVcpus? Vcpus
        {
            get;
            set;
        }

        /// <summary>Sets the VMware datacenter path associated with the domain when using the VMware driver, matching the datacenter-oriented path conventions used by libvirt `vpx://` connections.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvesx.html">https://libvirt.org/drvesx.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vmware_data_center_path Domain#vmware_data_center_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmwareDataCenterPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VmwareDataCenterPath
        {
            get;
            set;
        }

        /// <summary>Configures Xen-specific command-line passthrough to the qemu device model, using the Xen XML namespace for additional arguments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xen_commandline Domain#xen_commandline}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xenCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainXenCommandline\"}", isOptional: true)]
        public libvirt.Domain.IDomainXenCommandline? XenCommandline
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
