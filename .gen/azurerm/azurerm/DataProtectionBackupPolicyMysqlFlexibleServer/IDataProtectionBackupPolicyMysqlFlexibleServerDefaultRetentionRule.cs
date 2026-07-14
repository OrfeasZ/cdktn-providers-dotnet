using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyMysqlFlexibleServer
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRule), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRule")]
    public interface IDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRule
    {
        /// <summary>life_cycle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_protection_backup_policy_mysql_flexible_server#life_cycle DataProtectionBackupPolicyMysqlFlexibleServer#life_cycle}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleLifeCycle" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "lifeCycle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleLifeCycle\"},\"kind\":\"array\"}}]}}")]
        object LifeCycle
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRule), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>life_cycle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_protection_backup_policy_mysql_flexible_server#life_cycle DataProtectionBackupPolicyMysqlFlexibleServer#life_cycle}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataProtectionBackupPolicyMysqlFlexibleServer.IDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleLifeCycle" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "lifeCycle", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataProtectionBackupPolicyMysqlFlexibleServer.DataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleLifeCycle\"},\"kind\":\"array\"}}]}}")]
            public object LifeCycle
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
