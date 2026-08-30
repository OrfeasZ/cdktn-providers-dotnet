using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkForwardAddresses), fullyQualifiedName: "libvirt.network.NetworkForwardAddresses")]
    public interface INetworkForwardAddresses
    {
        /// <summary>Declares a PCI address used as a forwarding target, identifying a specific host PCI device through which the network is connected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#pci Network#pci}
        /// </remarks>
        [JsiiProperty(name: "pci", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardAddressesPci\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkForwardAddressesPci? Pci
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkForwardAddresses), fullyQualifiedName: "libvirt.network.NetworkForwardAddresses")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkForwardAddresses
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Declares a PCI address used as a forwarding target, identifying a specific host PCI device through which the network is connected.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#pci Network#pci}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pci", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardAddressesPci\"}", isOptional: true)]
            public libvirt.Network.INetworkForwardAddressesPci? Pci
            {
                get => GetInstanceProperty<libvirt.Network.INetworkForwardAddressesPci?>();
            }
        }
    }
}
