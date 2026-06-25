using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageSnapshot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageSnapshot.FileStorageSnapshotLockDurationDetails")]
    public class FileStorageSnapshotLockDurationDetails : oci.FileStorageSnapshot.IFileStorageSnapshotLockDurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/file_storage_snapshot#lock_duration FileStorageSnapshot#lock_duration}.</summary>
        [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"number\"}")]
        public double LockDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/file_storage_snapshot#lock_mode FileStorageSnapshot#lock_mode}.</summary>
        [JsiiProperty(name: "lockMode", typeJson: "{\"primitive\":\"string\"}")]
        public string LockMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/file_storage_snapshot#cool_off_duration FileStorageSnapshot#cool_off_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coolOffDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoolOffDuration
        {
            get;
            set;
        }
    }
}
