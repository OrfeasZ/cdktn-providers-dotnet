using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails")]
    public interface IDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#provider_type DatabaseDatabase#provider_type}.</summary>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#hsm_password DatabaseDatabase#hsm_password}.</summary>
        [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HsmPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabase.IDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#provider_type DatabaseDatabase#provider_type}.</summary>
            [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_database#hsm_password DatabaseDatabase#hsm_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hsmPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HsmPassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
