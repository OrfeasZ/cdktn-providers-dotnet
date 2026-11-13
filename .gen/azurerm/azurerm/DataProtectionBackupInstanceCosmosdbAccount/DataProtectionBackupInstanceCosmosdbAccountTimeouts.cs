using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupInstanceCosmosdbAccount
{
    [JsiiByValue(fqn: "azurerm.dataProtectionBackupInstanceCosmosdbAccount.DataProtectionBackupInstanceCosmosdbAccountTimeouts")]
    public class DataProtectionBackupInstanceCosmosdbAccountTimeouts : azurerm.DataProtectionBackupInstanceCosmosdbAccount.IDataProtectionBackupInstanceCosmosdbAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.14.0/docs/resources/data_protection_backup_instance_cosmosdb_account#create DataProtectionBackupInstanceCosmosdbAccount#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.14.0/docs/resources/data_protection_backup_instance_cosmosdb_account#delete DataProtectionBackupInstanceCosmosdbAccount#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.14.0/docs/resources/data_protection_backup_instance_cosmosdb_account#read DataProtectionBackupInstanceCosmosdbAccount#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.14.0/docs/resources/data_protection_backup_instance_cosmosdb_account#update DataProtectionBackupInstanceCosmosdbAccount#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
