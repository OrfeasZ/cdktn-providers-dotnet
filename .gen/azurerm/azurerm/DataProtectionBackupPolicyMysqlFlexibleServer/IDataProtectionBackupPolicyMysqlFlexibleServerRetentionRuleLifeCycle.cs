using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyMysqlFlexibleServer
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle")]
    public interface IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_mysql_flexible_server#data_store_type DataProtectionBackupPolicyMysqlFlexibleServer#data_store_type}.</summary>
        [JsiiProperty(name: "dataStoreType", typeJson: "{\"primitive\":\"string\"}")]
        string DataStoreType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_mysql_flexible_server#duration DataProtectionBackupPolicyMysqlFlexibleServer#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        string Duration
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleLifeCycle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_mysql_flexible_server#data_store_type DataProtectionBackupPolicyMysqlFlexibleServer#data_store_type}.</summary>
            [JsiiProperty(name: "dataStoreType", typeJson: "{\"primitive\":\"string\"}")]
            public string DataStoreType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_mysql_flexible_server#duration DataProtectionBackupPolicyMysqlFlexibleServer#duration}.</summary>
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
            public string Duration
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
