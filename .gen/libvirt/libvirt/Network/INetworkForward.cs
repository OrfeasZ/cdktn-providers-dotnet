using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkForward), fullyQualifiedName: "libvirt.network.NetworkForward")]
    public interface INetworkForward
    {
        /// <summary>Lists one or more forwarding endpoint addresses (typically physical devices or PCI addresses) used when the network is in a passthrough/hostdev style forward mode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#addresses Network#addresses}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardAddresses" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies a single host network interface name (e.g. \"eth0\", \"br0\") that this virtual network forwards through; used by several forward modes such as \"route\", \"nat\", or \"bridge\".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#dev Network#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dev
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures driver-specific settings for the network forward, allowing selection or tuning of the underlying forwarding implementation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#driver Network#driver}
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkForwardDriver? Driver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lists one or more host interfaces that participate in this network’s forwarding (for multi‑NIC or aggregated configurations).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#interfaces Network#interfaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardInterfaces" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "interfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Interfaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether libvirt manages the lifecycle of the underlying forwarding interfaces and devices, stored as a \"yes\"/\"no\" string but exposed as a boolean in Terraform.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#managed Network#managed}
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

        /// <summary>Sets the forwarding mode of the virtual network, with valid values including \"nat\", \"route\", \"bridge\", \"open\", \"vepa\", \"passthrough\", or \"private\" depending on the desired connectivity model.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#mode Network#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures NAT-specific options for the network’s forward mode, including address and port ranges used for translation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#nat Network#nat}
        /// </remarks>
        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardNat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkForwardNat? Nat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares one or more physical forwarding interfaces (port forwarding devices) used by the network’s forward mode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#pfs Network#pfs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardPfs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "pfs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardPfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Pfs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkForward), fullyQualifiedName: "libvirt.network.NetworkForward")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists one or more forwarding endpoint addresses (typically physical devices or PCI addresses) used when the network is in a passthrough/hostdev style forward mode.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#addresses Network#addresses}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardAddresses" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Addresses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies a single host network interface name (e.g. \"eth0\", \"br0\") that this virtual network forwards through; used by several forward modes such as \"route\", \"nat\", or \"bridge\".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#dev Network#dev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dev
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures driver-specific settings for the network forward, allowing selection or tuning of the underlying forwarding implementation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#driver Network#driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardDriver\"}", isOptional: true)]
            public libvirt.Network.INetworkForwardDriver? Driver
            {
                get => GetInstanceProperty<libvirt.Network.INetworkForwardDriver?>();
            }

            /// <summary>Lists one or more host interfaces that participate in this network’s forwarding (for multi‑NIC or aggregated configurations).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#interfaces Network#interfaces}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardInterfaces" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Interfaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether libvirt manages the lifecycle of the underlying forwarding interfaces and devices, stored as a \"yes\"/\"no\" string but exposed as a boolean in Terraform.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#managed Network#managed}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Managed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the forwarding mode of the virtual network, with valid values including \"nat\", \"route\", \"bridge\", \"open\", \"vepa\", \"passthrough\", or \"private\" depending on the desired connectivity model.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#mode Network#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures NAT-specific options for the network’s forward mode, including address and port ranges used for translation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#nat Network#nat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardNat\"}", isOptional: true)]
            public libvirt.Network.INetworkForwardNat? Nat
            {
                get => GetInstanceProperty<libvirt.Network.INetworkForwardNat?>();
            }

            /// <summary>Declares one or more physical forwarding interfaces (port forwarding devices) used by the network’s forward mode.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#pfs Network#pfs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardPfs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pfs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardPfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Pfs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
