using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    [JsiiInterface(nativeType: typeof(IDatabaseDbHomeDatabaseStorageSizeDetails), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseStorageSizeDetails")]
    public interface IDatabaseDbHomeDatabaseStorageSizeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#data_storage_size_in_gb DatabaseDbHome#data_storage_size_in_gb}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double DataStorageSizeInGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#reco_storage_size_in_gbs DatabaseDbHome#reco_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "recoStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double RecoStorageSizeInGbs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDbHomeDatabaseStorageSizeDetails), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseStorageSizeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDbHome.IDatabaseDbHomeDatabaseStorageSizeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#data_storage_size_in_gb DatabaseDbHome#data_storage_size_in_gb}.</summary>
            [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double DataStorageSizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#reco_storage_size_in_gbs DatabaseDbHome#reco_storage_size_in_gbs}.</summary>
            [JsiiProperty(name: "recoStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double RecoStorageSizeInGbs
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
