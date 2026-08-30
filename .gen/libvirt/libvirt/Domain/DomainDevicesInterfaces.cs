using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfaces")]
    public class DomainDevicesInterfaces : libvirt.Domain.IDomainDevicesInterfaces
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Configures driver/backend-specific networking options for this interface, such as vhost device path or tap device name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend Domain#backend}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackend\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesBackend? Backend
        {
            get;
            set;
        }

        /// <summary>Attaches the interface’s network backend to a separate driver/backend domain instead of the main host, enabling driver-domain networking setups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#backend_domain Domain#backend_domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendDomain", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackendDomain\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesBackendDomain? BackendDomain
        {
            get;
            set;
        }

        /// <summary>Enables per-interface bandwidth quality-of-service limits and priorities for this network interface.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bandwidth Domain#bandwidth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bandwidth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidth\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesBandwidth? Bandwidth
        {
            get;
            set;
        }

        /// <summary>Enables boot-order control for this redirected device, allowing it to participate in the device boot sequence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#boot Domain#boot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBoot\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesBoot? Boot
        {
            get;
            set;
        }

        /// <summary>Configures coalescing behavior for this interface, allowing control over how packets are grouped before being delivered.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#coalesce Domain#coalesce}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coalesce", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesce\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesCoalesce? Coalesce
        {
            get;
            set;
        }

        /// <summary>Configures a custom script to be executed when this interface is brought down on the host side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#down_script Domain#down_script}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "downScript", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDownScript\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesDownScript? DownScript
        {
            get;
            set;
        }

        /// <summary>Configures driver‑specific options for this interface, including virtio transport and offload features.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriver\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesDriver? Driver
        {
            get;
            set;
        }

        /// <summary>Attaches a network filter profile (nwfilter) to the interface, allowing libvirt to enforce traffic filtering rules on this NIC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#filter_ref Domain#filter_ref}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterRef", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRef\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesFilterRef? FilterRef
        {
            get;
            set;
        }

        /// <summary>Describes how the interface appears inside the guest, including its guest-visible device name and, optionally, the actual device name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#guest Domain#guest}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guest", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesGuest\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesGuest? Guest
        {
            get;
            set;
        }

        private object? _ip;

        /// <summary>Assigns one or more IP addresses directly to the guest-side interface, including address family, prefix length, and optional peer address.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ip Domain#ip}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesIp" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ip
        {
            get => _ip;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfacesIp[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesIp).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ip = value;
            }
        }

        /// <summary>Controls the administrative link state of the virtual NIC as seen by the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#link Domain#link}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesLink\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesLink? Link
        {
            get;
            set;
        }

        /// <summary>Configures the MAC layer attributes for the interface, including its hardware address and optional duplicate-address check behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mac Domain#mac}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mac", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMac\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesMac? Mac
        {
            get;
            set;
        }

        private object? _managed;

        /// <summary>Controls whether libvirt manages the lifecycle of the host-side interface (e.g., tap/macvtap); boolean expressed as "yes" or "no", and when omitted libvirt uses its default behavior.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#managed Domain#managed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Managed
        {
            get => _managed;
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
                _managed = value;
            }
        }

        /// <summary>Configures the emulated NIC model for the interface, via a nested block that selects the device type (e.g., virtio, e1000).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesModel\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesModel? Model
        {
            get;
            set;
        }

        /// <summary>Configures MTU settings for the interface via a nested block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mtu Domain#mtu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mtu", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMtu\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesMtu? Mtu
        {
            get;
            set;
        }

        private object? _portForward;

        /// <summary>Configures host-to-guest port forwarding when using a userspace backend that supports passt; contains address, device, protocol, and port ranges.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port_forward Domain#port_forward}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesPortForward" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portForward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PortForward
        {
            get => _portForward;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfacesPortForward[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesPortForward).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _portForward = value;
            }
        }

        /// <summary>Configures per-interface port options (such as isolation) for this NIC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port_options Domain#port_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portOptions", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortOptions\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesPortOptions? PortOptions
        {
            get;
            set;
        }

        /// <summary>Configures an optional PCI ROM image for the passthrough host device, including whether it is enabled, where it is mapped, and an alternate ROM file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#rom Domain#rom}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rom", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRom\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesRom? Rom
        {
            get;
            set;
        }

        private object? _route;

        /// <summary>Defines a static route associated with this network interface inside the guest, specifying destination, gateway, and related routing parameters.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#route Domain#route}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesRoute" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "route", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Route
        {
            get => _route;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfacesRoute[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesRoute).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _route = value;
            }
        }

        /// <summary>Configures a custom script to be executed when this interface is brought down on the host side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#script Domain#script}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "script", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesScript\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesScript? Script
        {
            get;
            set;
        }

        /// <summary>Selects and configures the backend connectivity source for the interface (such as bridge, direct, user-mode networking, or tunnels).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSource? Source
        {
            get;
            set;
        }

        /// <summary>Controls the guest-side interface target settings, such as the name of the tap or virtio-net device visible to the host and/or guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTarget\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesTarget? Target
        {
            get;
            set;
        }

        /// <summary>Configures this PCI hostdev as part of an interface teaming/bonding setup in the guest, pairing it with another interface for failover.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#teaming Domain#teaming}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "teaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTeaming\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesTeaming? Teaming
        {
            get;
            set;
        }

        /// <summary>Controls whether the host trusts the guest to configure its own receive packet filters;</summary>
        /// <remarks>
        /// value is user-provided (commonly "yes" or "no").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#trust_guest_rx_filters Domain#trust_guest_rx_filters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustGuestRxFilters
        {
            get;
            set;
        }

        /// <summary>Configures network interface tuning parameters such as socket buffer sizes and backend-specific settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tune Domain#tune}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tune", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTune\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesTune? Tune
        {
            get;
            set;
        }

        /// <summary>Configures virtual port profile information for the interface, used with advanced network setups such as Open vSwitch or SR-IOV.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#virtual_port Domain#virtual_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPort\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesVirtualPort? VirtualPort
        {
            get;
            set;
        }

        /// <summary>Configures one or more VLAN tags for the interface;</summary>
        /// <remarks>
        /// when present, the interface traffic is tagged according to the contained tag blocks, optionally in trunk mode.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vlan Domain#vlan}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVlan\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesVlan? Vlan
        {
            get;
            set;
        }

        /// <summary>Wait for IP address during domain creation. If specified, Terraform will wait until the interface receives an IP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wait_for_ip Domain#wait_for_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "waitForIp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesWaitForIp\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesWaitForIp? WaitForIp
        {
            get;
            set;
        }
    }
}
