using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OracleExascaleDatabaseStorageVault
{
    [JsiiInterface(nativeType: typeof(IOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage), fullyQualifiedName: "azurerm.oracleExascaleDatabaseStorageVault.OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage")]
    public interface IOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/oracle_exascale_database_storage_vault#total_size_in_gb OracleExascaleDatabaseStorageVault#total_size_in_gb}.</summary>
        [JsiiProperty(name: "totalSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double TotalSizeInGb
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage), fullyQualifiedName: "azurerm.oracleExascaleDatabaseStorageVault.OracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage")]
        internal sealed class _Proxy : DeputyBase, azurerm.OracleExascaleDatabaseStorageVault.IOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/oracle_exascale_database_storage_vault#total_size_in_gb OracleExascaleDatabaseStorageVault#total_size_in_gb}.</summary>
            [JsiiProperty(name: "totalSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double TotalSizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
