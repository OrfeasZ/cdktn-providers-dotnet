using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupInstanceDataLakeStorage
{
    [JsiiByValue(fqn: "azurerm.dataProtectionBackupInstanceDataLakeStorage.DataProtectionBackupInstanceDataLakeStorageTimeouts")]
    public class DataProtectionBackupInstanceDataLakeStorageTimeouts : azurerm.DataProtectionBackupInstanceDataLakeStorage.IDataProtectionBackupInstanceDataLakeStorageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_protection_backup_instance_data_lake_storage#create DataProtectionBackupInstanceDataLakeStorage#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_protection_backup_instance_data_lake_storage#delete DataProtectionBackupInstanceDataLakeStorage#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_protection_backup_instance_data_lake_storage#read DataProtectionBackupInstanceDataLakeStorage#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_protection_backup_instance_data_lake_storage#update DataProtectionBackupInstanceDataLakeStorage#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
