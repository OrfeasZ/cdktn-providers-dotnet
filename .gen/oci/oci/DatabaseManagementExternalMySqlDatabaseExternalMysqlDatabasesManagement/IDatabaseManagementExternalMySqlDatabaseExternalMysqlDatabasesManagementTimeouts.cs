using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts), fullyQualifiedName: "oci.databaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts")]
    public interface IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#create DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#delete DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#update DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts), fullyQualifiedName: "oci.databaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#create DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#delete DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#update DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
