using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiInterface(nativeType: typeof(IDatabaseMigrationMigrationDataTransferMediumDetailsTarget), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTarget")]
    public interface IDatabaseMigrationMigrationDataTransferMediumDetailsTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#kind DatabaseMigrationMigration#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#oci_home DatabaseMigrationMigration#oci_home}.</summary>
        [JsiiProperty(name: "ociHome", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OciHome
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#wallet_location DatabaseMigrationMigration#wallet_location}.</summary>
        [JsiiProperty(name: "walletLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WalletLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseMigrationMigrationDataTransferMediumDetailsTarget), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsTarget")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#kind DatabaseMigrationMigration#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#oci_home DatabaseMigrationMigration#oci_home}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ociHome", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OciHome
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_migration_migration#wallet_location DatabaseMigrationMigration#wallet_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "walletLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WalletLocation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
