using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupInstanceMysqlFlexibleServer
{
    [JsiiByValue(fqn: "azurerm.dataProtectionBackupInstanceMysqlFlexibleServer.DataProtectionBackupInstanceMysqlFlexibleServerTimeouts")]
    public class DataProtectionBackupInstanceMysqlFlexibleServerTimeouts : azurerm.DataProtectionBackupInstanceMysqlFlexibleServer.IDataProtectionBackupInstanceMysqlFlexibleServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_protection_backup_instance_mysql_flexible_server#create DataProtectionBackupInstanceMysqlFlexibleServer#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_protection_backup_instance_mysql_flexible_server#delete DataProtectionBackupInstanceMysqlFlexibleServer#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_protection_backup_instance_mysql_flexible_server#read DataProtectionBackupInstanceMysqlFlexibleServer#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_protection_backup_instance_mysql_flexible_server#update DataProtectionBackupInstanceMysqlFlexibleServer#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
