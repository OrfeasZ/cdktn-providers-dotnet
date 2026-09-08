using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.BranchBackupSchedule
{
    [JsiiInterface(nativeType: typeof(IBranchBackupScheduleSchedule), fullyQualifiedName: "neon.branchBackupSchedule.BranchBackupScheduleSchedule")]
    public interface IBranchBackupScheduleSchedule
    {
        /// <summary>Snapshot frequency: daily, weekly, or monthly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#frequency BranchBackupSchedule#frequency}
        /// </remarks>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        string Frequency
        {
            get;
        }

        /// <summary>Day of the week or month, when applicable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#day BranchBackupSchedule#day}
        /// </remarks>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Day
        {
            get
            {
                return null;
            }
        }

        /// <summary>Hour of the day, when applicable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#hour BranchBackupSchedule#hour}
        /// </remarks>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Hour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Month of the year, when applicable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#month BranchBackupSchedule#month}
        /// </remarks>
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Month
        {
            get
            {
                return null;
            }
        }

        /// <summary>How long to retain scheduled snapshots, in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#retention_seconds BranchBackupSchedule#retention_seconds}
        /// </remarks>
        [JsiiProperty(name: "retentionSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchBackupScheduleSchedule), fullyQualifiedName: "neon.branchBackupSchedule.BranchBackupScheduleSchedule")]
        internal sealed class _Proxy : DeputyBase, neon.BranchBackupSchedule.IBranchBackupScheduleSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Snapshot frequency: daily, weekly, or monthly.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#frequency BranchBackupSchedule#frequency}
            /// </remarks>
            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
            public string Frequency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Day of the week or month, when applicable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#day BranchBackupSchedule#day}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Day
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Hour of the day, when applicable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#hour BranchBackupSchedule#hour}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Hour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Month of the year, when applicable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#month BranchBackupSchedule#month}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Month
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>How long to retain scheduled snapshots, in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/branch_backup_schedule#retention_seconds BranchBackupSchedule#retention_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
