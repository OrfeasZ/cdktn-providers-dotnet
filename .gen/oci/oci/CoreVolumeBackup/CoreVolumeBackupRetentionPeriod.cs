using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolumeBackup.CoreVolumeBackupRetentionPeriod")]
    public class CoreVolumeBackupRetentionPeriod : oci.CoreVolumeBackup.ICoreVolumeBackupRetentionPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_volume_backup#retention_time_amount CoreVolumeBackup#retention_time_amount}.</summary>
        [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionTimeAmount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_volume_backup#retention_time_unit CoreVolumeBackup#retention_time_unit}.</summary>
        [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string RetentionTimeUnit
        {
            get;
            set;
        }
    }
}
