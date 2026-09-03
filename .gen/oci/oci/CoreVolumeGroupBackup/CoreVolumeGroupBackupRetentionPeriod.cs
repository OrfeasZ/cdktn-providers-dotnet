using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeGroupBackup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolumeGroupBackup.CoreVolumeGroupBackupRetentionPeriod")]
    public class CoreVolumeGroupBackupRetentionPeriod : oci.CoreVolumeGroupBackup.ICoreVolumeGroupBackupRetentionPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_group_backup#retention_time_amount CoreVolumeGroupBackup#retention_time_amount}.</summary>
        [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionTimeAmount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_group_backup#retention_time_unit CoreVolumeGroupBackup#retention_time_unit}.</summary>
        [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string RetentionTimeUnit
        {
            get;
            set;
        }
    }
}
