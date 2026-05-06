using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolumeBackup.CoreVolumeBackupSourceDetails")]
    public class CoreVolumeBackupSourceDetails : oci.CoreVolumeBackup.ICoreVolumeBackupSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#region CoreVolumeBackup#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#volume_backup_id CoreVolumeBackup#volume_backup_id}.</summary>
        [JsiiProperty(name: "volumeBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeBackupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup#kms_key_id CoreVolumeBackup#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
