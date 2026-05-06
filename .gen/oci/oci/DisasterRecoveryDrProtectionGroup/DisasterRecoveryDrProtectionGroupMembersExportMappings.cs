using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersExportMappings")]
    public class DisasterRecoveryDrProtectionGroupMembersExportMappings : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersExportMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_mount_target_id DisasterRecoveryDrProtectionGroup#destination_mount_target_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationMountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationMountTargetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#export_id DisasterRecoveryDrProtectionGroup#export_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exportId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExportId
        {
            get;
            set;
        }
    }
}
