using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts")]
    public class DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts : oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#create DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#delete DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#update DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
