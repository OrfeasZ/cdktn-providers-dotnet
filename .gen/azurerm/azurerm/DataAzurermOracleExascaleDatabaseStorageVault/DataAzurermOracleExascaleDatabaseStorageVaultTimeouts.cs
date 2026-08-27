using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleExascaleDatabaseStorageVault
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultTimeouts")]
    public class DataAzurermOracleExascaleDatabaseStorageVaultTimeouts : azurerm.DataAzurermOracleExascaleDatabaseStorageVault.IDataAzurermOracleExascaleDatabaseStorageVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_exascale_database_storage_vault#read DataAzurermOracleExascaleDatabaseStorageVault#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
