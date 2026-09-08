using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.BranchBackupSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "neon.branchBackupSchedule.BranchBackupScheduleSchedule")]
    public class BranchBackupScheduleSchedule : neon.BranchBackupSchedule.IBranchBackupScheduleSchedule
    {
        /// <summary>Snapshot frequency: daily, weekly, or monthly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#frequency BranchBackupSchedule#frequency}
        /// </remarks>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        public string Frequency
        {
            get;
            set;
        }

        /// <summary>Day of the week or month, when applicable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#day BranchBackupSchedule#day}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Day
        {
            get;
            set;
        }

        /// <summary>Hour of the day, when applicable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#hour BranchBackupSchedule#hour}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hour
        {
            get;
            set;
        }

        /// <summary>Month of the year, when applicable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#month BranchBackupSchedule#month}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Month
        {
            get;
            set;
        }

        /// <summary>How long to retain scheduled snapshots, in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#retention_seconds BranchBackupSchedule#retention_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionSeconds
        {
            get;
            set;
        }
    }
}
