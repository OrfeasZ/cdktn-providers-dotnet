using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageFilesystemSnapshotPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicySchedules")]
    public class FileStorageFilesystemSnapshotPolicySchedules : oci.FileStorageFilesystemSnapshotPolicy.IFileStorageFilesystemSnapshotPolicySchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#period FileStorageFilesystemSnapshotPolicy#period}.</summary>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
        public string Period
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#time_zone FileStorageFilesystemSnapshotPolicy#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#day_of_month FileStorageFilesystemSnapshotPolicy#day_of_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DayOfMonth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#day_of_week FileStorageFilesystemSnapshotPolicy#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#hour_of_day FileStorageFilesystemSnapshotPolicy#hour_of_day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HourOfDay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#month FileStorageFilesystemSnapshotPolicy#month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Month
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#retention_duration_in_seconds FileStorageFilesystemSnapshotPolicy#retention_duration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionDurationInSeconds", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetentionDurationInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#schedule_prefix FileStorageFilesystemSnapshotPolicy#schedule_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schedulePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchedulePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#time_schedule_start FileStorageFilesystemSnapshotPolicy#time_schedule_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeScheduleStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeScheduleStart
        {
            get;
            set;
        }
    }
}
