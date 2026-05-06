using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementManagedDatabasesChangeDatabaseParameter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementManagedDatabasesChangeDatabaseParameter.DatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential")]
    public class DatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential : oci.DatabaseManagementManagedDatabasesChangeDatabaseParameter.IDatabaseManagementManagedDatabasesChangeDatabaseParameterDatabaseCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#credential_type DatabaseManagementManagedDatabasesChangeDatabaseParameter#credential_type}.</summary>
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#named_credential_id DatabaseManagementManagedDatabasesChangeDatabaseParameter#named_credential_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamedCredentialId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#password DatabaseManagementManagedDatabasesChangeDatabaseParameter#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#password_secret_id DatabaseManagementManagedDatabasesChangeDatabaseParameter#password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#role DatabaseManagementManagedDatabasesChangeDatabaseParameter#role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Role
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#username DatabaseManagementManagedDatabasesChangeDatabaseParameter#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
