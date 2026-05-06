using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExternalNonContainerDatabaseOperationsInsightsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseExternalNonContainerDatabaseOperationsInsightsManagementConfig), fullyQualifiedName: "oci.databaseExternalNonContainerDatabaseOperationsInsightsManagement.DatabaseExternalNonContainerDatabaseOperationsInsightsManagementConfig")]
    public interface IDatabaseExternalNonContainerDatabaseOperationsInsightsManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#enable_operations_insights DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#enable_operations_insights}.</summary>
        [JsiiProperty(name: "enableOperationsInsights", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableOperationsInsights
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#external_database_connector_id DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#external_database_connector_id}.</summary>
        [JsiiProperty(name: "externalDatabaseConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalDatabaseConnectorId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#external_non_container_database_id DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#external_non_container_database_id}.</summary>
        [JsiiProperty(name: "externalNonContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalNonContainerDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#id DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#timeouts DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseExternalNonContainerDatabaseOperationsInsightsManagement.DatabaseExternalNonContainerDatabaseOperationsInsightsManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseExternalNonContainerDatabaseOperationsInsightsManagement.IDatabaseExternalNonContainerDatabaseOperationsInsightsManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExternalNonContainerDatabaseOperationsInsightsManagementConfig), fullyQualifiedName: "oci.databaseExternalNonContainerDatabaseOperationsInsightsManagement.DatabaseExternalNonContainerDatabaseOperationsInsightsManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExternalNonContainerDatabaseOperationsInsightsManagement.IDatabaseExternalNonContainerDatabaseOperationsInsightsManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#enable_operations_insights DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#enable_operations_insights}.</summary>
            [JsiiProperty(name: "enableOperationsInsights", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableOperationsInsights
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#external_database_connector_id DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#external_database_connector_id}.</summary>
            [JsiiProperty(name: "externalDatabaseConnectorId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalDatabaseConnectorId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#external_non_container_database_id DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#external_non_container_database_id}.</summary>
            [JsiiProperty(name: "externalNonContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalNonContainerDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#id DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_non_container_database_operations_insights_management#timeouts DatabaseExternalNonContainerDatabaseOperationsInsightsManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseExternalNonContainerDatabaseOperationsInsightsManagement.DatabaseExternalNonContainerDatabaseOperationsInsightsManagementTimeouts\"}", isOptional: true)]
            public oci.DatabaseExternalNonContainerDatabaseOperationsInsightsManagement.IDatabaseExternalNonContainerDatabaseOperationsInsightsManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseExternalNonContainerDatabaseOperationsInsightsManagement.IDatabaseExternalNonContainerDatabaseOperationsInsightsManagementTimeouts?>();
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
