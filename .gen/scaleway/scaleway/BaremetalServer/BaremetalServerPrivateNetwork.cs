using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.BaremetalServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.baremetalServer.BaremetalServerPrivateNetwork")]
    public class BaremetalServerPrivateNetwork : scaleway.BaremetalServer.IBaremetalServerPrivateNetwork
    {
        /// <summary>The ID of the private network to associate with the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#id BaremetalServer#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>List of IPAM IP IDs to attach to the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#ipam_ip_ids BaremetalServer#ipam_ip_ids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipamIpIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpamIpIds
        {
            get;
            set;
        }
    }
}
