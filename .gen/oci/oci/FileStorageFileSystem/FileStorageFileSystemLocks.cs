using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageFileSystem.FileStorageFileSystemLocks")]
    public class FileStorageFileSystemLocks : oci.FileStorageFileSystem.IFileStorageFileSystemLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_file_system#type FileStorageFileSystem#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_file_system#message FileStorageFileSystem#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_file_system#related_resource_id FileStorageFileSystem#related_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelatedResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_file_system#time_created FileStorageFileSystem#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }
    }
}
