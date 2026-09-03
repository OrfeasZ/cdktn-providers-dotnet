using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupVault
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupVaultIdentity), fullyQualifiedName: "azurerm.dataProtectionBackupVault.DataProtectionBackupVaultIdentity")]
    public interface IDataProtectionBackupVaultIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_protection_backup_vault#type DataProtectionBackupVault#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_protection_backup_vault#identity_ids DataProtectionBackupVault#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdentityIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupVaultIdentity), fullyQualifiedName: "azurerm.dataProtectionBackupVault.DataProtectionBackupVaultIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupVault.IDataProtectionBackupVaultIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_protection_backup_vault#type DataProtectionBackupVault#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_protection_backup_vault#identity_ids DataProtectionBackupVault#identity_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdentityIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
