using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageFilesystemSnapshotPolicy
{
    [JsiiInterface(nativeType: typeof(IFileStorageFilesystemSnapshotPolicyLocks), fullyQualifiedName: "oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicyLocks")]
    public interface IFileStorageFilesystemSnapshotPolicyLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#type FileStorageFilesystemSnapshotPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#message FileStorageFilesystemSnapshotPolicy#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#related_resource_id FileStorageFilesystemSnapshotPolicy#related_resource_id}.</summary>
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RelatedResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#time_created FileStorageFilesystemSnapshotPolicy#time_created}.</summary>
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeCreated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFileStorageFilesystemSnapshotPolicyLocks), fullyQualifiedName: "oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicyLocks")]
        internal sealed class _Proxy : DeputyBase, oci.FileStorageFilesystemSnapshotPolicy.IFileStorageFilesystemSnapshotPolicyLocks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#type FileStorageFilesystemSnapshotPolicy#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#message FileStorageFilesystemSnapshotPolicy#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#related_resource_id FileStorageFilesystemSnapshotPolicy#related_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RelatedResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_filesystem_snapshot_policy#time_created FileStorageFilesystemSnapshotPolicy#time_created}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeCreated
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
