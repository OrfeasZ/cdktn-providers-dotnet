using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkVirtualPort")]
    public class NetworkVirtualPort : libvirt.Network.INetworkVirtualPort
    {
        /// <summary>Provides backend-specific virtual port profile parameters for this port group, with one child element per backend type (e.g. Any, MidoNet, OpenVSwitch).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#params Network#params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"libvirt.network.NetworkVirtualPortParams\"}", isOptional: true)]
        public libvirt.Network.INetworkVirtualPortParams? Params
        {
            get;
            set;
        }
    }
}
