using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalMySqlDatabase
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalMySqlDatabase.DatabaseManagementExternalMySqlDatabaseTimeouts")]
    public class DatabaseManagementExternalMySqlDatabaseTimeouts : oci.DatabaseManagementExternalMySqlDatabase.IDatabaseManagementExternalMySqlDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database#create DatabaseManagementExternalMySqlDatabase#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database#delete DatabaseManagementExternalMySqlDatabase#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database#update DatabaseManagementExternalMySqlDatabase#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
