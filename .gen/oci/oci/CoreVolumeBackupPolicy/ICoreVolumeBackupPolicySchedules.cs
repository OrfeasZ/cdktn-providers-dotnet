using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackupPolicy
{
    [JsiiInterface(nativeType: typeof(ICoreVolumeBackupPolicySchedules), fullyQualifiedName: "oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedules")]
    public interface ICoreVolumeBackupPolicySchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#backup_type CoreVolumeBackupPolicy#backup_type}.</summary>
        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
        string BackupType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#period CoreVolumeBackupPolicy#period}.</summary>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
        string Period
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#retention_seconds CoreVolumeBackupPolicy#retention_seconds}.</summary>
        [JsiiProperty(name: "retentionSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#day_of_month CoreVolumeBackupPolicy#day_of_month}.</summary>
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DayOfMonth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#day_of_week CoreVolumeBackupPolicy#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#hour_of_day CoreVolumeBackupPolicy#hour_of_day}.</summary>
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HourOfDay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#is_prevent_deletion_enabled CoreVolumeBackupPolicy#is_prevent_deletion_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isPreventDeletionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPreventDeletionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#is_retention_lock_enabled CoreVolumeBackupPolicy#is_retention_lock_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRetentionLockEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRetentionLockEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#month CoreVolumeBackupPolicy#month}.</summary>
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Month
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#offset_seconds CoreVolumeBackupPolicy#offset_seconds}.</summary>
        [JsiiProperty(name: "offsetSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OffsetSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#offset_type CoreVolumeBackupPolicy#offset_type}.</summary>
        [JsiiProperty(name: "offsetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OffsetType
        {
            get
            {
                return null;
            }
        }

        /// <summary>retention_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#retention_period CoreVolumeBackupPolicy#retention_period}
        /// </remarks>
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"fqn\":\"oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedulesRetentionPeriod? RetentionPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#time_zone CoreVolumeBackupPolicy#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeZone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVolumeBackupPolicySchedules), fullyQualifiedName: "oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedules")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#backup_type CoreVolumeBackupPolicy#backup_type}.</summary>
            [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#period CoreVolumeBackupPolicy#period}.</summary>
            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
            public string Period
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#retention_seconds CoreVolumeBackupPolicy#retention_seconds}.</summary>
            [JsiiProperty(name: "retentionSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#day_of_month CoreVolumeBackupPolicy#day_of_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DayOfMonth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#day_of_week CoreVolumeBackupPolicy#day_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DayOfWeek
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#hour_of_day CoreVolumeBackupPolicy#hour_of_day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HourOfDay
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#is_prevent_deletion_enabled CoreVolumeBackupPolicy#is_prevent_deletion_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isPreventDeletionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPreventDeletionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#is_retention_lock_enabled CoreVolumeBackupPolicy#is_retention_lock_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isRetentionLockEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRetentionLockEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#month CoreVolumeBackupPolicy#month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Month
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#offset_seconds CoreVolumeBackupPolicy#offset_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "offsetSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OffsetSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#offset_type CoreVolumeBackupPolicy#offset_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "offsetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OffsetType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>retention_period block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#retention_period CoreVolumeBackupPolicy#retention_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriod", typeJson: "{\"fqn\":\"oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriod\"}", isOptional: true)]
            public oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedulesRetentionPeriod? RetentionPeriod
            {
                get => GetInstanceProperty<oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedulesRetentionPeriod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_volume_backup_policy#time_zone CoreVolumeBackupPolicy#time_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeZone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
