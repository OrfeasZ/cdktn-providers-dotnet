using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations")]
    public class DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations
    {
        /// <summary>attachment_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#attachment_details DisasterRecoveryDrProtectionGroup#attachment_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attachmentDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails? AttachmentDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_id DisasterRecoveryDrProtectionGroup#block_volume_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockVolumeId
        {
            get;
            set;
        }

        /// <summary>mount_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#mount_details DisasterRecoveryDrProtectionGroup#mount_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mountDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetails\"}", isOptional: true)]
        public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetails? MountDetails
        {
            get;
            set;
        }
    }
}
