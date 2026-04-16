using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallFirewallAvailabilityZoneMapping), fullyQualifiedName: "aws.networkfirewallFirewall.NetworkfirewallFirewallAvailabilityZoneMapping")]
    public interface INetworkfirewallFirewallAvailabilityZoneMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkfirewall_firewall#availability_zone_id NetworkfirewallFirewall#availability_zone_id}.</summary>
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityZoneId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallFirewallAvailabilityZoneMapping), fullyQualifiedName: "aws.networkfirewallFirewall.NetworkfirewallFirewallAvailabilityZoneMapping")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallFirewall.INetworkfirewallFirewallAvailabilityZoneMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/networkfirewall_firewall#availability_zone_id NetworkfirewallFirewall#availability_zone_id}.</summary>
            [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityZoneId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
