using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemDiscovery
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials), fullyQualifiedName: "oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials")]
    public interface IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#credential_type DatabaseManagementExternalDbSystemDiscovery#credential_type}.</summary>
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#credential_name DatabaseManagementExternalDbSystemDiscovery#credential_name}.</summary>
        [JsiiProperty(name: "credentialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#password_secret_id DatabaseManagementExternalDbSystemDiscovery#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#role DatabaseManagementExternalDbSystemDiscovery#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Role
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#ssl_secret_id DatabaseManagementExternalDbSystemDiscovery#ssl_secret_id}.</summary>
        [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#user_name DatabaseManagementExternalDbSystemDiscovery#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials), fullyQualifiedName: "oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnectorConnectionInfoConnectionCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#credential_type DatabaseManagementExternalDbSystemDiscovery#credential_type}.</summary>
            [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#credential_name DatabaseManagementExternalDbSystemDiscovery#credential_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#password_secret_id DatabaseManagementExternalDbSystemDiscovery#password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#role DatabaseManagementExternalDbSystemDiscovery#role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Role
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#ssl_secret_id DatabaseManagementExternalDbSystemDiscovery#ssl_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#user_name DatabaseManagementExternalDbSystemDiscovery#user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
