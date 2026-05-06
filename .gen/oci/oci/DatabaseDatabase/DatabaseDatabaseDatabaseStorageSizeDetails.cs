using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseDatabase.DatabaseDatabaseDatabaseStorageSizeDetails")]
    public class DatabaseDatabaseDatabaseStorageSizeDetails : oci.DatabaseDatabase.IDatabaseDatabaseDatabaseStorageSizeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database#data_storage_size_in_gb DatabaseDatabase#data_storage_size_in_gb}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double DataStorageSizeInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database#reco_storage_size_in_gbs DatabaseDatabase#reco_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "recoStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double RecoStorageSizeInGbs
        {
            get;
            set;
        }
    }
}
