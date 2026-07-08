using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageFilesystemSnapshotPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails")]
    public class FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails : oci.FileStorageFilesystemSnapshotPolicy.IFileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/file_storage_filesystem_snapshot_policy#lock_duration FileStorageFilesystemSnapshotPolicy#lock_duration}.</summary>
        [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"number\"}")]
        public double LockDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/file_storage_filesystem_snapshot_policy#lock_mode FileStorageFilesystemSnapshotPolicy#lock_mode}.</summary>
        [JsiiProperty(name: "lockMode", typeJson: "{\"primitive\":\"string\"}")]
        public string LockMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/file_storage_filesystem_snapshot_policy#cool_off_duration FileStorageFilesystemSnapshotPolicy#cool_off_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coolOffDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoolOffDuration
        {
            get;
            set;
        }
    }
}
