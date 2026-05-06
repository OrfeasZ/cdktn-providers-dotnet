using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupAssociation")]
    public class DisasterRecoveryDrProtectionGroupAssociation : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#role DisasterRecoveryDrProtectionGroup#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public string Role
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#peer_id DisasterRecoveryDrProtectionGroup#peer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#peer_region DisasterRecoveryDrProtectionGroup#peer_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerRegion
        {
            get;
            set;
        }
    }
}
