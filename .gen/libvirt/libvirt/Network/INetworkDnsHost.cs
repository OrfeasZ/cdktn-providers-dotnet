using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkDnsHost), fullyQualifiedName: "libvirt.network.NetworkDnsHost")]
    public interface INetworkDnsHost
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
        string Ip
        {
            get;
        }

        /// <summary>Lists one or more hostnames associated with a single static DNS host entry.</summary>
        /// <remarks>
        /// Each block represents a single hostname record for the given IP.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#hostnames Network#hostnames}
        /// </remarks>
        [JsiiProperty(name: "hostnames", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsHostHostnames\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Hostnames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkDnsHost), fullyQualifiedName: "libvirt.network.NetworkDnsHost")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkDnsHost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string>()!;
            }

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
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
