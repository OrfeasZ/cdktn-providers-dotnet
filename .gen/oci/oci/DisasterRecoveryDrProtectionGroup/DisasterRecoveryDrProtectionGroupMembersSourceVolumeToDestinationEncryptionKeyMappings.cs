using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings")]
    public class DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings
    {
        /// <summary>destination_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_encryption_key DisasterRecoveryDrProtectionGroup#destination_encryption_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey? DestinationEncryptionKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_volume_id DisasterRecoveryDrProtectionGroup#source_volume_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceVolumeId
        {
            get;
            set;
        }
    }
}
