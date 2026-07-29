using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackupPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriod")]
    public class CoreVolumeBackupPolicySchedulesRetentionPeriod : oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedulesRetentionPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_volume_backup_policy#retention_time_amount CoreVolumeBackupPolicy#retention_time_amount}.</summary>
        [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionTimeAmount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_volume_backup_policy#retention_time_unit CoreVolumeBackupPolicy#retention_time_unit}.</summary>
        [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string RetentionTimeUnit
        {
            get;
            set;
        }
    }
}
