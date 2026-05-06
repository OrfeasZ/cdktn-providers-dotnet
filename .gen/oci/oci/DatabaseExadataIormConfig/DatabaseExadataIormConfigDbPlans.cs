using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataIormConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseExadataIormConfig.DatabaseExadataIormConfigDbPlans")]
    public class DatabaseExadataIormConfigDbPlans : oci.DatabaseExadataIormConfig.IDatabaseExadataIormConfigDbPlans
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_iorm_config#db_name DatabaseExadataIormConfig#db_name}.</summary>
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public string DbName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_iorm_config#share DatabaseExadataIormConfig#share}.</summary>
        [JsiiProperty(name: "share", typeJson: "{\"primitive\":\"number\"}")]
        public double Share
        {
            get;
            set;
        }
    }
}
