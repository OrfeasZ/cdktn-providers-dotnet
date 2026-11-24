using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupVaultResourceGuardAssociation
{
    [JsiiByValue(fqn: "azurerm.dataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationTimeouts")]
    public class DataProtectionBackupVaultResourceGuardAssociationTimeouts : azurerm.DataProtectionBackupVaultResourceGuardAssociation.IDataProtectionBackupVaultResourceGuardAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#create DataProtectionBackupVaultResourceGuardAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#delete DataProtectionBackupVaultResourceGuardAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#read DataProtectionBackupVaultResourceGuardAssociation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
