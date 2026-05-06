using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementManagedDatabasesChangeDatabaseParameter
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential), fullyQualifiedName: "oci.databaseManagementManagedDatabasesChangeDatabaseParameter.DatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential")]
    public interface IDatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#credential_type DatabaseManagementManagedDatabasesChangeDatabaseParameter#credential_type}.</summary>
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#named_credential_id DatabaseManagementManagedDatabasesChangeDatabaseParameter#named_credential_id}.</summary>
        [JsiiProperty(name: "namedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamedCredentialId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#password DatabaseManagementManagedDatabasesChangeDatabaseParameter#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#password_secret_id DatabaseManagementManagedDatabasesChangeDatabaseParameter#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#role DatabaseManagementManagedDatabasesChangeDatabaseParameter#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Role
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#username DatabaseManagementManagedDatabasesChangeDatabaseParameter#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential), fullyQualifiedName: "oci.databaseManagementManagedDatabasesChangeDatabaseParameter.DatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementManagedDatabasesChangeDatabaseParameter.IDatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#credential_type DatabaseManagementManagedDatabasesChangeDatabaseParameter#credential_type}.</summary>
            [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#named_credential_id DatabaseManagementManagedDatabasesChangeDatabaseParameter#named_credential_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamedCredentialId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#password DatabaseManagementManagedDatabasesChangeDatabaseParameter#password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#password_secret_id DatabaseManagementManagedDatabasesChangeDatabaseParameter#password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#role DatabaseManagementManagedDatabasesChangeDatabaseParameter#role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Role
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#username DatabaseManagementManagedDatabasesChangeDatabaseParameter#username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
