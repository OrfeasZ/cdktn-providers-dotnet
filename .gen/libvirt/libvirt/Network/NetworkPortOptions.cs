using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkPortOptions")]
    public class NetworkPortOptions : libvirt.Network.INetworkPortOptions
    {
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
            get;
            set;
        }
    }
}
