using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicat")]
    public class DatabaseMigrationMigrationHubDetailsReplicat : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat
    {
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
