using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreBootVolumeBackup
{
    [JsiiInterface(nativeType: typeof(ICoreBootVolumeBackupRetentionPeriod), fullyQualifiedName: "oci.coreBootVolumeBackup.CoreBootVolumeBackupRetentionPeriod")]
    public interface ICoreBootVolumeBackupRetentionPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_boot_volume_backup#retention_time_amount CoreBootVolumeBackup#retention_time_amount}.</summary>
        [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionTimeAmount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_boot_volume_backup#retention_time_unit CoreBootVolumeBackup#retention_time_unit}.</summary>
        [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
        string RetentionTimeUnit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreBootVolumeBackupRetentionPeriod), fullyQualifiedName: "oci.coreBootVolumeBackup.CoreBootVolumeBackupRetentionPeriod")]
        internal sealed class _Proxy : DeputyBase, oci.CoreBootVolumeBackup.ICoreBootVolumeBackupRetentionPeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_boot_volume_backup#retention_time_amount CoreBootVolumeBackup#retention_time_amount}.</summary>
            [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionTimeAmount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/core_boot_volume_backup#retention_time_unit CoreBootVolumeBackup#retention_time_unit}.</summary>
            [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string RetentionTimeUnit
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
