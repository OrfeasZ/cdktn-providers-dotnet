using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesWaitForIp")]
    public class DomainDevicesInterfacesWaitForIp : libvirt.Domain.IDomainDevicesInterfacesWaitForIp
    {
        /// <summary>CIDR network prefix to wait for (e.g. "0.0.0.0/0" for any IPv4, "::/0" for any IPv6). If omitted, any address satisfies the wait. Matching is by CIDR membership only; loopback and link-local addresses are not excluded (127.0.0.1 matches 0.0.0.0/0). To wait for a routable address, specify your subnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Network
        {
            get;
            set;
        }

        /// <summary>Source to query for IP addresses: 'lease', 'agent', or 'any'. Default: 'any'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }

        /// <summary>Maximum time to wait for IP address in seconds. Default: 300.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timeout Domain#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }
    }
}
