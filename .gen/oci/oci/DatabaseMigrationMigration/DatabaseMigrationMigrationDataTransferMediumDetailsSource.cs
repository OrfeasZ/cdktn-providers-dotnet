using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSource")]
    public class DatabaseMigrationMigrationDataTransferMediumDetailsSource : oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#kind DatabaseMigrationMigration#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#oci_home DatabaseMigrationMigration#oci_home}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ociHome", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OciHome
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#wallet_location DatabaseMigrationMigration#wallet_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "walletLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WalletLocation
        {
            get;
            set;
        }
    }
}
