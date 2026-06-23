using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkMtu), fullyQualifiedName: "libvirt.network.NetworkMtu")]
    public interface INetworkMtu
    {
        /// <summary>Sets the MTU size (non-negative integer, in bytes) for the network’s bridge or interface, e.g. 1500 or 9000.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#size Network#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkMtu), fullyQualifiedName: "libvirt.network.NetworkMtu")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkMtu
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the MTU size (non-negative integer, in bytes) for the network’s bridge or interface, e.g. 1500 or 9000.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#size Network#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
