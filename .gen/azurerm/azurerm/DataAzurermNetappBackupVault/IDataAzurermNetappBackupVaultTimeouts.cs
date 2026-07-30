using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappBackupVault
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappBackupVaultTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappBackupVault.DataAzurermNetappBackupVaultTimeouts")]
    public interface IDataAzurermNetappBackupVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/netapp_backup_vault#read DataAzurermNetappBackupVault#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappBackupVaultTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappBackupVault.DataAzurermNetappBackupVaultTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappBackupVault.IDataAzurermNetappBackupVaultTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/netapp_backup_vault#read DataAzurermNetappBackupVault#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
