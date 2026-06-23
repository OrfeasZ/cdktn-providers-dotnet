using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.network.NetworkDnsHost")]
    public class NetworkDnsHost : libvirt.Network.INetworkDnsHost
    {
        /// <summary>Sets the IP address for the static host mapping used by all associated hostnames.</summary>
        /// <remarks>
        /// The value is required and must be a valid IPv4 or IPv6 address.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#ip Network#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public string Ip
        {
            get;
            set;
        }

        private object? _hostnames;

        /// <summary>Lists one or more hostnames associated with a single static DNS host entry.</summary>
        /// <remarks>
        /// Each block represents a single hostname record for the given IP.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#hostnames Network#hostnames}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostnames", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsHostHostnames\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Hostnames
        {
            get => _hostnames;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkDnsHostHostnames[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkDnsHostHostnames).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hostnames = value;
            }
        }
    }
}
