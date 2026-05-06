using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementManagedDatabasesChangeDatabaseParameter
{
    [JsiiByValue(fqn: "oci.databaseManagementManagedDatabasesChangeDatabaseParameter.DatabaseManagementManagedDatabasesChangeDatabaseParameterCredentials")]
    public class DatabaseManagementManagedDatabasesChangeDatabaseParameterCredentials : oci.DatabaseManagementManagedDatabasesChangeDatabaseParameter.IDatabaseManagementManagedDatabasesChangeDatabaseParameterCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#password DatabaseManagementManagedDatabasesChangeDatabaseParameter#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#secret_id DatabaseManagementManagedDatabasesChangeDatabaseParameter#secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_managed_databases_change_database_parameter#user_name DatabaseManagementManagedDatabasesChangeDatabaseParameter#user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserName
        {
            get;
            set;
        }
    }
}
