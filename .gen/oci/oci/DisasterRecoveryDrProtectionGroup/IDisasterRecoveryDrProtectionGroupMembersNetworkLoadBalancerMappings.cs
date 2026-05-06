using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings")]
    public interface IDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_network_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_network_load_balancer_id}.</summary>
        [JsiiProperty(name: "destinationNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationNetworkLoadBalancerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_network_load_balancer_id DisasterRecoveryDrProtectionGroup#source_network_load_balancer_id}.</summary>
        [JsiiProperty(name: "sourceNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceNetworkLoadBalancerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersNetworkLoadBalancerMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_network_load_balancer_id DisasterRecoveryDrProtectionGroup#destination_network_load_balancer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationNetworkLoadBalancerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_network_load_balancer_id DisasterRecoveryDrProtectionGroup#source_network_load_balancer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceNetworkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceNetworkLoadBalancerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
