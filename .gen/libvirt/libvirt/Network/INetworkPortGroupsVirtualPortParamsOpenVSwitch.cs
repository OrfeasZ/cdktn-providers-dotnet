using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkPortGroupsVirtualPortParamsOpenVSwitch), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPortParamsOpenVSwitch")]
    public interface INetworkPortGroupsVirtualPortParamsOpenVSwitch
    {
        /// <summary>Sets the Open vSwitch interface identifier (interfaceid) for ports in this portgroup;</summary>
        /// <remarks>
        /// value is user-provided and typically matches the UUID or name expected by the OVS integration on the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#interface_id Network#interface_id}
        /// </remarks>
        [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InterfaceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the Open vSwitch profile identifier (profileid) for ports in this portgroup;</summary>
        /// <remarks>
        /// value is user-provided and used by OVS or higher-level controllers to apply a specific port profile.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#profile_id Network#profile_id}
        /// </remarks>
        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkPortGroupsVirtualPortParamsOpenVSwitch), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPortParamsOpenVSwitch")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkPortGroupsVirtualPortParamsOpenVSwitch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the Open vSwitch interface identifier (interfaceid) for ports in this portgroup;</summary>
            /// <remarks>
            /// value is user-provided and typically matches the UUID or name expected by the OVS integration on the host.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#interface_id Network#interface_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the Open vSwitch profile identifier (profileid) for ports in this portgroup;</summary>
            /// <remarks>
            /// value is user-provided and used by OVS or higher-level controllers to apply a specific port profile.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#profile_id Network#profile_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
