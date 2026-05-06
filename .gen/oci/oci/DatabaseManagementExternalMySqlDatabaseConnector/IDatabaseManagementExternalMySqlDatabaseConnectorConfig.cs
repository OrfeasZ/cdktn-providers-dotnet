using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalMySqlDatabaseConnector
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalMySqlDatabaseConnectorConfig), fullyQualifiedName: "oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorConfig")]
    public interface IDatabaseManagementExternalMySqlDatabaseConnectorConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#compartment_id DatabaseManagementExternalMySqlDatabaseConnector#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>connector_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#connector_details DatabaseManagementExternalMySqlDatabaseConnector#connector_details}
        /// </remarks>
        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails\"}")]
        oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails ConnectorDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#is_test_connection_param DatabaseManagementExternalMySqlDatabaseConnector#is_test_connection_param}.</summary>
        [JsiiProperty(name: "isTestConnectionParam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsTestConnectionParam
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#check_connection_status_trigger DatabaseManagementExternalMySqlDatabaseConnector#check_connection_status_trigger}.</summary>
        [JsiiProperty(name: "checkConnectionStatusTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CheckConnectionStatusTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#id DatabaseManagementExternalMySqlDatabaseConnector#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#timeouts DatabaseManagementExternalMySqlDatabaseConnector#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalMySqlDatabaseConnectorConfig), fullyQualifiedName: "oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#compartment_id DatabaseManagementExternalMySqlDatabaseConnector#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>connector_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#connector_details DatabaseManagementExternalMySqlDatabaseConnector#connector_details}
            /// </remarks>
            [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails\"}")]
            public oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails ConnectorDetails
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorConnectorDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#is_test_connection_param DatabaseManagementExternalMySqlDatabaseConnector#is_test_connection_param}.</summary>
            [JsiiProperty(name: "isTestConnectionParam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsTestConnectionParam
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#check_connection_status_trigger DatabaseManagementExternalMySqlDatabaseConnector#check_connection_status_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "checkConnectionStatusTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CheckConnectionStatusTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#id DatabaseManagementExternalMySqlDatabaseConnector#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_my_sql_database_connector#timeouts DatabaseManagementExternalMySqlDatabaseConnector#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementExternalMySqlDatabaseConnector.DatabaseManagementExternalMySqlDatabaseConnectorTimeouts\"}", isOptional: true)]
            public oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalMySqlDatabaseConnector.IDatabaseManagementExternalMySqlDatabaseConnectorTimeouts?>();
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
