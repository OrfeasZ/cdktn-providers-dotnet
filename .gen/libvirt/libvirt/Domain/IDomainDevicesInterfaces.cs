using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfaces), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfaces")]
    public interface IDomainDevicesInterfaces
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAcpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesAcpi? Acpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesAlias? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures driver/backend-specific networking options for this interface, such as vhost device path or tap device name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backend Domain#backend}
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackend\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesBackend? Backend
        {
            get
            {
                return null;
            }
        }

        /// <summary>Attaches the interface’s network backend to a separate driver/backend domain instead of the main host, enabling driver-domain networking setups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backend_domain Domain#backend_domain}
        /// </remarks>
        [JsiiProperty(name: "backendDomain", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackendDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesBackendDomain? BackendDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables per-interface bandwidth quality-of-service limits and priorities for this network interface.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bandwidth Domain#bandwidth}
        /// </remarks>
        [JsiiProperty(name: "bandwidth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesBandwidth? Bandwidth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables boot-order control for this redirected device, allowing it to participate in the device boot sequence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#boot Domain#boot}
        /// </remarks>
        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBoot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesBoot? Boot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures coalescing behavior for this interface, allowing control over how packets are grouped before being delivered.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#coalesce Domain#coalesce}
        /// </remarks>
        [JsiiProperty(name: "coalesce", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesce\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesCoalesce? Coalesce
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a custom script to be executed when this interface is brought down on the host side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#down_script Domain#down_script}
        /// </remarks>
        [JsiiProperty(name: "downScript", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDownScript\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesDownScript? DownScript
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures driver‑specific options for this interface, including virtio transport and offload features.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesDriver? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Attaches a network filter profile (nwfilter) to the interface, allowing libvirt to enforce traffic filtering rules on this NIC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#filter_ref Domain#filter_ref}
        /// </remarks>
        [JsiiProperty(name: "filterRef", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRef\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesFilterRef? FilterRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>Describes how the interface appears inside the guest, including its guest-visible device name and, optionally, the actual device name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#guest Domain#guest}
        /// </remarks>
        [JsiiProperty(name: "guest", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesGuest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesGuest? Guest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Assigns one or more IP addresses directly to the guest-side interface, including address family, prefix length, and optional peer address.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ip Domain#ip}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesIp" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls the administrative link state of the virtual NIC as seen by the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#link Domain#link}
        /// </remarks>
        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesLink\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesLink? Link
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the MAC layer attributes for the interface, including its hardware address and optional duplicate-address check behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mac Domain#mac}
        /// </remarks>
        [JsiiProperty(name: "mac", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMac\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesMac? Mac
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether libvirt manages the lifecycle of the host-side interface (e.g., tap/macvtap); boolean expressed as "yes" or "no", and when omitted libvirt uses its default behavior.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#managed Domain#managed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Managed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the emulated NIC model for the interface, via a nested block that selects the device type (e.g., virtio, e1000).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesModel\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesModel? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures MTU settings for the interface via a nested block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mtu Domain#mtu}
        /// </remarks>
        [JsiiProperty(name: "mtu", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMtu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesMtu? Mtu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures host-to-guest port forwarding when using a userspace backend that supports passt; contains address, device, protocol, and port ranges.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_forward Domain#port_forward}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesPortForward" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "portForward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PortForward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures per-interface port options (such as isolation) for this NIC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_options Domain#port_options}
        /// </remarks>
        [JsiiProperty(name: "portOptions", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesPortOptions? PortOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an optional PCI ROM image for the passthrough host device, including whether it is enabled, where it is mapped, and an alternate ROM file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rom Domain#rom}
        /// </remarks>
        [JsiiProperty(name: "rom", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRom\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesRom? Rom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines a static route associated with this network interface inside the guest, specifying destination, gateway, and related routing parameters.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#route Domain#route}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesRoute" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "route", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Route
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a custom script to be executed when this interface is brought down on the host side.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#script Domain#script}
        /// </remarks>
        [JsiiProperty(name: "script", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesScript\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesScript? Script
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects and configures the backend connectivity source for the interface (such as bridge, direct, user-mode networking, or tunnels).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls the guest-side interface target settings, such as the name of the tap or virtio-net device visible to the host and/or guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesTarget? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures this PCI hostdev as part of an interface teaming/bonding setup in the guest, pairing it with another interface for failover.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#teaming Domain#teaming}
        /// </remarks>
        [JsiiProperty(name: "teaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTeaming\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesTeaming? Teaming
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the host trusts the guest to configure its own receive packet filters;</summary>
        /// <remarks>
        /// value is user-provided (commonly "yes" or "no").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#trust_guest_rx_filters Domain#trust_guest_rx_filters}
        /// </remarks>
        [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustGuestRxFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures network interface tuning parameters such as socket buffer sizes and backend-specific settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tune Domain#tune}
        /// </remarks>
        [JsiiProperty(name: "tune", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTune\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesTune? Tune
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures virtual port profile information for the interface, used with advanced network setups such as Open vSwitch or SR-IOV.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#virtual_port Domain#virtual_port}
        /// </remarks>
        [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesVirtualPort? VirtualPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more VLAN tags for the interface;</summary>
        /// <remarks>
        /// when present, the interface traffic is tagged according to the contained tag blocks, optionally in trunk mode.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vlan Domain#vlan}
        /// </remarks>
        [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVlan\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesVlan? Vlan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Wait for IP address during domain creation. If specified, Terraform will wait until the interface receives an IP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#wait_for_ip Domain#wait_for_ip}
        /// </remarks>
        [JsiiProperty(name: "waitForIp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesWaitForIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesWaitForIp? WaitForIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfaces), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfaces")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfaces
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAcpi\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesAcpi? Acpi
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesAcpi?>();
            }

            /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesAddress?>();
            }

            /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAlias\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesAlias? Alias
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesAlias?>();
            }

            /// <summary>Configures driver/backend-specific networking options for this interface, such as vhost device path or tap device name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backend Domain#backend}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackend\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesBackend? Backend
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesBackend?>();
            }

            /// <summary>Attaches the interface’s network backend to a separate driver/backend domain instead of the main host, enabling driver-domain networking setups.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#backend_domain Domain#backend_domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendDomain", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackendDomain\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesBackendDomain? BackendDomain
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesBackendDomain?>();
            }

            /// <summary>Enables per-interface bandwidth quality-of-service limits and priorities for this network interface.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bandwidth Domain#bandwidth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bandwidth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidth\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesBandwidth? Bandwidth
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesBandwidth?>();
            }

            /// <summary>Enables boot-order control for this redirected device, allowing it to participate in the device boot sequence.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#boot Domain#boot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBoot\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesBoot? Boot
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesBoot?>();
            }

            /// <summary>Configures coalescing behavior for this interface, allowing control over how packets are grouped before being delivered.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#coalesce Domain#coalesce}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coalesce", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesce\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesCoalesce? Coalesce
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesCoalesce?>();
            }

            /// <summary>Configures a custom script to be executed when this interface is brought down on the host side.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#down_script Domain#down_script}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "downScript", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDownScript\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesDownScript? DownScript
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesDownScript?>();
            }

            /// <summary>Configures driver‑specific options for this interface, including virtio transport and offload features.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#driver Domain#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriver\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesDriver?>();
            }

            /// <summary>Attaches a network filter profile (nwfilter) to the interface, allowing libvirt to enforce traffic filtering rules on this NIC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#filter_ref Domain#filter_ref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterRef", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRef\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesFilterRef? FilterRef
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesFilterRef?>();
            }

            /// <summary>Describes how the interface appears inside the guest, including its guest-visible device name and, optionally, the actual device name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#guest Domain#guest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guest", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesGuest\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesGuest? Guest
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesGuest?>();
            }

            /// <summary>Assigns one or more IP addresses directly to the guest-side interface, including address family, prefix length, and optional peer address.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ip Domain#ip}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesIp" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ip
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls the administrative link state of the virtual NIC as seen by the guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#link Domain#link}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesLink\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesLink? Link
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesLink?>();
            }

            /// <summary>Configures the MAC layer attributes for the interface, including its hardware address and optional duplicate-address check behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mac Domain#mac}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mac", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMac\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesMac? Mac
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesMac?>();
            }

            /// <summary>Controls whether libvirt manages the lifecycle of the host-side interface (e.g., tap/macvtap); boolean expressed as "yes" or "no", and when omitted libvirt uses its default behavior.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#managed Domain#managed}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Managed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures the emulated NIC model for the interface, via a nested block that selects the device type (e.g., virtio, e1000).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesModel\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesModel? Model
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesModel?>();
            }

            /// <summary>Configures MTU settings for the interface via a nested block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mtu Domain#mtu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtu", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMtu\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesMtu? Mtu
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesMtu?>();
            }

            /// <summary>Configures host-to-guest port forwarding when using a userspace backend that supports passt; contains address, device, protocol, and port ranges.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_forward Domain#port_forward}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesPortForward" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portForward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PortForward
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures per-interface port options (such as isolation) for this NIC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_options Domain#port_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portOptions", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortOptions\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesPortOptions? PortOptions
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesPortOptions?>();
            }

            /// <summary>Configures an optional PCI ROM image for the passthrough host device, including whether it is enabled, where it is mapped, and an alternate ROM file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rom Domain#rom}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rom", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRom\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesRom? Rom
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesRom?>();
            }

            /// <summary>Defines a static route associated with this network interface inside the guest, specifying destination, gateway, and related routing parameters.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#route Domain#route}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesRoute" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "route", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Route
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures a custom script to be executed when this interface is brought down on the host side.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#script Domain#script}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "script", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesScript\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesScript? Script
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesScript?>();
            }

            /// <summary>Selects and configures the backend connectivity source for the interface (such as bridge, direct, user-mode networking, or tunnels).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesSource?>();
            }

            /// <summary>Controls the guest-side interface target settings, such as the name of the tap or virtio-net device visible to the host and/or guest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTarget\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesTarget? Target
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesTarget?>();
            }

            /// <summary>Configures this PCI hostdev as part of an interface teaming/bonding setup in the guest, pairing it with another interface for failover.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#teaming Domain#teaming}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "teaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTeaming\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesTeaming? Teaming
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesTeaming?>();
            }

            /// <summary>Controls whether the host trusts the guest to configure its own receive packet filters;</summary>
            /// <remarks>
            /// value is user-provided (commonly "yes" or "no").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#trust_guest_rx_filters Domain#trust_guest_rx_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustGuestRxFilters
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures network interface tuning parameters such as socket buffer sizes and backend-specific settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tune Domain#tune}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tune", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTune\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesTune? Tune
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesTune?>();
            }

            /// <summary>Configures virtual port profile information for the interface, used with advanced network setups such as Open vSwitch or SR-IOV.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#virtual_port Domain#virtual_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPort\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesVirtualPort? VirtualPort
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesVirtualPort?>();
            }

            /// <summary>Configures one or more VLAN tags for the interface;</summary>
            /// <remarks>
            /// when present, the interface traffic is tagged according to the contained tag blocks, optionally in trunk mode.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vlan Domain#vlan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVlan\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesVlan? Vlan
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesVlan?>();
            }

            /// <summary>Wait for IP address during domain creation. If specified, Terraform will wait until the interface receives an IP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#wait_for_ip Domain#wait_for_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "waitForIp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesWaitForIp\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesWaitForIp? WaitForIp
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesWaitForIp?>();
            }
        }
    }
}
