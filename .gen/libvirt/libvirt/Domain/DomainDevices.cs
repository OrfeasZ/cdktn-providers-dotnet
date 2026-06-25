using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevices")]
    public class DomainDevices : libvirt.Domain.IDomainDevices
    {
        private object? _audios;

        /// <summary>Configures one or more audio backend definitions that map virtual sound devices in the guest to host audio backends.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#audios Domain#audios}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesAudios" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audios", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesAudios\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Audios
        {
            get => _audios;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesAudios[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesAudios).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _audios = value;
            }
        }

        private object? _channels;

        /// <summary>Defines one or more guest channel devices, which provide private communication paths between host and guest (for example, virtio channels for agents or SPICE).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#channels Domain#channels}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesChannels" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "channels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesChannels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Channels
        {
            get => _channels;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesChannels[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesChannels).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _channels = value;
            }
        }

        private object? _consoles;

        /// <summary>Configures one or more console devices for the guest, defining how serial consoles are exposed and connected.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#console">https://libvirt.org/formatdomain.html#console</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#consoles Domain#consoles}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesConsoles" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "consoles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesConsoles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Consoles
        {
            get => _consoles;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesConsoles[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesConsoles).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _consoles = value;
            }
        }

        private object? _controllers;

        /// <summary>Declares one or more device controllers (PCI, USB, SCSI, virtio-serial, etc.) attached to the guest, controlling how device buses are exposed.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#controllers Domain#controllers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesControllers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "controllers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesControllers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Controllers
        {
            get => _controllers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesControllers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesControllers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _controllers = value;
            }
        }

        private object? _crypto;

        /// <summary>Configures a virtio-based crypto device that offloads cryptographic operations to the host;</summary>
        /// <remarks>
        /// the device type and backend parameters are specified in its child attributes.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#crypto Domain#crypto}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesCrypto" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crypto", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesCrypto\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Crypto
        {
            get => _crypto;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesCrypto[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesCrypto).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _crypto = value;
            }
        }

        private object? _disks;

        /// <summary>Declares one or more block devices (disks, CD-ROMs, etc.) attached to the guest, each with its own source, target, and optional tuning parameters.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#disks Domain#disks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisks" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Disks
        {
            get => _disks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesDisks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disks = value;
            }
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
            get;
            set;
        }

        private object? _filesystems;

        /// <summary>Declares one or more filesystem devices that expose host directories or block devices into the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#filesystems Domain#filesystems}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesFilesystems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filesystems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Filesystems
        {
            get => _filesystems;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesFilesystems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesFilesystems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filesystems = value;
            }
        }

        private object? _graphics;

        /// <summary>Configures one or more graphical framebuffer devices (such as VNC, SPICE, or DBus-based displays) for the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#graphics Domain#graphics}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphics" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "graphics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Graphics
        {
            get => _graphics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesGraphics[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphics).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _graphics = value;
            }
        }

        private object? _hostdevs;

        /// <summary>Defines one or more hostdev entries describing host devices (PCI, USB, SCSI, etc.) that are passed through directly to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hostdevs Domain#hostdevs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostdevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Hostdevs
        {
            get => _hostdevs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesHostdevs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesHostdevs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hostdevs = value;
            }
        }

        private object? _hubs;

        /// <summary>Declares one or more virtual hub devices attached to a guest bus, typically to provide additional USB ports to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hub-devices">https://libvirt.org/formatdomain.html#hub-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hubs Domain#hubs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHubs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hubs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHubs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Hubs
        {
            get => _hubs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesHubs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesHubs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hubs = value;
            }
        }

        private object? _inputs;

        /// <summary>Declares one or more guest input devices such as tablets, mice, or keyboards, and configures their type, bus, and optional passthrough settings.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#input-devices">https://libvirt.org/formatdomain.html#input-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#inputs Domain#inputs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInputs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInputs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Inputs
        {
            get => _inputs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInputs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInputs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputs = value;
            }
        }

        private object? _interfaces;

        /// <summary>Defines one or more network interface devices attached to the guest, including their connection mode, model, addressing, and related options.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interfaces Domain#interfaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfaces" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Interfaces
        {
            get => _interfaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfaces[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfaces).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _interfaces = value;
            }
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
            get;
            set;
        }

        private object? _leases;

        /// <summary>Configures one or more device leases that must be acquired by the lock manager before the domain can start, each represented as a lease entry.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#leases Domain#leases}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesLeases" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "leases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesLeases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Leases
        {
            get => _leases;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesLeases[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesLeases).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _leases = value;
            }
        }

        /// <summary>Configures the guest memory balloon device, which allows the host to dynamically adjust the guest’s available memory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mem_balloon Domain#mem_balloon}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memBalloon", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesMemBalloon\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesMemBalloon? MemBalloon
        {
            get;
            set;
        }

        private object? _memorydevs;

        /// <summary>Defines one or more memory device entries (DIMM, NVDIMM, virtio-mem, etc.) that provide additional, hot-pluggable memory to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-devices">https://libvirt.org/formatdomain.html#memory-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#memorydevs Domain#memorydevs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesMemorydevs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memorydevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesMemorydevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Memorydevs
        {
            get => _memorydevs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesMemorydevs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesMemorydevs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _memorydevs = value;
            }
        }

        /// <summary>Adds an NVRAM device to the domain, allowing firmware or platform-specific non-volatile state to be stored separately from normal disks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#nvram Domain#nvram}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvram", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesNvram\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesNvram? Nvram
        {
            get;
            set;
        }

        private object? _panics;

        /// <summary>Adds one or more panic devices that report guest panic events to the host, allowing external monitoring or automation on guest crashes.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#panic-device">https://libvirt.org/formatdomain.html#panic-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#panics Domain#panics}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesPanics" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "panics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesPanics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Panics
        {
            get => _panics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesPanics[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesPanics).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _panics = value;
            }
        }

        private object? _parallels;

        /// <summary>Configures one or more parallel port character devices exposed to the guest, each represented by a parallel element with optional address, backend, and logging settings.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#parallel-port">https://libvirt.org/formatdomain.html#parallel-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#parallels Domain#parallels}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesParallels" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parallels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesParallels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parallels
        {
            get => _parallels;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesParallels[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesParallels).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parallels = value;
            }
        }

        /// <summary>Adds a pstore device to the guest for persistent storage of kernel oops/panic logs, mapping to a host backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pstore Domain#pstore}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pstore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesPstore\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesPstore? Pstore
        {
            get;
            set;
        }

        private object? _redirDevs;

        /// <summary>Configures one or more redirected USB devices exposed to the guest via redirdev, typically used in conjunction with SPICE or similar frontends.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#redir_devs Domain#redir_devs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesRedirDevs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirDevs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RedirDevs
        {
            get => _redirDevs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesRedirDevs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesRedirDevs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redirDevs = value;
            }
        }

        private object? _redirFilters;

        /// <summary>Configures one or more USB redirection filter rules that determine which redirected USB devices are allowed or denied to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#redirected-devices">https://libvirt.org/formatdomain.html#redirected-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#redir_filters Domain#redir_filters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesRedirFilters" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RedirFilters
        {
            get => _redirFilters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesRedirFilters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesRedirFilters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redirFilters = value;
            }
        }

        private object? _rngs;

        /// <summary>Defines one or more virtual random number generator devices attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rngs Domain#rngs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesRngs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rngs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRngs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rngs
        {
            get => _rngs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesRngs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesRngs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rngs = value;
            }
        }

        private object? _serials;

        /// <summary>Configures one or more virtual serial port devices attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#serial-port">https://libvirt.org/formatdomain.html#serial-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#serials Domain#serials}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesSerials" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSerials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Serials
        {
            get => _serials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesSerials[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesSerials).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serials = value;
            }
        }

        private object? _shmems;

        /// <summary>Defines one or more shared memory (ivshmem/shmem) devices used to share memory regions between this guest, other guests, and/or the host.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shmems Domain#shmems}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesShmems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shmems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesShmems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Shmems
        {
            get => _shmems;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesShmems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesShmems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shmems = value;
            }
        }

        private object? _smartcards;

        /// <summary>Defines one or more virtual smartcard devices attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#smartcards Domain#smartcards}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesSmartcards" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smartcards", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSmartcards\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Smartcards
        {
            get => _smartcards;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesSmartcards[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesSmartcards).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _smartcards = value;
            }
        }

        private object? _sounds;

        /// <summary>Configures one or more virtual sound devices attached to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#sound-devices">https://libvirt.org/formatdomain.html#sound-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sounds Domain#sounds}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesSounds" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sounds", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSounds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Sounds
        {
            get => _sounds;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesSounds[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesSounds).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sounds = value;
            }
        }

        private object? _tpms;

        /// <summary>Configures one or more TPM devices attached to the guest, including their backend implementation, addressing, and optional ACPI integration.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tpms Domain#tpms}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesTpms" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tpms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesTpms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tpms
        {
            get => _tpms;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesTpms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesTpms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tpms = value;
            }
        }

        private object? _videos;

        /// <summary>Defines one or more video devices attached to the guest, each providing a virtual graphics adapter.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#videos Domain#videos}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesVideos" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "videos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesVideos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Videos
        {
            get => _videos;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesVideos[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesVideos).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _videos = value;
            }
        }

        /// <summary>Configures a virtio vsock device that provides a host/guest communication channel using a CID-based socket interface.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vsock Domain#vsock}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vsock", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesVsock\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesVsock? Vsock
        {
            get;
            set;
        }

        private object? _watchdogs;

        /// <summary>Configures one or more virtual watchdog devices attached to the guest, each controlling timeout behavior and actions on failure.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#watchdog-devices">https://libvirt.org/formatdomain.html#watchdog-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#watchdogs Domain#watchdogs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesWatchdogs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "watchdogs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesWatchdogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Watchdogs
        {
            get => _watchdogs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesWatchdogs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesWatchdogs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _watchdogs = value;
            }
        }
    }
}
