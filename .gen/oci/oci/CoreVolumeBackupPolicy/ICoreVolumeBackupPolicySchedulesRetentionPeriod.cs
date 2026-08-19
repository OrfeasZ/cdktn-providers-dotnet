using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackupPolicy
{
    [JsiiInterface(nativeType: typeof(ICoreVolumeBackupPolicySchedulesRetentionPeriod), fullyQualifiedName: "oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriod")]
    public interface ICoreVolumeBackupPolicySchedulesRetentionPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_volume_backup_policy#retention_time_amount CoreVolumeBackupPolicy#retention_time_amount}.</summary>
        [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionTimeAmount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_volume_backup_policy#retention_time_unit CoreVolumeBackupPolicy#retention_time_unit}.</summary>
        [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
        string RetentionTimeUnit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVolumeBackupPolicySchedulesRetentionPeriod), fullyQualifiedName: "oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriod")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedulesRetentionPeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_volume_backup_policy#retention_time_amount CoreVolumeBackupPolicy#retention_time_amount}.</summary>
            [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionTimeAmount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_volume_backup_policy#retention_time_unit CoreVolumeBackupPolicy#retention_time_unit}.</summary>
            [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string RetentionTimeUnit
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
