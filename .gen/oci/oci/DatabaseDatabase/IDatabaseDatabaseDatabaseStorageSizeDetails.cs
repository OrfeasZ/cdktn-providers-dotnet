using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseDatabaseStorageSizeDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseStorageSizeDetails")]
    public interface IDatabaseDatabaseDatabaseStorageSizeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database#data_storage_size_in_gb DatabaseDatabase#data_storage_size_in_gb}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double DataStorageSizeInGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database#reco_storage_size_in_gbs DatabaseDatabase#reco_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "recoStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double RecoStorageSizeInGbs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseDatabaseStorageSizeDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseStorageSizeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabase.IDatabaseDatabaseDatabaseStorageSizeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database#data_storage_size_in_gb DatabaseDatabase#data_storage_size_in_gb}.</summary>
            [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double DataStorageSizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database#reco_storage_size_in_gbs DatabaseDatabase#reco_storage_size_in_gbs}.</summary>
            [JsiiProperty(name: "recoStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double RecoStorageSizeInGbs
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
