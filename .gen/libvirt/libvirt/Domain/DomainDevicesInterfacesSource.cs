using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSource")]
    public class DomainDevicesInterfacesSource : libvirt.Domain.IDomainDevicesInterfacesSource
    {
        /// <summary>Configures this interface to attach to a host bridge device, making the guest appear directly on the bridged LAN.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bridge Domain#bridge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bridge", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceBridge\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceBridge? Bridge
        {
            get;
            set;
        }

        /// <summary>Configures this interface as a client endpoint of a point-to-point tunnel (such as TCP, UDP, or multicast tunnel) using a remote address and port.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#client Domain#client}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "client", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceClient\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceClient? Client
        {
            get;
            set;
        }

        /// <summary>Configures this interface for direct macvtap-style attachment to a physical host NIC, bypassing a software bridge for near-raw access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#direct Domain#direct}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direct", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceDirect\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceDirect? Direct
        {
            get;
            set;
        }

        /// <summary>Enables configuration of a generic ethernet/tap interface whose lower-level setup is handled outside libvirt (IP addresses, routes, etc.</summary>
        /// <remarks>
        /// defined in nested attributes).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ethernet Domain#ethernet}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ethernet", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceEthernet\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceEthernet? Ethernet
        {
            get;
            set;
        }

        /// <summary>Enables use of a host device as the backing for this network interface, allowing PCI or similar passthrough as configured in nested attributes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hostdev Domain#hostdev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostdev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdev\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceHostdev? Hostdev
        {
            get;
            set;
        }

        /// <summary>Configures the interface to connect to an internal network name rather than an external bridge or hostdev device, typically used for libvirt-internal or hypervisor-specific networks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#internal Domain#internal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internal", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceInternal\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceInternal? Internal
        {
            get;
            set;
        }

        /// <summary>Configures a multicast tunnel network backend for the interface, using a multicast group as the virtual network segment shared with other VMs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mcast Domain#mcast}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mcast", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceMcast\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceMcast? Mcast
        {
            get;
            set;
        }

        /// <summary>Attaches the interface to a libvirt-managed virtual network, optionally via a specific bridge or port group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#network Domain#network}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceNetwork\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceNetwork? Network
        {
            get;
            set;
        }

        private object? _null;

        /// <summary>When true, configures the interface as a null/unconnected network interface with no backing network;</summary>
        /// <remarks>
        /// when false or unset, the element is omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#null-network-interface">https://libvirt.org/formatdomain.html#null-network-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#null Domain#null}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "null", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Null
        {
            get => _null;
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
                _null = value;
            }
        }

        /// <summary>Configures a TCP tunnel network backend where this interface connects to or listens on a TCP server endpoint to form a virtual network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#server Domain#server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceServer\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceServer? Server
        {
            get;
            set;
        }

        /// <summary>Configures a UDP unicast tunnel network backend for the interface, using UDP endpoints to connect VMs into a virtual network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#udp Domain#udp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUdp\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceUdp? Udp
        {
            get;
            set;
        }

        /// <summary>Selects a userspace SLIRP-style backend as the source for the network interface, providing NAT without needing host privileges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#user Domain#user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUser\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceUser? User
        {
            get;
            set;
        }

        /// <summary>Selects a vDPA device as the source of the interface, enabling virtio-compliant hardware offload for the guest NIC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vdpa Domain#vdpa}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVdpa\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceVdpa? Vdpa
        {
            get;
            set;
        }

        /// <summary>Connects the interface to a VMware Distributed Switch (VDS) as its network source, using VMware-specific identifiers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vds Domain#vds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vds", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVds\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceVds? Vds
        {
            get;
            set;
        }

        /// <summary>Selects a vhost-user backend as the source for the virtio network interface, connecting it to an external userspace process via a character device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vhost_user Domain#vhost_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUser\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceVhostUser? VhostUser
        {
            get;
            set;
        }
    }
}
