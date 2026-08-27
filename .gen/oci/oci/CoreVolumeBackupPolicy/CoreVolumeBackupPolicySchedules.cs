using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackupPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedules")]
    public class CoreVolumeBackupPolicySchedules : oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#backup_type CoreVolumeBackupPolicy#backup_type}.</summary>
        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
        public string BackupType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#period CoreVolumeBackupPolicy#period}.</summary>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
        public string Period
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#retention_seconds CoreVolumeBackupPolicy#retention_seconds}.</summary>
        [JsiiProperty(name: "retentionSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#day_of_month CoreVolumeBackupPolicy#day_of_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DayOfMonth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#day_of_week CoreVolumeBackupPolicy#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#hour_of_day CoreVolumeBackupPolicy#hour_of_day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HourOfDay
        {
            get;
            set;
        }

        private object? _isPreventDeletionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#is_prevent_deletion_enabled CoreVolumeBackupPolicy#is_prevent_deletion_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isPreventDeletionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPreventDeletionEnabled
        {
            get => _isPreventDeletionEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPreventDeletionEnabled = value;
            }
        }

        private object? _isRetentionLockEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#is_retention_lock_enabled CoreVolumeBackupPolicy#is_retention_lock_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isRetentionLockEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRetentionLockEnabled
        {
            get => _isRetentionLockEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isRetentionLockEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#month CoreVolumeBackupPolicy#month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Month
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#offset_seconds CoreVolumeBackupPolicy#offset_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offsetSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OffsetSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#offset_type CoreVolumeBackupPolicy#offset_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offsetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OffsetType
        {
            get;
            set;
        }

        /// <summary>retention_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#retention_period CoreVolumeBackupPolicy#retention_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"fqn\":\"oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriod\"}", isOptional: true)]
        public oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedulesRetentionPeriod? RetentionPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/core_volume_backup_policy#time_zone CoreVolumeBackupPolicy#time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }
    }
}
