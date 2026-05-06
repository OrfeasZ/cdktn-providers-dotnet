using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetails")]
    public class DatabaseMigrationMigrationGgsDetails : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#acceptable_lag DatabaseMigrationMigration#acceptable_lag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceptableLag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AcceptableLag
        {
            get;
            set;
        }

        /// <summary>extract block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#extract DatabaseMigrationMigration#extract}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract? Extract
        {
            get;
            set;
        }

        /// <summary>replicat block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#replicat DatabaseMigrationMigration#replicat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicat", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsReplicat\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsReplicat? Replicat
        {
            get;
            set;
        }
    }
}
