using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkForwardAddresses")]
    public class NetworkForwardAddresses : libvirt.Network.INetworkForwardAddresses
    {
        /// <summary>Declares a PCI address used as a forwarding target, identifying a specific host PCI device through which the network is connected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#pci Network#pci}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pci", typeJson: "{\"fqn\":\"libvirt.network.NetworkForwardAddressesPci\"}", isOptional: true)]
        public libvirt.Network.INetworkForwardAddressesPci? Pci
        {
            get;
            set;
        }
    }
}
