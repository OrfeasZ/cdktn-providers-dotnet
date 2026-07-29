using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackup
{
    [JsiiInterface(nativeType: typeof(ICoreVolumeBackupRetentionPeriod), fullyQualifiedName: "oci.coreVolumeBackup.CoreVolumeBackupRetentionPeriod")]
    public interface ICoreVolumeBackupRetentionPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_volume_backup#retention_time_amount CoreVolumeBackup#retention_time_amount}.</summary>
        [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionTimeAmount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_volume_backup#retention_time_unit CoreVolumeBackup#retention_time_unit}.</summary>
        [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
        string RetentionTimeUnit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVolumeBackupRetentionPeriod), fullyQualifiedName: "oci.coreVolumeBackup.CoreVolumeBackupRetentionPeriod")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVolumeBackup.ICoreVolumeBackupRetentionPeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_volume_backup#retention_time_amount CoreVolumeBackup#retention_time_amount}.</summary>
            [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionTimeAmount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/core_volume_backup#retention_time_unit CoreVolumeBackup#retention_time_unit}.</summary>
            [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string RetentionTimeUnit
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
