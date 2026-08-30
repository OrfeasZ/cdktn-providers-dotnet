using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.network.NetworkMetadata")]
    public class NetworkMetadata : libvirt.Network.INetworkMetadata
    {
        /// <summary>Sets arbitrary user-defined XML metadata attached to the network; libvirt stores it verbatim and does not interpret its contents.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#general-metadata">https://libvirt.org/formatnetwork.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#xml Network#xml}
        /// </remarks>
        [JsiiProperty(name: "xml", typeJson: "{\"primitive\":\"string\"}")]
        public string Xml
        {
            get;
            set;
        }
    }
}
