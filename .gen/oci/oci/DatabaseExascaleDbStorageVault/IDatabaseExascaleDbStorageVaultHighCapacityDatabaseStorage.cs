using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExascaleDbStorageVault
{
    [JsiiInterface(nativeType: typeof(IDatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage), fullyQualifiedName: "oci.databaseExascaleDbStorageVault.DatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage")]
    public interface IDatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exascale_db_storage_vault#total_size_in_gbs DatabaseExascaleDbStorageVault#total_size_in_gbs}.</summary>
        [JsiiProperty(name: "totalSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double TotalSizeInGbs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage), fullyQualifiedName: "oci.databaseExascaleDbStorageVault.DatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExascaleDbStorageVault.IDatabaseExascaleDbStorageVaultHighCapacityDatabaseStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exascale_db_storage_vault#total_size_in_gbs DatabaseExascaleDbStorageVault#total_size_in_gbs}.</summary>
            [JsiiProperty(name: "totalSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double TotalSizeInGbs
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
