using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupConfig")]
    public class DisasterRecoveryDrProtectionGroupMembersBackupConfig : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#backup_schedule DisasterRecoveryDrProtectionGroup#backup_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupSchedule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#exclude_namespaces DisasterRecoveryDrProtectionGroup#exclude_namespaces}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeNamespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludeNamespaces
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#image_replication_vault_secret_id DisasterRecoveryDrProtectionGroup#image_replication_vault_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageReplicationVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageReplicationVaultSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#max_number_of_backups_retained DisasterRecoveryDrProtectionGroup#max_number_of_backups_retained}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNumberOfBackupsRetained", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxNumberOfBackupsRetained
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#namespaces DisasterRecoveryDrProtectionGroup#namespaces}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Namespaces
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#replicate_images DisasterRecoveryDrProtectionGroup#replicate_images}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicateImages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicateImages
        {
            get;
            set;
        }
    }
}
