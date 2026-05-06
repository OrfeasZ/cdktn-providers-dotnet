using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationMigrationHubDetailsReplicat), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicat")]
    public interface IDatabaseMigrationMigrationHubDetailsReplicat
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#performance_profile DatabaseMigrationMigration#performance_profile}.</summary>
        [JsiiProperty(name: "performanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PerformanceProfile
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationMigrationHubDetailsReplicat), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicat")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#performance_profile DatabaseMigrationMigration#performance_profile}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "performanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PerformanceProfile
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
