using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkIpsDhcp")]
    public class NetworkIpsDhcp : libvirt.Network.INetworkIpsDhcp
    {
        private object? _bootp;

        /// <summary>Configures BOOTP options for this DHCP range, such as the boot file and TFTP server used by PXE/BOOTP clients.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#bootp Network#bootp}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkIpsDhcpBootp" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpBootp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Bootp
        {
            get => _bootp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkIpsDhcpBootp[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkIpsDhcpBootp).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bootp = value;
            }
        }

        private object? _hosts;

        /// <summary>Defines one or more static DHCP host entries that map specific clients to fixed IP and lease settings.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#hosts Network#hosts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkIpsDhcpHosts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hosts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Hosts
        {
            get => _hosts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkIpsDhcpHosts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkIpsDhcpHosts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hosts = value;
            }
        }

        private object? _ranges;

        /// <summary>Configures one or more dynamic DHCP address ranges associated with this IP subnet.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ranges Network#ranges}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkIpsDhcpRanges" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ranges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkIpsDhcpRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ranges
        {
            get => _ranges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkIpsDhcpRanges[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkIpsDhcpRanges).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ranges = value;
            }
        }
    }
}
