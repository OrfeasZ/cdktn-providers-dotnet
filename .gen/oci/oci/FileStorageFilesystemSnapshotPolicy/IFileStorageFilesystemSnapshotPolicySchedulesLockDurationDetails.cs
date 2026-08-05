using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageFilesystemSnapshotPolicy
{
    [JsiiInterface(nativeType: typeof(IFileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails), fullyQualifiedName: "oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails")]
    public interface IFileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/file_storage_filesystem_snapshot_policy#lock_duration FileStorageFilesystemSnapshotPolicy#lock_duration}.</summary>
        [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"number\"}")]
        double LockDuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/file_storage_filesystem_snapshot_policy#lock_mode FileStorageFilesystemSnapshotPolicy#lock_mode}.</summary>
        [JsiiProperty(name: "lockMode", typeJson: "{\"primitive\":\"string\"}")]
        string LockMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/file_storage_filesystem_snapshot_policy#cool_off_duration FileStorageFilesystemSnapshotPolicy#cool_off_duration}.</summary>
        [JsiiProperty(name: "coolOffDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoolOffDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails), fullyQualifiedName: "oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FileStorageFilesystemSnapshotPolicy.IFileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/file_storage_filesystem_snapshot_policy#lock_duration FileStorageFilesystemSnapshotPolicy#lock_duration}.</summary>
            [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"number\"}")]
            public double LockDuration
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/file_storage_filesystem_snapshot_policy#lock_mode FileStorageFilesystemSnapshotPolicy#lock_mode}.</summary>
            [JsiiProperty(name: "lockMode", typeJson: "{\"primitive\":\"string\"}")]
            public string LockMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/file_storage_filesystem_snapshot_policy#cool_off_duration FileStorageFilesystemSnapshotPolicy#cool_off_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coolOffDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoolOffDuration
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
