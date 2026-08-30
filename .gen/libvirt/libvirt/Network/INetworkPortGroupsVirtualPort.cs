using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkPortGroupsVirtualPort), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPort")]
    public interface INetworkPortGroupsVirtualPort
    {
        /// <summary>Provides backend-specific virtual port profile parameters for this port group, with one child element per backend type (e.g. Any, MidoNet, OpenVSwitch).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#params Network#params}
        /// </remarks>
        [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParams\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Network.INetworkPortGroupsVirtualPortParams? Params
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkPortGroupsVirtualPort), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPort")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkPortGroupsVirtualPort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Provides backend-specific virtual port profile parameters for this port group, with one child element per backend type (e.g. Any, MidoNet, OpenVSwitch).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#params Network#params}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"libvirt.network.NetworkPortGroupsVirtualPortParams\"}", isOptional: true)]
            public libvirt.Network.INetworkPortGroupsVirtualPortParams? Params
            {
                get => GetInstanceProperty<libvirt.Network.INetworkPortGroupsVirtualPortParams?>();
            }
        }
    }
}
