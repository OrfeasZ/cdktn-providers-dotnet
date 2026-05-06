using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseDbHome.DatabaseDbHomeDatabaseStorageSizeDetails")]
    public class DatabaseDbHomeDatabaseStorageSizeDetails : oci.DatabaseDbHome.IDatabaseDbHomeDatabaseStorageSizeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#data_storage_size_in_gb DatabaseDbHome#data_storage_size_in_gb}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double DataStorageSizeInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#reco_storage_size_in_gbs DatabaseDbHome#reco_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "recoStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double RecoStorageSizeInGbs
        {
            get;
            set;
        }
    }
}
