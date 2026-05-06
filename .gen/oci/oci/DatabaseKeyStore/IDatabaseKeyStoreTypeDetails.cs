using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseKeyStore
{
    [JsiiInterface(nativeType: typeof(IDatabaseKeyStoreTypeDetails), fullyQualifiedName: "oci.databaseKeyStore.DatabaseKeyStoreTypeDetails")]
    public interface IDatabaseKeyStoreTypeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#admin_username DatabaseKeyStore#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        string AdminUsername
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#connection_ips DatabaseKeyStore#connection_ips}.</summary>
        [JsiiProperty(name: "connectionIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ConnectionIps
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#secret_id DatabaseKeyStore#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#type DatabaseKeyStore#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#vault_id DatabaseKeyStore#vault_id}.</summary>
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        string VaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseKeyStoreTypeDetails), fullyQualifiedName: "oci.databaseKeyStore.DatabaseKeyStoreTypeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseKeyStore.IDatabaseKeyStoreTypeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#admin_username DatabaseKeyStore#admin_username}.</summary>
            [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminUsername
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#connection_ips DatabaseKeyStore#connection_ips}.</summary>
            [JsiiProperty(name: "connectionIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ConnectionIps
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#secret_id DatabaseKeyStore#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#type DatabaseKeyStore#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_key_store#vault_id DatabaseKeyStore#vault_id}.</summary>
            [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string VaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
