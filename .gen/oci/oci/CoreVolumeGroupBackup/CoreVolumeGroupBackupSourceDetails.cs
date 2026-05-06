using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeGroupBackup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolumeGroupBackup.CoreVolumeGroupBackupSourceDetails")]
    public class CoreVolumeGroupBackupSourceDetails : oci.CoreVolumeGroupBackup.ICoreVolumeGroupBackupSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#region CoreVolumeGroupBackup#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#volume_group_backup_id CoreVolumeGroupBackup#volume_group_backup_id}.</summary>
        [JsiiProperty(name: "volumeGroupBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeGroupBackupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group_backup#kms_key_id CoreVolumeGroupBackup#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
