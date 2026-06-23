using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkMac), fullyQualifiedName: "libvirt.network.NetworkMac")]
    public interface INetworkMac
    {
        /// <summary>Sets the MAC address of the bridge associated with this virtual network;</summary>
        /// <remarks>
        /// must be a valid MAC such as <c>52:54:00:ab:cd:ef</c>.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#address Network#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkMac), fullyQualifiedName: "libvirt.network.NetworkMac")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkMac
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the MAC address of the bridge associated with this virtual network;</summary>
            /// <remarks>
            /// must be a valid MAC such as <c>52:54:00:ab:cd:ef</c>.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#addressing">https://libvirt.org/formatnetwork.html#addressing</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#address Network#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
