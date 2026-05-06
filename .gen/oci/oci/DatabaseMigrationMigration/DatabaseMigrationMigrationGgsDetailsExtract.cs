using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract")]
    public class DatabaseMigrationMigrationGgsDetailsExtract : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#long_trans_duration DatabaseMigrationMigration#long_trans_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "longTransDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LongTransDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#performance_profile DatabaseMigrationMigration#performance_profile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "performanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PerformanceProfile
        {
            get;
            set;
        }
    }
}
