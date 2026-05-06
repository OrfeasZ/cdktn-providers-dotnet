using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationMigrationGgsDetails), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetails")]
    public interface IDatabaseMigrationMigrationGgsDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#acceptable_lag DatabaseMigrationMigration#acceptable_lag}.</summary>
        [JsiiProperty(name: "acceptableLag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AcceptableLag
        {
            get
            {
                return null;
            }
        }

        /// <summary>extract block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#extract DatabaseMigrationMigration#extract}
        /// </remarks>
        [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract? Extract
        {
            get
            {
                return null;
            }
        }

        /// <summary>replicat block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#replicat DatabaseMigrationMigration#replicat}
        /// </remarks>
        [JsiiProperty(name: "replicat", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsReplicat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsReplicat? Replicat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationMigrationGgsDetails), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#acceptable_lag DatabaseMigrationMigration#acceptable_lag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceptableLag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AcceptableLag
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>extract block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#extract DatabaseMigrationMigration#extract}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract? Extract
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract?>();
            }

            /// <summary>replicat block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#replicat DatabaseMigrationMigration#replicat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicat", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsReplicat\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsReplicat? Replicat
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsReplicat?>();
            }
        }
    }
}
