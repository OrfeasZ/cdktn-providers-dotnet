using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationMigrationHubDetails), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetails")]
    public interface IDatabaseMigrationMigrationHubDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#key_id DatabaseMigrationMigration#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        /// <summary>rest_admin_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#rest_admin_credentials DatabaseMigrationMigration#rest_admin_credentials}
        /// </remarks>
        [JsiiProperty(name: "restAdminCredentials", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsRestAdminCredentials\"}")]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsRestAdminCredentials RestAdminCredentials
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#url DatabaseMigrationMigration#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#vault_id DatabaseMigrationMigration#vault_id}.</summary>
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        string VaultId
        {
            get;
        }

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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#compute_id DatabaseMigrationMigration#compute_id}.</summary>
        [JsiiProperty(name: "computeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeId
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
        [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsExtract\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsExtract? Extract
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
        [JsiiProperty(name: "replicat", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat? Replicat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationMigrationHubDetails), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#key_id DatabaseMigrationMigration#key_id}.</summary>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rest_admin_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#rest_admin_credentials DatabaseMigrationMigration#rest_admin_credentials}
            /// </remarks>
            [JsiiProperty(name: "restAdminCredentials", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsRestAdminCredentials\"}")]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsRestAdminCredentials RestAdminCredentials
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsRestAdminCredentials>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#url DatabaseMigrationMigration#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#vault_id DatabaseMigrationMigration#vault_id}.</summary>
            [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string VaultId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#acceptable_lag DatabaseMigrationMigration#acceptable_lag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceptableLag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AcceptableLag
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#compute_id DatabaseMigrationMigration#compute_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>extract block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#extract DatabaseMigrationMigration#extract}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsExtract\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsExtract? Extract
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsExtract?>();
            }

            /// <summary>replicat block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#replicat DatabaseMigrationMigration#replicat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicat", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicat\"}", isOptional: true)]
            public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat? Replicat
            {
                get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat?>();
            }
        }
    }
}
