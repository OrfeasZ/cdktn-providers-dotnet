using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabaseUpgrade
{
    [JsiiByValue(fqn: "oci.databaseDatabaseUpgrade.DatabaseDatabaseUpgradeDatabaseUpgradeSourceDetails")]
    public class DatabaseDatabaseUpgradeDatabaseUpgradeSourceDetails : oci.DatabaseDatabaseUpgrade.IDatabaseDatabaseUpgradeDatabaseUpgradeSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_upgrade#database_software_image_id DatabaseDatabaseUpgrade#database_software_image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseSoftwareImageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_upgrade#db_version DatabaseDatabaseUpgrade#db_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_upgrade#options DatabaseDatabaseUpgrade#options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Options
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_database_upgrade#source DatabaseDatabaseUpgrade#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }
    }
}
