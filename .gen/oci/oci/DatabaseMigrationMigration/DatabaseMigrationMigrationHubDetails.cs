using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetails")]
    public class DatabaseMigrationMigrationHubDetails : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#key_id DatabaseMigrationMigration#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyId
        {
            get;
            set;
        }

        /// <summary>rest_admin_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#rest_admin_credentials DatabaseMigrationMigration#rest_admin_credentials}
        /// </remarks>
        [JsiiProperty(name: "restAdminCredentials", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsRestAdminCredentials\"}")]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsRestAdminCredentials RestAdminCredentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#url DatabaseMigrationMigration#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#vault_id DatabaseMigrationMigration#vault_id}.</summary>
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string VaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#acceptable_lag DatabaseMigrationMigration#acceptable_lag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceptableLag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AcceptableLag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#compute_id DatabaseMigrationMigration#compute_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeId
        {
            get;
            set;
        }

        /// <summary>extract block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#extract DatabaseMigrationMigration#extract}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsExtract\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsExtract? Extract
        {
            get;
            set;
        }

        /// <summary>replicat block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#replicat DatabaseMigrationMigration#replicat}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicat", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicat\"}", isOptional: true)]
        public oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat? Replicat
        {
            get;
            set;
        }
    }
}
