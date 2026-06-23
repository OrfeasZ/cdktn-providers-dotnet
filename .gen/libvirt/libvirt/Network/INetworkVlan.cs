using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkVlan), fullyQualifiedName: "libvirt.network.NetworkVlan")]
    public interface INetworkVlan
    {
        /// <summary>Defines one or more VLAN tag entries for this portgroup;</summary>
        /// <remarks>
        /// each tag specifies a VLAN ID, and optionally native-mode behavior, applied to guest traffic.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#tags Network#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkVlanTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether this portgroup’s VLAN configuration operates in trunk mode, allowing multiple VLAN tags;</summary>
        /// <remarks>
        /// value is a yes/no string flag, where "yes" enables trunk mode.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#trunk Network#trunk}
        /// </remarks>
        [JsiiProperty(name: "trunk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Trunk
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkVlan), fullyQualifiedName: "libvirt.network.NetworkVlan")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkVlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines one or more VLAN tag entries for this portgroup;</summary>
            /// <remarks>
            /// each tag specifies a VLAN ID, and optionally native-mode behavior, applied to guest traffic.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#tags Network#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkVlanTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether this portgroup’s VLAN configuration operates in trunk mode, allowing multiple VLAN tags;</summary>
            /// <remarks>
            /// value is a yes/no string flag, where "yes" enables trunk mode.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#trunk Network#trunk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trunk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Trunk
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
