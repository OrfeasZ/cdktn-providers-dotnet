using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationMigrationGgsDetailsExtract), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract")]
    public interface IDatabaseMigrationMigrationGgsDetailsExtract
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#long_trans_duration DatabaseMigrationMigration#long_trans_duration}.</summary>
        [JsiiProperty(name: "longTransDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LongTransDuration
        {
            get
            {
                return null;
            }
        }

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

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationMigrationGgsDetailsExtract), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#long_trans_duration DatabaseMigrationMigration#long_trans_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "longTransDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LongTransDuration
            {
                get => GetInstanceProperty<double?>();
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
