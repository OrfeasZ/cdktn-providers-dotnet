using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkDnsHostHostnames), fullyQualifiedName: "libvirt.network.NetworkDnsHostHostnames")]
    public interface INetworkDnsHostHostnames
    {
        /// <summary>Sets a hostname to be mapped to the parent host’s IP address in DNS.</summary>
        /// <remarks>
        /// The value is user-provided and should be a valid host label or FQDN (e.g. "web1" or "web1.example.local").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#hostname Network#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkDnsHostHostnames), fullyQualifiedName: "libvirt.network.NetworkDnsHostHostnames")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkDnsHostHostnames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets a hostname to be mapped to the parent host’s IP address in DNS.</summary>
            /// <remarks>
            /// The value is user-provided and should be a valid host label or FQDN (e.g. "web1" or "web1.example.local").
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#hostname Network#hostname}
            /// </remarks>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
