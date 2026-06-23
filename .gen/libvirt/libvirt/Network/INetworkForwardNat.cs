using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkForwardNat), fullyQualifiedName: "libvirt.network.NetworkForwardNat")]
    public interface INetworkForwardNat
    {
        /// <summary>Sets one or more address ranges used as the external source addresses for NAT, each defined by a start and end IP.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#addresses Network#addresses}
        /// </remarks>
        [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardNatAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether this NAT configuration applies to IPv6 traffic; value is user-provided and typically "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ipv6 Network#ipv6}
        /// </remarks>
        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets one or more port ranges to be used for NAT translation, each defined by a start and end port.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ports Network#ports}
        /// </remarks>
        [JsiiProperty(name: "ports", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardNatPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ports
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkForwardNat), fullyQualifiedName: "libvirt.network.NetworkForwardNat")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkForwardNat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets one or more address ranges used as the external source addresses for NAT, each defined by a start and end IP.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#addresses Network#addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardNatAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Addresses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether this NAT configuration applies to IPv6 traffic; value is user-provided and typically "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ipv6 Network#ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets one or more port ranges to be used for NAT translation, each defined by a start and end port.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ports Network#ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardNatPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ports
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
