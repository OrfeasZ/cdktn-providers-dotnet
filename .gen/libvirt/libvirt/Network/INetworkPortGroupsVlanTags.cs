using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkPortGroupsVlanTags), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVlanTags")]
    public interface INetworkPortGroupsVlanTags
    {
        /// <summary>Sets the VLAN ID associated with this tag;</summary>
        /// <remarks>
        /// value is user-provided and corresponds to the 802.1Q VLAN identifier used for this network or portgroup.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#id Network#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        double Id
        {
            get;
        }

        /// <summary>Sets whether this VLAN tag is treated as native on the trunk for this portgroup;</summary>
        /// <remarks>
        /// valid values are user-provided strings such as "tagged" or "untagged" as supported by libvirt/qemu.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#native_mode Network#native_mode}
        /// </remarks>
        [JsiiProperty(name: "nativeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NativeMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkPortGroupsVlanTags), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVlanTags")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkPortGroupsVlanTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the VLAN ID associated with this tag;</summary>
            /// <remarks>
            /// value is user-provided and corresponds to the 802.1Q VLAN identifier used for this network or portgroup.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#id Network#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
            public double Id
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets whether this VLAN tag is treated as native on the trunk for this portgroup;</summary>
            /// <remarks>
            /// valid values are user-provided strings such as "tagged" or "untagged" as supported by libvirt/qemu.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#native_mode Network#native_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nativeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NativeMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
