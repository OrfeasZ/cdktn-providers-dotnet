using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallFirewall.NetworkfirewallFirewallAvailabilityZoneMapping")]
    public class NetworkfirewallFirewallAvailabilityZoneMapping : aws.NetworkfirewallFirewall.INetworkfirewallFirewallAvailabilityZoneMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkfirewall_firewall#availability_zone_id NetworkfirewallFirewall#availability_zone_id}.</summary>
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public string AvailabilityZoneId
        {
            get;
            set;
        }
    }
}
