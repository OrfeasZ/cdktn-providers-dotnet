using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainConfig), fullyQualifiedName: "libvirt.domain.DomainConfig")]
    public interface IDomainConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Sets the domain’s short name, which must be unique on the host and consist only of alphanumeric characters.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Sets the hypervisor type used to run the domain (for example "kvm", "qemu", or "xen");</summary>
        /// <remarks>
        /// this is required and must be a valid libvirt domain driver name for the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#element-and-attribute-overview">https://libvirt.org/formatdomain.html#element-and-attribute-overview</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Whether the domain should be started automatically when the host boots.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#autostart Domain#autostart}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Autostart
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures bhyve-specific command-line passthrough for a domain, allowing extra arguments and environment variables to be appended through the bhyve XML namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bhyve_commandline Domain#bhyve_commandline}
        /// </remarks>
        [JsiiProperty(name: "bhyveCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainBhyveCommandline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainBhyveCommandline? BhyveCommandline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures block I/O cgroup tuning for the whole domain, such as global I/O weight or per-device throttling limits.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#block_io_tune Domain#block_io_tune}
        /// </remarks>
        [JsiiProperty(name: "blockIoTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainBlockIoTune\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainBlockIoTune? BlockIoTune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the host-side bootloader program to invoke instead of firmware/BIOS when starting the guest (e.g. `pygrub` for Xen or `bhyveload` for bhyve); the value is user-provided and driver-specific.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-bootloader">https://libvirt.org/formatdomain.html#host-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bootloader Domain#bootloader}
        /// </remarks>
        [JsiiProperty(name: "bootloader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bootloader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides additional command-line arguments passed to the host bootloader defined by `bootloader`;</summary>
        /// <remarks>
        /// the value is a free-form string interpreted by the bootloader.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-bootloader">https://libvirt.org/formatdomain.html#host-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bootloader_args Domain#bootloader_args}
        /// </remarks>
        [JsiiProperty(name: "bootloaderArgs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BootloaderArgs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the guest’s clock source and base time behavior, including offset, starting point, and timers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#clock Domain#clock}
        /// </remarks>
        [JsiiProperty(name: "clock", typeJson: "{\"fqn\":\"libvirt.domain.DomainClock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainClock? Clock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the virtual CPU model, features, cache, topology, and related behavior presented to the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpu Domain#cpu}
        /// </remarks>
        [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainCpu? Cpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures CPU scheduling and tuning parameters for the domain, including vCPU pinning, quotas, cache tuning, and IOThread scheduling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpu_tune Domain#cpu_tune}
        /// </remarks>
        [JsiiProperty(name: "cpuTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTune\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainCpuTune? CpuTune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Start behavior flags passed to libvirt when running is true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#create Domain#create}
        /// </remarks>
        [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.domain.DomainCreate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainCreate? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the amount of guest memory that is actually allocated at boot (in the specified unit), which may be less than the maximum `memory` to allow for memory hotplug.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#current_memory Domain#current_memory}
        /// </remarks>
        [JsiiProperty(name: "currentMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CurrentMemory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit of measurement for the domain's currentMemory value (for example KiB or MiB);</summary>
        /// <remarks>
        /// if omitted, libvirt uses its default unit (usually KiB).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#current_memory_unit Domain#current_memory_unit}
        /// </remarks>
        [JsiiProperty(name: "currentMemoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CurrentMemoryUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the default IOThread settings for the domain, including optional thread pool sizing for IOThreads created implicitly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#default_io_thread Domain#default_io_thread}
        /// </remarks>
        [JsiiProperty(name: "defaultIoThread", typeJson: "{\"fqn\":\"libvirt.domain.DomainDefaultIoThread\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDefaultIoThread? DefaultIoThread
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets a free‑form human‑readable description for the domain; content is user‑provided text without strict constraints.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#description Domain#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Destroy behavior when Terraform removes the domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#destroy Domain#destroy}
        /// </remarks>
        [JsiiProperty(name: "destroy", typeJson: "{\"fqn\":\"libvirt.domain.DomainDestroy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDestroy? Destroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Groups all device definitions attached to the domain, including disks, interfaces, audio, video, and other hardware devices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#devices Domain#devices}
        /// </remarks>
        [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevices\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevices? Devices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures hypervisor and CPU‑related features for the domain, such as ACPI, AIA, and other optional capabilities.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#features Domain#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeatures\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeatures? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the VM generation ID (genid) exposed to the guest, used by some operating systems to detect cloning;</summary>
        /// <remarks>
        /// value must be a user-provided 128‑bit identifier in UUID-like hexadecimal format.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gen_id Domain#gen_id}
        /// </remarks>
        [JsiiProperty(name: "genId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GenId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the hardware UUID reported to the guest firmware/OS, typically reflected in SMBIOS;</summary>
        /// <remarks>
        /// value is user-provided and should be a standard UUID string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hwuuid Domain#hwuuid}
        /// </remarks>
        [JsiiProperty(name: "hwuuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hwuuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures user and group ID mapping between host and guest for container-style virtualization;</summary>
        /// <remarks>
        /// presence of this block enables explicit uid/gid mapping.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id_map Domain#id_map}
        /// </remarks>
        [JsiiProperty(name: "idMap", typeJson: "{\"fqn\":\"libvirt.domain.DomainIdMap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainIdMap? IdMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the set of IOThread IDs available to the domain, allowing explicit control over which IOThreads exist.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread_i_ds Domain#io_thread_i_ds}
        /// </remarks>
        [JsiiProperty(name: "ioThreadIDs", typeJson: "{\"fqn\":\"libvirt.domain.DomainIoThreadIDs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainIoThreadIDs? IoThreadIDs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the total number of IOThreads allocated for the domain, improving block I/O scalability;</summary>
        /// <remarks>
        /// the value is user‑provided (positive integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_threads Domain#io_threads}
        /// </remarks>
        [JsiiProperty(name: "ioThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IoThreads
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures whether the guest is allowed to perform s390 key-wrapping cryptographic operations and which ciphers are permitted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#key_wrap Domain#key_wrap}
        /// </remarks>
        [JsiiProperty(name: "keyWrap", typeJson: "{\"fqn\":\"libvirt.domain.DomainKeyWrap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainKeyWrap? KeyWrap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures hardware-backed launch or confidential-computing security for the domain (such as s390-pv, AMD SEV, or SEV-SNP), with sub-blocks selecting the specific technology.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#launch_security Domain#launch_security}
        /// </remarks>
        [JsiiProperty(name: "launchSecurity", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecurity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainLaunchSecurity? LaunchSecurity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inherited Linux namespaces for LXC guests, allowing selected namespaces to be shared with another process or namespace provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#lxc_namespace Domain#lxc_namespace}
        /// </remarks>
        [JsiiProperty(name: "lxcNamespace", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespace\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainLxcNamespace? LxcNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum hot-pluggable memory capacity for the guest (maxMemory value), in units given by domain.maximum_memory_unit; must be greater than or equal to the initial memory size.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#maximum_memory Domain#maximum_memory}
        /// </remarks>
        [JsiiProperty(name: "maximumMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumMemory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of memory slots available for hot-plugging guest memory devices, corresponding to the slots attribute of maxMemory;</summary>
        /// <remarks>
        /// value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#maximum_memory_slots Domain#maximum_memory_slots}
        /// </remarks>
        [JsiiProperty(name: "maximumMemorySlots", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumMemorySlots
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit for the maximum hot-pluggable memory value (for example, "KiB", "MiB", or "GiB"), corresponding to the unit attribute of maxMemory;</summary>
        /// <remarks>
        /// value is user-provided but must be a libvirt-supported memory unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#maximum_memory_unit Domain#maximum_memory_unit}
        /// </remarks>
        [JsiiProperty(name: "maximumMemoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumMemoryUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum memory allocation for the guest at boot time;</summary>
        /// <remarks>
        /// the value is user-provided and interpreted in libvirt memory units (typically KiB unless a unit is specified elsewhere).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory Domain#memory}
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Memory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures how the guest’s RAM is backed by host memory, including huge pages, locking, sharing, access policy, allocation policy, and discard behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_backing Domain#memory_backing}
        /// </remarks>
        [JsiiProperty(name: "memoryBacking", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBacking\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainMemoryBacking? MemoryBacking
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether guest memory is included in the core dump when the domain crashes, by setting the memory attribute (dumpCore) on the domain element;</summary>
        /// <remarks>
        /// valid values are user-provided according to libvirt’s dumpCore policy (e.g. enabling or disabling memory dumping).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_dump_core Domain#memory_dump_core}
        /// </remarks>
        [JsiiProperty(name: "memoryDumpCore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MemoryDumpCore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures memory tuning parameters for the guest, including soft, hard, and swap limits and minimum guarantees.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_tune Domain#memory_tune}
        /// </remarks>
        [JsiiProperty(name: "memoryTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryTune\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainMemoryTune? MemoryTune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the unit for the domain’s main memory value, typically as a memory size unit such as KiB, MiB, or GiB;</summary>
        /// <remarks>
        /// the string is user-provided and must match libvirt’s accepted memory units.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_unit Domain#memory_unit}
        /// </remarks>
        [JsiiProperty(name: "memoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MemoryUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an arbitrary metadata block associated with the domain, typically used to store application- or tool-specific XML or other structured data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#metadata Domain#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"libvirt.domain.DomainMetadata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainMetadata? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures NUMA policy for the domain process and its memory, controlling how guest CPUs and memory are placed on host NUMA nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#numa_tune Domain#numa_tune}
        /// </remarks>
        [JsiiProperty(name: "numaTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainNumaTune\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainNumaTune? NumaTune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the action libvirt takes when the guest crashes;</summary>
        /// <remarks>
        /// valid values include "destroy", "restart", "preserve", "coredump-destroy", "coredump-restart", "rename-restart", "ignore", or "pause". Example: "coredump-restart" keeps a crash dump and then restarts the domain.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#on_crash Domain#on_crash}
        /// </remarks>
        [JsiiProperty(name: "onCrash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnCrash
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the action libvirt takes when the guest issues a poweroff/shutdown;</summary>
        /// <remarks>
        /// valid values include "destroy", "restart", "preserve", or "rename-restart". If unset, the hypervisor default is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#on_poweroff Domain#on_poweroff}
        /// </remarks>
        [JsiiProperty(name: "onPoweroff", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnPoweroff
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the action libvirt takes when the guest reboots;</summary>
        /// <remarks>
        /// valid values include "destroy", "restart", "preserve", "rename-restart", "ignore", or "pause". If unset, the hypervisor default is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#on_reboot Domain#on_reboot}
        /// </remarks>
        [JsiiProperty(name: "onReboot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnReboot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Groups configuration of how the guest operating system is booted, including firmware, BIOS, boot devices, kernel parameters, and related options.</summary>
        /// <remarks>
        /// All sub-attributes are optional and user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#os Domain#os}
        /// </remarks>
        [JsiiProperty(name: "os", typeJson: "{\"fqn\":\"libvirt.domain.DomainOs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOs? Os
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of performance monitoring events exposed to the guest and collected by the hypervisor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#perf Domain#perf}
        /// </remarks>
        [JsiiProperty(name: "perf", typeJson: "{\"fqn\":\"libvirt.domain.DomainPerf\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainPerf? Perf
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures power management behavior advertised to the guest, such as support for suspend-to-RAM and suspend-to-disk.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pm Domain#pm}
        /// </remarks>
        [JsiiProperty(name: "pm", typeJson: "{\"fqn\":\"libvirt.domain.DomainPm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainPm? Pm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures QEMU capability toggles through the QEMU namespace, allowing named capabilities to be explicitly added to or removed from the launched device model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_capabilities Domain#qemu_capabilities}
        /// </remarks>
        [JsiiProperty(name: "qemuCapabilities", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuCapabilities\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainQemuCapabilities? QemuCapabilities
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures QEMU-specific command-line passthrough for a domain, allowing explicit extra arguments and environment variables to be passed through the dedicated QEMU XML namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_commandline Domain#qemu_commandline}
        /// </remarks>
        [JsiiProperty(name: "qemuCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuCommandline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainQemuCommandline? QemuCommandline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the QEMU namespace deprecation behavior for the domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_deprecation Domain#qemu_deprecation}
        /// </remarks>
        [JsiiProperty(name: "qemuDeprecation", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuDeprecation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainQemuDeprecation? QemuDeprecation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures QEMU frontend property overrides in the QEMU namespace, targeting specific devices by alias and setting named frontend properties.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_override Domain#qemu_override}
        /// </remarks>
        [JsiiProperty(name: "qemuOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuOverride\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainQemuOverride? QemuOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Groups resource-partitioning settings that associate the domain with hypervisor-specific resource partitions or classes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#resource Domain#resource}
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"libvirt.domain.DomainResource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainResource? Resource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the domain should be started after creation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#running Domain#running}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "running", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Running
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one security label configuration for the domain, controlling how a security driver (such as SELinux or DAC) labels and isolates the domain and its resources.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSecLabel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures system information presented to the guest (such as SMBIOS and fw_cfg data), allowing customization of what hardware/firmware details the guest sees.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sys_info Domain#sys_info}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfo" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sysInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SysInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of one or more named disk I/O throttle groups that can be referenced by disk `throttlefilters` to apply shared I/O rate limits.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#throttle_groups Domain#throttle_groups}
        /// </remarks>
        [JsiiProperty(name: "throttleGroups", typeJson: "{\"fqn\":\"libvirt.domain.DomainThrottleGroups\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainThrottleGroups? ThrottleGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets a human‑readable title for the domain, which is user‑provided free text and may be used by management tools but has no functional effect on the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#title Domain#title}
        /// </remarks>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Title
        {
            get
            {
                return null;
            }
        }

        /// <summary>Update behavior when Terraform must stop the domain before redefining it.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#update Domain#update}
        /// </remarks>
        [JsiiProperty(name: "update", typeJson: "{\"fqn\":\"libvirt.domain.DomainUpdate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainUpdate? Update
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum number of virtual CPUs configured for the guest, as a positive integer within the hypervisor’s supported range (for example 1–255).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu Domain#vcpu}
        /// </remarks>
        [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vcpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the optional CPU affinity for all vCPUs using a cpuset expression (for example "0-3,8"), corresponding to the vcpu element’s cpuset attribute.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu_cpuset Domain#vcpu_cpuset}
        /// </remarks>
        [JsiiProperty(name: "vcpuCpuset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VcpuCpuset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of vCPUs that are initially online at boot via the vcpu element’s current attribute, as a positive integer not exceeding domain.vcpu.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu_current Domain#vcpu_current}
        /// </remarks>
        [JsiiProperty(name: "vcpuCurrent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VcpuCurrent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the vCPU placement policy via the vcpu element’s placement attribute, typically "static" or "auto", controlling whether libvirt chooses NUMA/CPU placement automatically.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu_placement Domain#vcpu_placement}
        /// </remarks>
        [JsiiProperty(name: "vcpuPlacement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VcpuPlacement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables per‑vCPU configuration;</summary>
        /// <remarks>
        /// when present, it contains one or more vcpu entries that can individually control online state and pinning.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiProperty(name: "vcpus", typeJson: "{\"fqn\":\"libvirt.domain.DomainVcpus\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainVcpus? Vcpus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the VMware datacenter path associated with the domain when using the VMware driver, matching the datacenter-oriented path conventions used by libvirt `vpx://` connections.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvesx.html">https://libvirt.org/drvesx.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vmware_data_center_path Domain#vmware_data_center_path}
        /// </remarks>
        [JsiiProperty(name: "vmwareDataCenterPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VmwareDataCenterPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures Xen-specific command-line passthrough to the qemu device model, using the Xen XML namespace for additional arguments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#xen_commandline Domain#xen_commandline}
        /// </remarks>
        [JsiiProperty(name: "xenCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainXenCommandline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainXenCommandline? XenCommandline
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainConfig), fullyQualifiedName: "libvirt.domain.DomainConfig")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the domain’s short name, which must be unique on the host and consist only of alphanumeric characters.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the hypervisor type used to run the domain (for example "kvm", "qemu", or "xen");</summary>
            /// <remarks>
            /// this is required and must be a valid libvirt domain driver name for the host.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#element-and-attribute-overview">https://libvirt.org/formatdomain.html#element-and-attribute-overview</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether the domain should be started automatically when the host boots.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#autostart Domain#autostart}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Autostart
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures bhyve-specific command-line passthrough for a domain, allowing extra arguments and environment variables to be appended through the bhyve XML namespace.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bhyve_commandline Domain#bhyve_commandline}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bhyveCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainBhyveCommandline\"}", isOptional: true)]
            public libvirt.Domain.IDomainBhyveCommandline? BhyveCommandline
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainBhyveCommandline?>();
            }

            /// <summary>Configures block I/O cgroup tuning for the whole domain, such as global I/O weight or per-device throttling limits.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#block_io_tune Domain#block_io_tune}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockIoTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainBlockIoTune\"}", isOptional: true)]
            public libvirt.Domain.IDomainBlockIoTune? BlockIoTune
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainBlockIoTune?>();
            }

            /// <summary>Specifies the host-side bootloader program to invoke instead of firmware/BIOS when starting the guest (e.g. `pygrub` for Xen or `bhyveload` for bhyve); the value is user-provided and driver-specific.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#host-bootloader">https://libvirt.org/formatdomain.html#host-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bootloader Domain#bootloader}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootloader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bootloader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides additional command-line arguments passed to the host bootloader defined by `bootloader`;</summary>
            /// <remarks>
            /// the value is a free-form string interpreted by the bootloader.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#host-bootloader">https://libvirt.org/formatdomain.html#host-bootloader</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bootloader_args Domain#bootloader_args}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootloaderArgs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BootloaderArgs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the guest’s clock source and base time behavior, including offset, starting point, and timers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#clock Domain#clock}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clock", typeJson: "{\"fqn\":\"libvirt.domain.DomainClock\"}", isOptional: true)]
            public libvirt.Domain.IDomainClock? Clock
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainClock?>();
            }

            /// <summary>Configures the virtual CPU model, features, cache, topology, and related behavior presented to the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpu Domain#cpu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpu\"}", isOptional: true)]
            public libvirt.Domain.IDomainCpu? Cpu
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainCpu?>();
            }

            /// <summary>Configures CPU scheduling and tuning parameters for the domain, including vCPU pinning, quotas, cache tuning, and IOThread scheduling.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cpu_tune Domain#cpu_tune}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpuTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTune\"}", isOptional: true)]
            public libvirt.Domain.IDomainCpuTune? CpuTune
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainCpuTune?>();
            }

            /// <summary>Start behavior flags passed to libvirt when running is true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#create Domain#create}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.domain.DomainCreate\"}", isOptional: true)]
            public libvirt.Domain.IDomainCreate? Create
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainCreate?>();
            }

            /// <summary>Sets the amount of guest memory that is actually allocated at boot (in the specified unit), which may be less than the maximum `memory` to allow for memory hotplug.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#current_memory Domain#current_memory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currentMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CurrentMemory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the unit of measurement for the domain's currentMemory value (for example KiB or MiB);</summary>
            /// <remarks>
            /// if omitted, libvirt uses its default unit (usually KiB).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#current_memory_unit Domain#current_memory_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currentMemoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CurrentMemoryUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the default IOThread settings for the domain, including optional thread pool sizing for IOThreads created implicitly.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#default_io_thread Domain#default_io_thread}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultIoThread", typeJson: "{\"fqn\":\"libvirt.domain.DomainDefaultIoThread\"}", isOptional: true)]
            public libvirt.Domain.IDomainDefaultIoThread? DefaultIoThread
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDefaultIoThread?>();
            }

            /// <summary>Sets a free‑form human‑readable description for the domain; content is user‑provided text without strict constraints.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#description Domain#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Destroy behavior when Terraform removes the domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#destroy Domain#destroy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destroy", typeJson: "{\"fqn\":\"libvirt.domain.DomainDestroy\"}", isOptional: true)]
            public libvirt.Domain.IDomainDestroy? Destroy
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDestroy?>();
            }

            /// <summary>Groups all device definitions attached to the domain, including disks, interfaces, audio, video, and other hardware devices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#devices Domain#devices}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevices\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevices? Devices
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevices?>();
            }

            /// <summary>Enables and configures hypervisor and CPU‑related features for the domain, such as ACPI, AIA, and other optional capabilities.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#features Domain#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeatures\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeatures? Features
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeatures?>();
            }

            /// <summary>Sets the VM generation ID (genid) exposed to the guest, used by some operating systems to detect cloning;</summary>
            /// <remarks>
            /// value must be a user-provided 128‑bit identifier in UUID-like hexadecimal format.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gen_id Domain#gen_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "genId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GenId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the hardware UUID reported to the guest firmware/OS, typically reflected in SMBIOS;</summary>
            /// <remarks>
            /// value is user-provided and should be a standard UUID string.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hwuuid Domain#hwuuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hwuuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hwuuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures user and group ID mapping between host and guest for container-style virtualization;</summary>
            /// <remarks>
            /// presence of this block enables explicit uid/gid mapping.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id_map Domain#id_map}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idMap", typeJson: "{\"fqn\":\"libvirt.domain.DomainIdMap\"}", isOptional: true)]
            public libvirt.Domain.IDomainIdMap? IdMap
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainIdMap?>();
            }

            /// <summary>Configures the set of IOThread IDs available to the domain, allowing explicit control over which IOThreads exist.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_thread_i_ds Domain#io_thread_i_ds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreadIDs", typeJson: "{\"fqn\":\"libvirt.domain.DomainIoThreadIDs\"}", isOptional: true)]
            public libvirt.Domain.IDomainIoThreadIDs? IoThreadIDs
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainIoThreadIDs?>();
            }

            /// <summary>Sets the total number of IOThreads allocated for the domain, improving block I/O scalability;</summary>
            /// <remarks>
            /// the value is user‑provided (positive integer).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#io_threads Domain#io_threads}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IoThreads
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures whether the guest is allowed to perform s390 key-wrapping cryptographic operations and which ciphers are permitted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#key_wrap Domain#key_wrap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyWrap", typeJson: "{\"fqn\":\"libvirt.domain.DomainKeyWrap\"}", isOptional: true)]
            public libvirt.Domain.IDomainKeyWrap? KeyWrap
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainKeyWrap?>();
            }

            /// <summary>Configures hardware-backed launch or confidential-computing security for the domain (such as s390-pv, AMD SEV, or SEV-SNP), with sub-blocks selecting the specific technology.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#launch_security Domain#launch_security}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchSecurity", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecurity\"}", isOptional: true)]
            public libvirt.Domain.IDomainLaunchSecurity? LaunchSecurity
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainLaunchSecurity?>();
            }

            /// <summary>Configures inherited Linux namespaces for LXC guests, allowing selected namespaces to be shared with another process or namespace provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#lxc_namespace Domain#lxc_namespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lxcNamespace", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespace\"}", isOptional: true)]
            public libvirt.Domain.IDomainLxcNamespace? LxcNamespace
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainLxcNamespace?>();
            }

            /// <summary>Sets the maximum hot-pluggable memory capacity for the guest (maxMemory value), in units given by domain.maximum_memory_unit; must be greater than or equal to the initial memory size.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#maximum_memory Domain#maximum_memory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumMemory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the number of memory slots available for hot-plugging guest memory devices, corresponding to the slots attribute of maxMemory;</summary>
            /// <remarks>
            /// value is a user-provided positive integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#maximum_memory_slots Domain#maximum_memory_slots}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumMemorySlots", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumMemorySlots
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the unit for the maximum hot-pluggable memory value (for example, "KiB", "MiB", or "GiB"), corresponding to the unit attribute of maxMemory;</summary>
            /// <remarks>
            /// value is user-provided but must be a libvirt-supported memory unit.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#maximum_memory_unit Domain#maximum_memory_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumMemoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumMemoryUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the maximum memory allocation for the guest at boot time;</summary>
            /// <remarks>
            /// the value is user-provided and interpreted in libvirt memory units (typically KiB unless a unit is specified elsewhere).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory Domain#memory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Memory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures how the guest’s RAM is backed by host memory, including huge pages, locking, sharing, access policy, allocation policy, and discard behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_backing Domain#memory_backing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryBacking", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBacking\"}", isOptional: true)]
            public libvirt.Domain.IDomainMemoryBacking? MemoryBacking
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainMemoryBacking?>();
            }

            /// <summary>Controls whether guest memory is included in the core dump when the domain crashes, by setting the memory attribute (dumpCore) on the domain element;</summary>
            /// <remarks>
            /// valid values are user-provided according to libvirt’s dumpCore policy (e.g. enabling or disabling memory dumping).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_dump_core Domain#memory_dump_core}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryDumpCore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MemoryDumpCore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures memory tuning parameters for the guest, including soft, hard, and swap limits and minimum guarantees.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_tune Domain#memory_tune}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryTune\"}", isOptional: true)]
            public libvirt.Domain.IDomainMemoryTune? MemoryTune
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainMemoryTune?>();
            }

            /// <summary>Sets the unit for the domain’s main memory value, typically as a memory size unit such as KiB, MiB, or GiB;</summary>
            /// <remarks>
            /// the string is user-provided and must match libvirt’s accepted memory units.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-allocation">https://libvirt.org/formatdomain.html#memory-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memory_unit Domain#memory_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MemoryUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures an arbitrary metadata block associated with the domain, typically used to store application- or tool-specific XML or other structured data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#metadata Domain#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"libvirt.domain.DomainMetadata\"}", isOptional: true)]
            public libvirt.Domain.IDomainMetadata? Metadata
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainMetadata?>();
            }

            /// <summary>Configures NUMA policy for the domain process and its memory, controlling how guest CPUs and memory are placed on host NUMA nodes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#numa_tune Domain#numa_tune}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numaTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainNumaTune\"}", isOptional: true)]
            public libvirt.Domain.IDomainNumaTune? NumaTune
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainNumaTune?>();
            }

            /// <summary>Sets the action libvirt takes when the guest crashes;</summary>
            /// <remarks>
            /// valid values include "destroy", "restart", "preserve", "coredump-destroy", "coredump-restart", "rename-restart", "ignore", or "pause". Example: "coredump-restart" keeps a crash dump and then restarts the domain.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#on_crash Domain#on_crash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onCrash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnCrash
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the action libvirt takes when the guest issues a poweroff/shutdown;</summary>
            /// <remarks>
            /// valid values include "destroy", "restart", "preserve", or "rename-restart". If unset, the hypervisor default is used.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#on_poweroff Domain#on_poweroff}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onPoweroff", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnPoweroff
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the action libvirt takes when the guest reboots;</summary>
            /// <remarks>
            /// valid values include "destroy", "restart", "preserve", "rename-restart", "ignore", or "pause". If unset, the hypervisor default is used.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#events-configuration">https://libvirt.org/formatdomain.html#events-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#on_reboot Domain#on_reboot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onReboot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnReboot
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Groups configuration of how the guest operating system is booted, including firmware, BIOS, boot devices, kernel parameters, and related options.</summary>
            /// <remarks>
            /// All sub-attributes are optional and user-provided.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#os Domain#os}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "os", typeJson: "{\"fqn\":\"libvirt.domain.DomainOs\"}", isOptional: true)]
            public libvirt.Domain.IDomainOs? Os
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOs?>();
            }

            /// <summary>Enables configuration of performance monitoring events exposed to the guest and collected by the hypervisor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#perf Domain#perf}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perf", typeJson: "{\"fqn\":\"libvirt.domain.DomainPerf\"}", isOptional: true)]
            public libvirt.Domain.IDomainPerf? Perf
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainPerf?>();
            }

            /// <summary>Configures power management behavior advertised to the guest, such as support for suspend-to-RAM and suspend-to-disk.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pm Domain#pm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pm", typeJson: "{\"fqn\":\"libvirt.domain.DomainPm\"}", isOptional: true)]
            public libvirt.Domain.IDomainPm? Pm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainPm?>();
            }

            /// <summary>Configures QEMU capability toggles through the QEMU namespace, allowing named capabilities to be explicitly added to or removed from the launched device model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_capabilities Domain#qemu_capabilities}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "qemuCapabilities", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuCapabilities\"}", isOptional: true)]
            public libvirt.Domain.IDomainQemuCapabilities? QemuCapabilities
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainQemuCapabilities?>();
            }

            /// <summary>Configures QEMU-specific command-line passthrough for a domain, allowing explicit extra arguments and environment variables to be passed through the dedicated QEMU XML namespace.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_commandline Domain#qemu_commandline}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "qemuCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuCommandline\"}", isOptional: true)]
            public libvirt.Domain.IDomainQemuCommandline? QemuCommandline
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainQemuCommandline?>();
            }

            /// <summary>Configures the QEMU namespace deprecation behavior for the domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_deprecation Domain#qemu_deprecation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "qemuDeprecation", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuDeprecation\"}", isOptional: true)]
            public libvirt.Domain.IDomainQemuDeprecation? QemuDeprecation
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainQemuDeprecation?>();
            }

            /// <summary>Configures QEMU frontend property overrides in the QEMU namespace, targeting specific devices by alias and setting named frontend properties.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#qemu_override Domain#qemu_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "qemuOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuOverride\"}", isOptional: true)]
            public libvirt.Domain.IDomainQemuOverride? QemuOverride
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainQemuOverride?>();
            }

            /// <summary>Groups resource-partitioning settings that associate the domain with hypervisor-specific resource partitions or classes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#resource Domain#resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"libvirt.domain.DomainResource\"}", isOptional: true)]
            public libvirt.Domain.IDomainResource? Resource
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainResource?>();
            }

            /// <summary>Whether the domain should be started after creation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#running Domain#running}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "running", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Running
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one security label configuration for the domain, controlling how a security driver (such as SELinux or DAC) labels and isolates the domain and its resources.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSecLabel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecLabel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures system information presented to the guest (such as SMBIOS and fw_cfg data), allowing customization of what hardware/firmware details the guest sees.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sys_info Domain#sys_info}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfo" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SysInfo
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enables configuration of one or more named disk I/O throttle groups that can be referenced by disk `throttlefilters` to apply shared I/O rate limits.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#throttle_groups Domain#throttle_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "throttleGroups", typeJson: "{\"fqn\":\"libvirt.domain.DomainThrottleGroups\"}", isOptional: true)]
            public libvirt.Domain.IDomainThrottleGroups? ThrottleGroups
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainThrottleGroups?>();
            }

            /// <summary>Sets a human‑readable title for the domain, which is user‑provided free text and may be used by management tools but has no functional effect on the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#title Domain#title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Title
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Update behavior when Terraform must stop the domain before redefining it.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#update Domain#update}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"fqn\":\"libvirt.domain.DomainUpdate\"}", isOptional: true)]
            public libvirt.Domain.IDomainUpdate? Update
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainUpdate?>();
            }

            /// <summary>Sets the maximum number of virtual CPUs configured for the guest, as a positive integer within the hypervisor’s supported range (for example 1–255).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu Domain#vcpu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vcpu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the optional CPU affinity for all vCPUs using a cpuset expression (for example "0-3,8"), corresponding to the vcpu element’s cpuset attribute.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu_cpuset Domain#vcpu_cpuset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpuCpuset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VcpuCpuset
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the number of vCPUs that are initially online at boot via the vcpu element’s current attribute, as a positive integer not exceeding domain.vcpu.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu_current Domain#vcpu_current}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpuCurrent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VcpuCurrent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the vCPU placement policy via the vcpu element’s placement attribute, typically "static" or "auto", controlling whether libvirt chooses NUMA/CPU placement automatically.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpu_placement Domain#vcpu_placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpuPlacement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VcpuPlacement
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables per‑vCPU configuration;</summary>
            /// <remarks>
            /// when present, it contains one or more vcpu entries that can individually control online state and pinning.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpus Domain#vcpus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpus", typeJson: "{\"fqn\":\"libvirt.domain.DomainVcpus\"}", isOptional: true)]
            public libvirt.Domain.IDomainVcpus? Vcpus
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainVcpus?>();
            }

            /// <summary>Sets the VMware datacenter path associated with the domain when using the VMware driver, matching the datacenter-oriented path conventions used by libvirt `vpx://` connections.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/drvesx.html">https://libvirt.org/drvesx.html</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vmware_data_center_path Domain#vmware_data_center_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vmwareDataCenterPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VmwareDataCenterPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures Xen-specific command-line passthrough to the qemu device model, using the Xen XML namespace for additional arguments.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#xen_commandline Domain#xen_commandline}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xenCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainXenCommandline\"}", isOptional: true)]
            public libvirt.Domain.IDomainXenCommandline? XenCommandline
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainXenCommandline?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
