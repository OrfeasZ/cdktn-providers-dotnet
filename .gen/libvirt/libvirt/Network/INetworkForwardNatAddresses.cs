using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkForwardNatAddresses), fullyQualifiedName: "libvirt.network.NetworkForwardNatAddresses")]
    public interface INetworkForwardNatAddresses
    {
        /// <summary>Sets the last IP address in the NAT external address range;</summary>
        /// <remarks>
        /// must be in the same family and &gt;= the start address (e.g. "192.168.122.254").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#end Network#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        string End
        {
            get;
        }

        /// <summary>Sets the first IP address in the NAT external address range;</summary>
        /// <remarks>
        /// must be a valid IPv4 or IPv6 address (e.g. "192.168.122.1").
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#start Network#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        string Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkForwardNatAddresses), fullyQualifiedName: "libvirt.network.NetworkForwardNatAddresses")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkForwardNatAddresses
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the last IP address in the NAT external address range;</summary>
            /// <remarks>
            /// must be in the same family and &gt;= the start address (e.g. "192.168.122.254").
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#end Network#end}
            /// </remarks>
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
            public string End
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the first IP address in the NAT external address range;</summary>
            /// <remarks>
            /// must be a valid IPv4 or IPv6 address (e.g. "192.168.122.1").
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#start Network#start}
            /// </remarks>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
            public string Start
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
