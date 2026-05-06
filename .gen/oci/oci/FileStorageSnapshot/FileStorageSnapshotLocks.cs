using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageSnapshot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageSnapshot.FileStorageSnapshotLocks")]
    public class FileStorageSnapshotLocks : oci.FileStorageSnapshot.IFileStorageSnapshotLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_snapshot#type FileStorageSnapshot#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_snapshot#message FileStorageSnapshot#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_snapshot#related_resource_id FileStorageSnapshot#related_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelatedResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_snapshot#time_created FileStorageSnapshot#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }
    }
}
