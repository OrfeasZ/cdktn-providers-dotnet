using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageSnapshot
{
    [JsiiInterface(nativeType: typeof(IFileStorageSnapshotLockDurationDetails), fullyQualifiedName: "oci.fileStorageSnapshot.FileStorageSnapshotLockDurationDetails")]
    public interface IFileStorageSnapshotLockDurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_snapshot#lock_duration FileStorageSnapshot#lock_duration}.</summary>
        [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"number\"}")]
        double LockDuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_snapshot#lock_mode FileStorageSnapshot#lock_mode}.</summary>
        [JsiiProperty(name: "lockMode", typeJson: "{\"primitive\":\"string\"}")]
        string LockMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_snapshot#cool_off_duration FileStorageSnapshot#cool_off_duration}.</summary>
        [JsiiProperty(name: "coolOffDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoolOffDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFileStorageSnapshotLockDurationDetails), fullyQualifiedName: "oci.fileStorageSnapshot.FileStorageSnapshotLockDurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FileStorageSnapshot.IFileStorageSnapshotLockDurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_snapshot#lock_duration FileStorageSnapshot#lock_duration}.</summary>
            [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"number\"}")]
            public double LockDuration
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_snapshot#lock_mode FileStorageSnapshot#lock_mode}.</summary>
            [JsiiProperty(name: "lockMode", typeJson: "{\"primitive\":\"string\"}")]
            public string LockMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_snapshot#cool_off_duration FileStorageSnapshot#cool_off_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coolOffDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoolOffDuration
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
