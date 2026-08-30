using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkForwardNatPorts), fullyQualifiedName: "libvirt.network.NetworkForwardNatPorts")]
    public interface INetworkForwardNatPorts
    {
        /// <summary>Sets the last port number in the NAT port range;</summary>
        /// <remarks>
        /// must be an integer between 1 and 65535 and &gt;= the start port.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#end Network#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
        double End
        {
            get;
        }

        /// <summary>Sets the first port number in the NAT port range;</summary>
        /// <remarks>
        /// must be an integer between 1 and 65535 (e.g. 1024).
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#start Network#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        double Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkForwardNatPorts), fullyQualifiedName: "libvirt.network.NetworkForwardNatPorts")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkForwardNatPorts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the last port number in the NAT port range;</summary>
            /// <remarks>
            /// must be an integer between 1 and 65535 and &gt;= the start port.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#end Network#end}
            /// </remarks>
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
            public double End
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the first port number in the NAT port range;</summary>
            /// <remarks>
            /// must be an integer between 1 and 65535 (e.g. 1024).
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#start Network#start}
            /// </remarks>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
            public double Start
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
