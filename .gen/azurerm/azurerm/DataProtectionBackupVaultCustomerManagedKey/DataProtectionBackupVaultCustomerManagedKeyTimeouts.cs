using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupVaultCustomerManagedKey
{
    [JsiiByValue(fqn: "azurerm.dataProtectionBackupVaultCustomerManagedKey.DataProtectionBackupVaultCustomerManagedKeyTimeouts")]
    public class DataProtectionBackupVaultCustomerManagedKeyTimeouts : azurerm.DataProtectionBackupVaultCustomerManagedKey.IDataProtectionBackupVaultCustomerManagedKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/data_protection_backup_vault_customer_managed_key#create DataProtectionBackupVaultCustomerManagedKey#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/data_protection_backup_vault_customer_managed_key#delete DataProtectionBackupVaultCustomerManagedKey#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/data_protection_backup_vault_customer_managed_key#read DataProtectionBackupVaultCustomerManagedKey#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/data_protection_backup_vault_customer_managed_key#update DataProtectionBackupVaultCustomerManagedKey#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
