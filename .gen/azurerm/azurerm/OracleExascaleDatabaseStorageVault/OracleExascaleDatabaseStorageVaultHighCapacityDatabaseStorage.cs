using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleExascaleDatabaseStorageVault
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.oracleExascaleDatabaseStorageVault.OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage")]
    public class OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage : azurerm.OracleExascaleDatabaseStorageVault.IOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/oracle_exascale_database_storage_vault#total_size_in_gb OracleExascaleDatabaseStorageVault#total_size_in_gb}.</summary>
        [JsiiProperty(name: "totalSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double TotalSizeInGb
        {
            get;
            set;
        }
    }
}
