using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkVirtualPortParams), fullyQualifiedName: "libvirt.network.NetworkVirtualPortParams")]
    public interface INetworkVirtualPortParams
    {
        /// <summary>Configures a generic (IEEE 802.1Qbg-style) port profile, using opaque identifiers understood by an external network manager.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#any Network#any}
        /// </remarks>
        [JsiiProperty(name: "any", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsAny\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkVirtualPortParamsAny? Any
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures MidoNet-specific virtual port parameters for this port group, enabling integration with a MidoNet SDN controller.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#mido_net Network#mido_net}
        /// </remarks>
        [JsiiProperty(name: "midoNet", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsMidoNet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkVirtualPortParamsMidoNet? MidoNet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures Open vSwitch-specific virtual port parameters for this port group, enabling OVS-aware port profiling;</summary>
        /// <remarks>
        /// all values are user-provided and interpreted by OVS tooling.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#open_v_switch Network#open_v_switch}
        /// </remarks>
        [JsiiProperty(name: "openVSwitch", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsOpenVSwitch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkVirtualPortParamsOpenVSwitch? OpenVSwitch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of IEEE 802.1Qbg VEPA virtual port profile parameters for this portgroup, allowing association with an external Edge Virtual Bridging (EVB) manager.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#vepa8021qbg Network#vepa8021qbg}
        /// </remarks>
        [JsiiProperty(name: "vepa8021Qbg", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVepa8021Qbg\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkVirtualPortParamsVepa8021Qbg? Vepa8021Qbg
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables configuration of IEEE 802.1Qbh VN-Tag virtual port profile parameters for this portgroup, used with hardware that supports Cisco VN-Tag or similar tagging.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#vn_tag8011qbh Network#vn_tag8011qbh}
        /// </remarks>
        [JsiiProperty(name: "vnTag8011Qbh", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVnTag8011Qbh\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkVirtualPortParamsVnTag8011Qbh? VnTag8011Qbh
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkVirtualPortParams), fullyQualifiedName: "libvirt.network.NetworkVirtualPortParams")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkVirtualPortParams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures a generic (IEEE 802.1Qbg-style) port profile, using opaque identifiers understood by an external network manager.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#any Network#any}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "any", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsAny\"}", isOptional: true)]
            public libvirt.Network.INetworkVirtualPortParamsAny? Any
            {
                get => GetInstanceProperty<libvirt.Network.INetworkVirtualPortParamsAny?>();
            }

            /// <summary>Configures MidoNet-specific virtual port parameters for this port group, enabling integration with a MidoNet SDN controller.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#mido_net Network#mido_net}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "midoNet", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsMidoNet\"}", isOptional: true)]
            public libvirt.Network.INetworkVirtualPortParamsMidoNet? MidoNet
            {
                get => GetInstanceProperty<libvirt.Network.INetworkVirtualPortParamsMidoNet?>();
            }

            /// <summary>Configures Open vSwitch-specific virtual port parameters for this port group, enabling OVS-aware port profiling;</summary>
            /// <remarks>
            /// all values are user-provided and interpreted by OVS tooling.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#open_v_switch Network#open_v_switch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openVSwitch", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsOpenVSwitch\"}", isOptional: true)]
            public libvirt.Network.INetworkVirtualPortParamsOpenVSwitch? OpenVSwitch
            {
                get => GetInstanceProperty<libvirt.Network.INetworkVirtualPortParamsOpenVSwitch?>();
            }

            /// <summary>Enables configuration of IEEE 802.1Qbg VEPA virtual port profile parameters for this portgroup, allowing association with an external Edge Virtual Bridging (EVB) manager.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#vepa8021qbg Network#vepa8021qbg}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vepa8021Qbg", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVepa8021Qbg\"}", isOptional: true)]
            public libvirt.Network.INetworkVirtualPortParamsVepa8021Qbg? Vepa8021Qbg
            {
                get => GetInstanceProperty<libvirt.Network.INetworkVirtualPortParamsVepa8021Qbg?>();
            }

            /// <summary>Enables configuration of IEEE 802.1Qbh VN-Tag virtual port profile parameters for this portgroup, used with hardware that supports Cisco VN-Tag or similar tagging.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#vn_tag8011qbh Network#vn_tag8011qbh}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vnTag8011Qbh", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParamsVnTag8011Qbh\"}", isOptional: true)]
            public libvirt.Network.INetworkVirtualPortParamsVnTag8011Qbh? VnTag8011Qbh
            {
                get => GetInstanceProperty<libvirt.Network.INetworkVirtualPortParamsVnTag8011Qbh?>();
            }
        }
    }
}
