using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExascaleDbStorageVault
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseExascaleDbStorageVault.DatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage")]
    public class DatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage : oci.DatabaseExascaleDbStorageVault.IDatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exascale_db_storage_vault#total_size_in_gbs DatabaseExascaleDbStorageVault#total_size_in_gbs}.</summary>
        [JsiiProperty(name: "totalSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double TotalSizeInGbs
        {
            get;
            set;
        }
    }
}
