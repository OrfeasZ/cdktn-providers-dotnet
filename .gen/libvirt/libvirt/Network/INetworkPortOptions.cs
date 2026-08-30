using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkPortOptions), fullyQualifiedName: "libvirt.network.NetworkPortOptions")]
    public interface INetworkPortOptions
    {
        /// <summary>Controls whether each guest port on this network is isolated from all other guest ports on the same network;</summary>
        /// <remarks>
        /// valid values are "yes" or "no" (default is "no" when omitted).
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#isolating-ports-from-one-another">https://libvirt.org/formatnetwork.html#isolating-ports-from-one-another</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#isolated Network#isolated}
        /// </remarks>
        [JsiiProperty(name: "isolated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Isolated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkPortOptions), fullyQualifiedName: "libvirt.network.NetworkPortOptions")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkPortOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether each guest port on this network is isolated from all other guest ports on the same network;</summary>
            /// <remarks>
            /// valid values are "yes" or "no" (default is "no" when omitted).
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#isolating-ports-from-one-another">https://libvirt.org/formatnetwork.html#isolating-ports-from-one-another</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#isolated Network#isolated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isolated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Isolated
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
