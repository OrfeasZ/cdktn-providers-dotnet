using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupVaultResourceGuardAssociation
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupVaultResourceGuardAssociationTimeouts), fullyQualifiedName: "azurerm.dataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationTimeouts")]
    public interface IDataProtectionBackupVaultResourceGuardAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#create DataProtectionBackupVaultResourceGuardAssociation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#delete DataProtectionBackupVaultResourceGuardAssociation#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#read DataProtectionBackupVaultResourceGuardAssociation#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupVaultResourceGuardAssociationTimeouts), fullyQualifiedName: "azurerm.dataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupVaultResourceGuardAssociation.IDataProtectionBackupVaultResourceGuardAssociationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#create DataProtectionBackupVaultResourceGuardAssociation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#delete DataProtectionBackupVaultResourceGuardAssociation#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#read DataProtectionBackupVaultResourceGuardAssociation#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
