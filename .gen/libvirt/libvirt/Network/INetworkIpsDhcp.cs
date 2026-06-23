using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkIpsDhcp), fullyQualifiedName: "libvirt.network.NetworkIpsDhcp")]
    public interface INetworkIpsDhcp
    {
        /// <summary>Configures BOOTP options for this DHCP range, such as the boot file and TFTP server used by PXE/BOOTP clients.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#bootp Network#bootp}
        /// </remarks>
        [JsiiProperty(name: "bootp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpBootp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Bootp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more static DHCP host entries that map specific clients to fixed IP and lease settings.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#hosts Network#hosts}
        /// </remarks>
        [JsiiProperty(name: "hosts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more dynamic DHCP address ranges associated with this IP subnet.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ranges Network#ranges}
        /// </remarks>
        [JsiiProperty(name: "ranges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ranges
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkIpsDhcp), fullyQualifiedName: "libvirt.network.NetworkIpsDhcp")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkIpsDhcp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures BOOTP options for this DHCP range, such as the boot file and TFTP server used by PXE/BOOTP clients.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#bootp Network#bootp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpBootp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Bootp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more static DHCP host entries that map specific clients to fixed IP and lease settings.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#hosts Network#hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hosts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Hosts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures one or more dynamic DHCP address ranges associated with this IP subnet.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ranges Network#ranges}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ranges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ranges
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
