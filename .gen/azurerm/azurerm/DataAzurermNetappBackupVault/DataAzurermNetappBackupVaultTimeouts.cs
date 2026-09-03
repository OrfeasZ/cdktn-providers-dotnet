using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappBackupVault
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappBackupVault.DataAzurermNetappBackupVaultTimeouts")]
    public class DataAzurermNetappBackupVaultTimeouts : azurerm.DataAzurermNetappBackupVault.IDataAzurermNetappBackupVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/netapp_backup_vault#read DataAzurermNetappBackupVault#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
