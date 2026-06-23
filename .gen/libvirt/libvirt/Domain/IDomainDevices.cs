using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevices), fullyQualifiedName: "libvirt.domain.DomainDevices")]
    public interface IDomainDevices
    {
        /// <summary>Configures one or more audio backend definitions that map virtual sound devices in the guest to host audio backends.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#audios Domain#audios}
        /// </remarks>
        [JsiiProperty(name: "audios", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesAudios\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Audios
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more guest channel devices, which provide private communication paths between host and guest (for example, virtio channels for agents or SPICE).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#channels Domain#channels}
        /// </remarks>
        [JsiiProperty(name: "channels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesChannels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Channels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more console devices for the guest, defining how serial consoles are exposed and connected.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#console">https://libvirt.org/formatdomain.html#console</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#consoles Domain#consoles}
        /// </remarks>
        [JsiiProperty(name: "consoles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesConsoles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Consoles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares one or more device controllers (PCI, USB, SCSI, virtio-serial, etc.) attached to the guest, controlling how device buses are exposed.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#controllers Domain#controllers}
        /// </remarks>
        [JsiiProperty(name: "controllers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Controllers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a virtio-based crypto device that offloads cryptographic operations to the host;</summary>
        /// <remarks>
        /// the device type and backend parameters are specified in its child attributes.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#crypto Domain#crypto}
        /// </remarks>
        [JsiiProperty(name: "crypto", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesCrypto\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Crypto
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares one or more block devices (disks, CD-ROMs, etc.) attached to the guest, each with its own source, target, and optional tuning parameters.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#disks Domain#disks}
        /// </remarks>
        [JsiiProperty(name: "disks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the absolute path to the hypervisor emulator binary used to run this domain (for example "/usr/bin/qemu-system-x86_64").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#devices">https://libvirt.org/formatdomain.html#devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#emulator Domain#emulator}
        /// </remarks>
        [JsiiProperty(name: "emulator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Emulator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares one or more filesystem devices that expose host directories or block devices into the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#filesystems Domain#filesystems}
        /// </remarks>
        [JsiiProperty(name: "filesystems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filesystems
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more graphical framebuffer devices (such as VNC, SPICE, or DBus-based displays) for the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#graphics Domain#graphics}
        /// </remarks>
        [JsiiProperty(name: "graphics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Graphics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more hostdev entries describing host devices (PCI, USB, SCSI, etc.) that are passed through directly to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hostdevs Domain#hostdevs}
        /// </remarks>
        [JsiiProperty(name: "hostdevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hostdevs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares one or more virtual hub devices attached to a guest bus, typically to provide additional USB ports to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hub-devices">https://libvirt.org/formatdomain.html#hub-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hubs Domain#hubs}
        /// </remarks>
        [JsiiProperty(name: "hubs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHubs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hubs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares one or more guest input devices such as tablets, mice, or keyboards, and configures their type, bus, and optional passthrough settings.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#inputs Domain#inputs}
        /// </remarks>
        [JsiiProperty(name: "inputs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInputs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Inputs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more network interface devices attached to the guest, including their connection mode, model, addressing, and related options.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interfaces Domain#interfaces}
        /// </remarks>
        [JsiiProperty(name: "interfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Interfaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an IOMMU device for the guest, enabling emulated or paravirtual IOMMU functionality;</summary>
        /// <remarks>
        /// requires a model and may include driver and ACPI options.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#iommu Domain#iommu}
        /// </remarks>
        [JsiiProperty(name: "iommu", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesIommu? Iommu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more device leases that must be acquired by the lock manager before the domain can start, each represented as a lease entry.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#leases Domain#leases}
        /// </remarks>
        [JsiiProperty(name: "leases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesLeases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Leases
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the guest memory balloon device, which allows the host to dynamically adjust the guest’s available memory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mem_balloon Domain#mem_balloon}
        /// </remarks>
        [JsiiProperty(name: "memBalloon", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloon\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesMemBalloon? MemBalloon
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more memory device entries (DIMM, NVDIMM, virtio-mem, etc.) that provide additional, hot-pluggable memory to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memorydevs Domain#memorydevs}
        /// </remarks>
        [JsiiProperty(name: "memorydevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Memorydevs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Adds an NVRAM device to the domain, allowing firmware or platform-specific non-volatile state to be stored separately from normal disks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nvram Domain#nvram}
        /// </remarks>
        [JsiiProperty(name: "nvram", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesNvram\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesNvram? Nvram
        {
            get
            {
                return null;
            }
        }

        /// <summary>Adds one or more panic devices that report guest panic events to the host, allowing external monitoring or automation on guest crashes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#panic-device">https://libvirt.org/formatdomain.html#panic-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#panics Domain#panics}
        /// </remarks>
        [JsiiProperty(name: "panics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesPanics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Panics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more parallel port character devices exposed to the guest, each represented by a parallel element with optional address, backend, and logging settings.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#parallel-port">https://libvirt.org/formatdomain.html#parallel-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#parallels Domain#parallels}
        /// </remarks>
        [JsiiProperty(name: "parallels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesParallels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parallels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Adds a pstore device to the guest for persistent storage of kernel oops/panic logs, mapping to a host backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pstore Domain#pstore}
        /// </remarks>
        [JsiiProperty(name: "pstore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstore\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesPstore? Pstore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more redirected USB devices exposed to the guest via redirdev, typically used in conjunction with SPICE or similar frontends.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#redir_devs Domain#redir_devs}
        /// </remarks>
        [JsiiProperty(name: "redirDevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedirDevs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more USB redirection filter rules that determine which redirected USB devices are allowed or denied to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#redir_filters Domain#redir_filters}
        /// </remarks>
        [JsiiProperty(name: "redirFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedirFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more virtual random number generator devices attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rngs Domain#rngs}
        /// </remarks>
        [JsiiProperty(name: "rngs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRngs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rngs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more virtual serial port devices attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#serials Domain#serials}
        /// </remarks>
        [JsiiProperty(name: "serials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSerials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Serials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more shared memory (ivshmem/shmem) devices used to share memory regions between this guest, other guests, and/or the host.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shmems Domain#shmems}
        /// </remarks>
        [JsiiProperty(name: "shmems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesShmems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Shmems
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more virtual smartcard devices attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#smartcards Domain#smartcards}
        /// </remarks>
        [JsiiProperty(name: "smartcards", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSmartcards\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Smartcards
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more virtual sound devices attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sounds Domain#sounds}
        /// </remarks>
        [JsiiProperty(name: "sounds", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSounds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sounds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more TPM devices attached to the guest, including their backend implementation, addressing, and optional ACPI integration.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tpms Domain#tpms}
        /// </remarks>
        [JsiiProperty(name: "tpms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesTpms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tpms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more video devices attached to the guest, each providing a virtual graphics adapter.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#videos Domain#videos}
        /// </remarks>
        [JsiiProperty(name: "videos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesVideos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Videos
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a virtio vsock device that provides a host/guest communication channel using a CID-based socket interface.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vsock Domain#vsock}
        /// </remarks>
        [JsiiProperty(name: "vsock", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesVsock? Vsock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more virtual watchdog devices attached to the guest, each controlling timeout behavior and actions on failure.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#watchdog-devices">https://libvirt.org/formatdomain.html#watchdog-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#watchdogs Domain#watchdogs}
        /// </remarks>
        [JsiiProperty(name: "watchdogs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesWatchdogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Watchdogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevices), fullyQualifiedName: "libvirt.domain.DomainDevices")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures one or more audio backend definitions that map virtual sound devices in the guest to host audio backends.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#audios Domain#audios}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audios", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesAudios\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Audios
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more guest channel devices, which provide private communication paths between host and guest (for example, virtio channels for agents or SPICE).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#channels Domain#channels}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "channels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesChannels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Channels
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one or more console devices for the guest, defining how serial consoles are exposed and connected.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#console">https://libvirt.org/formatdomain.html#console</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#consoles Domain#consoles}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consoles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesConsoles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Consoles
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Declares one or more device controllers (PCI, USB, SCSI, virtio-serial, etc.) attached to the guest, controlling how device buses are exposed.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#controllers Domain#controllers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controllers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Controllers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures a virtio-based crypto device that offloads cryptographic operations to the host;</summary>
            /// <remarks>
            /// the device type and backend parameters are specified in its child attributes.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#crypto Domain#crypto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crypto", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesCrypto\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Crypto
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Declares one or more block devices (disks, CD-ROMs, etc.) attached to the guest, each with its own source, target, and optional tuning parameters.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#disks Domain#disks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Disks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the absolute path to the hypervisor emulator binary used to run this domain (for example "/usr/bin/qemu-system-x86_64").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#devices">https://libvirt.org/formatdomain.html#devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#emulator Domain#emulator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emulator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Emulator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Declares one or more filesystem devices that expose host directories or block devices into the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#filesystems Domain#filesystems}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filesystems
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one or more graphical framebuffer devices (such as VNC, SPICE, or DBus-based displays) for the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#graphics Domain#graphics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "graphics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Graphics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more hostdev entries describing host devices (PCI, USB, SCSI, etc.) that are passed through directly to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hostdevs Domain#hostdevs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostdevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Hostdevs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Declares one or more virtual hub devices attached to a guest bus, typically to provide additional USB ports to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hub-devices">https://libvirt.org/formatdomain.html#hub-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hubs Domain#hubs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hubs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHubs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Hubs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Declares one or more guest input devices such as tablets, mice, or keyboards, and configures their type, bus, and optional passthrough settings.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#inputs Domain#inputs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInputs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Inputs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more network interface devices attached to the guest, including their connection mode, model, addressing, and related options.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interfaces Domain#interfaces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Interfaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures an IOMMU device for the guest, enabling emulated or paravirtual IOMMU functionality;</summary>
            /// <remarks>
            /// requires a model and may include driver and ACPI options.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#iommu Domain#iommu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iommu", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesIommu\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesIommu? Iommu
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesIommu?>();
            }

            /// <summary>Configures one or more device leases that must be acquired by the lock manager before the domain can start, each represented as a lease entry.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#leases Domain#leases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "leases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesLeases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Leases
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures the guest memory balloon device, which allows the host to dynamically adjust the guest’s available memory.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mem_balloon Domain#mem_balloon}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memBalloon", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloon\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesMemBalloon? MemBalloon
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesMemBalloon?>();
            }

            /// <summary>Defines one or more memory device entries (DIMM, NVDIMM, virtio-mem, etc.) that provide additional, hot-pluggable memory to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memorydevs Domain#memorydevs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memorydevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Memorydevs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Adds an NVRAM device to the domain, allowing firmware or platform-specific non-volatile state to be stored separately from normal disks.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nvram Domain#nvram}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nvram", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesNvram\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesNvram? Nvram
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesNvram?>();
            }

            /// <summary>Adds one or more panic devices that report guest panic events to the host, allowing external monitoring or automation on guest crashes.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#panic-device">https://libvirt.org/formatdomain.html#panic-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#panics Domain#panics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "panics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesPanics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Panics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one or more parallel port character devices exposed to the guest, each represented by a parallel element with optional address, backend, and logging settings.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#parallel-port">https://libvirt.org/formatdomain.html#parallel-port</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#parallels Domain#parallels}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parallels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesParallels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Parallels
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Adds a pstore device to the guest for persistent storage of kernel oops/panic logs, mapping to a host backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pstore Domain#pstore}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pstore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstore\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesPstore? Pstore
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesPstore?>();
            }

            /// <summary>Configures one or more redirected USB devices exposed to the guest via redirdev, typically used in conjunction with SPICE or similar frontends.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#redir_devs Domain#redir_devs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirDevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RedirDevs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one or more USB redirection filter rules that determine which redirected USB devices are allowed or denied to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#redir_filters Domain#redir_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RedirFilters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more virtual random number generator devices attached to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rngs Domain#rngs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rngs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRngs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rngs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one or more virtual serial port devices attached to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#serials Domain#serials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSerials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Serials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more shared memory (ivshmem/shmem) devices used to share memory regions between this guest, other guests, and/or the host.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shmems Domain#shmems}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shmems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesShmems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Shmems
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more virtual smartcard devices attached to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#smartcards Domain#smartcards}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smartcards", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSmartcards\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Smartcards
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one or more virtual sound devices attached to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sounds Domain#sounds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sounds", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSounds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Sounds
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one or more TPM devices attached to the guest, including their backend implementation, addressing, and optional ACPI integration.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tpms Domain#tpms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tpms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesTpms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tpms
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more video devices attached to the guest, each providing a virtual graphics adapter.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#videos Domain#videos}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "videos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesVideos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Videos
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures a virtio vsock device that provides a host/guest communication channel using a CID-based socket interface.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vsock Domain#vsock}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vsock", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsock\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesVsock? Vsock
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesVsock?>();
            }

            /// <summary>Configures one or more virtual watchdog devices attached to the guest, each controlling timeout behavior and actions on failure.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#watchdog-devices">https://libvirt.org/formatdomain.html#watchdog-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#watchdogs Domain#watchdogs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "watchdogs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesWatchdogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Watchdogs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
