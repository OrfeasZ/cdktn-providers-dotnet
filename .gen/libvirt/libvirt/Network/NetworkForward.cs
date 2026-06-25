using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkForward")]
    public class NetworkForward : libvirt.Network.INetworkForward
    {
        private object? _addresses;

        /// <summary>Lists one or more forwarding endpoint addresses (typically physical devices or PCI addresses) used when the network is in a passthrough/hostdev style forward mode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#addresses Network#addresses}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardAddresses" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Addresses
        {
            get => _addresses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkForwardAddresses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkForwardAddresses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _addresses = value;
            }
        }

        /// <summary>Specifies a single host network interface name (e.g. \"eth0\", \"br0\") that this virtual network forwards through; used by several forward modes such as \"route\", \"nat\", or \"bridge\".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#dev Network#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dev
        {
            get;
            set;
        }

        /// <summary>Configures driver-specific settings for the network forward, allowing selection or tuning of the underlying forwarding implementation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#driver Network#driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardDriver\"}", isOptional: true)]
        public libvirt.Network.INetworkForwardDriver? Driver
        {
            get;
            set;
        }

        private object? _interfaces;

        /// <summary>Lists one or more host interfaces that participate in this network’s forwarding (for multi‑NIC or aggregated configurations).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#interfaces Network#interfaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardInterfaces" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Interfaces
        {
            get => _interfaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkForwardInterfaces[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkForwardInterfaces).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _interfaces = value;
            }
        }

        private object? _managed;

        /// <summary>Controls whether libvirt manages the lifecycle of the underlying forwarding interfaces and devices, stored as a \"yes\"/\"no\" string but exposed as a boolean in Terraform.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#managed Network#managed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Managed
        {
            get => _managed;
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
                _managed = value;
            }
        }

        /// <summary>Sets the forwarding mode of the virtual network, with valid values including \"nat\", \"route\", \"bridge\", \"open\", \"vepa\", \"passthrough\", or \"private\" depending on the desired connectivity model.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#mode Network#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Configures NAT-specific options for the network’s forward mode, including address and port ranges used for translation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#nat Network#nat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardNat\"}", isOptional: true)]
        public libvirt.Network.INetworkForwardNat? Nat
        {
            get;
            set;
        }

        private object? _pfs;

        /// <summary>Declares one or more physical forwarding interfaces (port forwarding devices) used by the network’s forward mode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#pfs Network#pfs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardPfs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pfs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardPfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Pfs
        {
            get => _pfs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkForwardPfs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkForwardPfs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pfs = value;
            }
        }
    }
}
