using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkDnsForwarders), fullyQualifiedName: "libvirt.network.NetworkDnsForwarders")]
    public interface INetworkDnsForwarders
    {
        /// <summary>Sets the IP address of an upstream DNS forwarder.</summary>
        /// <remarks>
        /// The value is user-provided and should be a valid IPv4 or IPv6 address (e.g. "8.8.8.8" or "2001:4860:4860::8888").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#addr Network#addr}
        /// </remarks>
        [JsiiProperty(name: "addr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Addr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Restricts the forwarder to queries for a specific DNS domain suffix.</summary>
        /// <remarks>
        /// The value is user-provided and should be a valid DNS domain (e.g. "example.com").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#domain Network#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#port Network#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkDnsForwarders), fullyQualifiedName: "libvirt.network.NetworkDnsForwarders")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkDnsForwarders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the IP address of an upstream DNS forwarder.</summary>
            /// <remarks>
            /// The value is user-provided and should be a valid IPv4 or IPv6 address (e.g. "8.8.8.8" or "2001:4860:4860::8888").
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#addr Network#addr}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Addr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Restricts the forwarder to queries for a specific DNS domain suffix.</summary>
            /// <remarks>
            /// The value is user-provided and should be a valid DNS domain (e.g. "example.com").
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#domain Network#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Domain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#port Network#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
