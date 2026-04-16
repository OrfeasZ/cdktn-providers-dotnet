using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Lb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.lb.LbPrivateNetwork")]
    public class LbPrivateNetwork : scaleway.Lb.ILbPrivateNetwork
    {
        /// <summary>The Private Network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb#private_network_id Lb#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateNetworkId
        {
            get;
            set;
        }

        /// <summary>IPAM ID of a pre-reserved IP address to assign to the Load Balancer on this Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb#ipam_ids Lb#ipam_ids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipamIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpamIds
        {
            get;
            set;
        }
    }
}
