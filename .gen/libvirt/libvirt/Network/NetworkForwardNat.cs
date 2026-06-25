using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkForwardNat")]
    public class NetworkForwardNat : libvirt.Network.INetworkForwardNat
    {
        private object? _addresses;

        /// <summary>Sets one or more address ranges used as the external source addresses for NAT, each defined by a start and end IP.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#addresses Network#addresses}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardNatAddresses" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardNatAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Network.INetworkForwardNatAddresses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkForwardNatAddresses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _addresses = value;
            }
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
            get;
            set;
        }

        private object? _ports;

        /// <summary>Sets one or more port ranges to be used for NAT translation, each defined by a start and end port.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ports Network#ports}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkForwardNatPorts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ports", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkForwardNatPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ports
        {
            get => _ports;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkForwardNatPorts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkForwardNatPorts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ports = value;
            }
        }
    }
}
