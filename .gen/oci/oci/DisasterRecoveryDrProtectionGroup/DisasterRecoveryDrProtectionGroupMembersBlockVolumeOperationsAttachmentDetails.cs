using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails")]
    public class DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#volume_attachment_reference_instance_id DisasterRecoveryDrProtectionGroup#volume_attachment_reference_instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeAttachmentReferenceInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeAttachmentReferenceInstanceId
        {
            get;
            set;
        }
    }
}
