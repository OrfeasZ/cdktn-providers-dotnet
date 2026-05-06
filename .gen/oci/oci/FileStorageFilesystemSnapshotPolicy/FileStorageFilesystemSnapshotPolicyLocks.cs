using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageFilesystemSnapshotPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicyLocks")]
    public class FileStorageFilesystemSnapshotPolicyLocks : oci.FileStorageFilesystemSnapshotPolicy.IFileStorageFilesystemSnapshotPolicyLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#type FileStorageFilesystemSnapshotPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#message FileStorageFilesystemSnapshotPolicy#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#related_resource_id FileStorageFilesystemSnapshotPolicy#related_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelatedResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#time_created FileStorageFilesystemSnapshotPolicy#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }
    }
}
