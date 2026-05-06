using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings")]
    public class DisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_network_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_network_load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationNetworkLoadBalancerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_network_load_balancer_id DisasterRecoveryDrProtectionGroup#source_network_load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceNetworkLoadBalancerId
        {
            get;
            set;
        }
    }
}
