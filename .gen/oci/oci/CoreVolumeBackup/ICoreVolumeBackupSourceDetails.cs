using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackup
{
    [JsiiInterface(nativeType: typeof(ICoreVolumeBackupSourceDetails), fullyQualifiedName: "oci.coreVolumeBackup.CoreVolumeBackupSourceDetails")]
    public interface ICoreVolumeBackupSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#region CoreVolumeBackup#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#volume_backup_id CoreVolumeBackup#volume_backup_id}.</summary>
        [JsiiProperty(name: "volumeBackupId", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeBackupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#kms_key_id CoreVolumeBackup#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVolumeBackupSourceDetails), fullyQualifiedName: "oci.coreVolumeBackup.CoreVolumeBackupSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVolumeBackup.ICoreVolumeBackupSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#region CoreVolumeBackup#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#volume_backup_id CoreVolumeBackup#volume_backup_id}.</summary>
            [JsiiProperty(name: "volumeBackupId", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeBackupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#kms_key_id CoreVolumeBackup#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
