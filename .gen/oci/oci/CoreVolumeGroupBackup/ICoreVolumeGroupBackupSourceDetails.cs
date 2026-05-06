using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeGroupBackup
{
    [JsiiInterface(nativeType: typeof(ICoreVolumeGroupBackupSourceDetails), fullyQualifiedName: "oci.coreVolumeGroupBackup.CoreVolumeGroupBackupSourceDetails")]
    public interface ICoreVolumeGroupBackupSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#region CoreVolumeGroupBackup#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#volume_group_backup_id CoreVolumeGroupBackup#volume_group_backup_id}.</summary>
        [JsiiProperty(name: "volumeGroupBackupId", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeGroupBackupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#kms_key_id CoreVolumeGroupBackup#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVolumeGroupBackupSourceDetails), fullyQualifiedName: "oci.coreVolumeGroupBackup.CoreVolumeGroupBackupSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVolumeGroupBackup.ICoreVolumeGroupBackupSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#region CoreVolumeGroupBackup#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#volume_group_backup_id CoreVolumeGroupBackup#volume_group_backup_id}.</summary>
            [JsiiProperty(name: "volumeGroupBackupId", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeGroupBackupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#kms_key_id CoreVolumeGroupBackup#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
