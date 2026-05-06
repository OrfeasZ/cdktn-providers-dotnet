using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementConfig), fullyQualifiedName: "oci.databaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementConfig")]
    public interface IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#enable_external_mysql_database DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#enable_external_mysql_database}.</summary>
        [JsiiProperty(name: "enableExternalMysqlDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableExternalMysqlDatabase
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#external_my_sql_database_id DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#external_my_sql_database_id}.</summary>
        [JsiiProperty(name: "externalMySqlDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalMySqlDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#connector_id DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#connector_id}.</summary>
        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#id DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#timeouts DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementConfig), fullyQualifiedName: "oci.databaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#enable_external_mysql_database DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#enable_external_mysql_database}.</summary>
            [JsiiProperty(name: "enableExternalMysqlDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableExternalMysqlDatabase
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#external_my_sql_database_id DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#external_my_sql_database_id}.</summary>
            [JsiiProperty(name: "externalMySqlDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalMySqlDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#connector_id DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#connector_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#id DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_external_mysql_databases_management#timeouts DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts\"}", isOptional: true)]
            public oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagement.IDatabaseManagementExternalMySqlDatabaseExternalMysqlDatabasesManagementTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
