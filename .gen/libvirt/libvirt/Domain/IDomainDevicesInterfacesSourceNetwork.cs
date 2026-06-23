using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceNetwork), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceNetwork")]
    public interface IDomainDevicesInterfacesSourceNetwork
    {
        /// <summary>Sets the name of an existing host bridge device to use as the backing for this network interface (user-provided bridge name, e.g. "br0").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#bridge-to-lan">https://libvirt.org/formatdomain.html#bridge-to-lan</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bridge Domain#bridge}
        /// </remarks>
        [JsiiProperty(name: "bridge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bridge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the name of the libvirt virtual network to connect this interface to (must match a defined libvirt network name).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#network Domain#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a specific portgroup within the referenced libvirt virtual network for this interface, typically to apply different QoS or VLAN settings (user-provided portgroup name).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_group Domain#port_group}
        /// </remarks>
        [JsiiProperty(name: "portGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PortGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets a backend-specific port identifier for integration with external networking (e.g. Open vSwitch or SDN controllers), using a user-provided opaque ID string.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_id Domain#port_id}
        /// </remarks>
        [JsiiProperty(name: "portId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PortId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceNetwork), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceNetwork")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the name of an existing host bridge device to use as the backing for this network interface (user-provided bridge name, e.g. "br0").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#bridge-to-lan">https://libvirt.org/formatdomain.html#bridge-to-lan</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bridge Domain#bridge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bridge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bridge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the name of the libvirt virtual network to connect this interface to (must match a defined libvirt network name).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#network Domain#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Network
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects a specific portgroup within the referenced libvirt virtual network for this interface, typically to apply different QoS or VLAN settings (user-provided portgroup name).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#portgroups">https://libvirt.org/formatnetwork.html#portgroups</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_group Domain#port_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PortGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets a backend-specific port identifier for integration with external networking (e.g. Open vSwitch or SDN controllers), using a user-provided opaque ID string.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_id Domain#port_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PortId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
