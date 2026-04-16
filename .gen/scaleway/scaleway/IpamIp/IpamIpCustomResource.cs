using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IpamIp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.ipamIp.IpamIpCustomResource")]
    public class IpamIpCustomResource : scaleway.IpamIp.IIpamIpCustomResource
    {
        /// <summary>MAC address of the custom resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#mac_address IpamIp#mac_address}
        /// </remarks>
        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string MacAddress
        {
            get;
            set;
        }

        /// <summary>When the resource is in a Private Network, a DNS record is available to resolve the resource name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip#name IpamIp#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
