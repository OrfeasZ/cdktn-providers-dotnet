using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IpamIp
{
    [JsiiByValue(fqn: "scaleway.ipamIp.IpamIpSource")]
    public class IpamIpSource : scaleway.IpamIp.IIpamIpSource
    {
        /// <summary>Private Network the IP lives in if the IP is a private IP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#private_network_id IpamIp#private_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateNetworkId
        {
            get;
            set;
        }

        /// <summary>Private Network subnet the IP lives in if the IP is a private IP in a Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#subnet_id IpamIp#subnet_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Zone the IP lives in if the IP is a public zoned one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#zonal IpamIp#zonal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zonal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Zonal
        {
            get;
            set;
        }
    }
}
