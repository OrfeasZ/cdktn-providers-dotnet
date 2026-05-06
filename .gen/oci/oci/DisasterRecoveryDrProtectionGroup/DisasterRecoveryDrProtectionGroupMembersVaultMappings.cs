using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVaultMappings")]
    public class DisasterRecoveryDrProtectionGroupMembersVaultMappings : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVaultMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_vault_id DisasterRecoveryDrProtectionGroup#destination_vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationVaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_vault_id DisasterRecoveryDrProtectionGroup#source_vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceVaultId
        {
            get;
            set;
        }
    }
}
