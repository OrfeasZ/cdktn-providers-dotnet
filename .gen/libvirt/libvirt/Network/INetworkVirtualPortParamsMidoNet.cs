using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkVirtualPortParamsMidoNet), fullyQualifiedName: "libvirt.network.NetworkVirtualPortParamsMidoNet")]
    public interface INetworkVirtualPortParamsMidoNet
    {
        /// <summary>Sets the MidoNet interface identifier, typically a UUID or opaque string that MidoNet uses to match the guest interface to a virtual port.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#interface_id Network#interface_id}
        /// </remarks>
        [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InterfaceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkVirtualPortParamsMidoNet), fullyQualifiedName: "libvirt.network.NetworkVirtualPortParamsMidoNet")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkVirtualPortParamsMidoNet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the MidoNet interface identifier, typically a UUID or opaque string that MidoNet uses to match the guest interface to a virtual port.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#interface_id Network#interface_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
