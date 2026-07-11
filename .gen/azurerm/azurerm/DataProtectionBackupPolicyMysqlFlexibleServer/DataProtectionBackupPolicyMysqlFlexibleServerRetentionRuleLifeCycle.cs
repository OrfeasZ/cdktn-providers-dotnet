using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyMysqlFlexibleServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle")]
    public class DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle : azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_mysql_flexible_server#data_store_type DataProtectionBackupPolicyMysqlFlexibleServer#data_store_type}.</summary>
        [JsiiProperty(name: "dataStoreType", typeJson: "{\"primitive\":\"string\"}")]
        public string DataStoreType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_mysql_flexible_server#duration DataProtectionBackupPolicyMysqlFlexibleServer#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public string Duration
        {
            get;
            set;
        }
    }
}
