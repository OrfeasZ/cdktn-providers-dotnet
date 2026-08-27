using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DigitalTwinsTimeSeriesDatabaseConnection
{
    [JsiiInterface(nativeType: typeof(IDigitalTwinsTimeSeriesDatabaseConnectionConfig), fullyQualifiedName: "azurerm.digitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnectionConfig")]
    public interface IDigitalTwinsTimeSeriesDatabaseConnectionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#digital_twins_id DigitalTwinsTimeSeriesDatabaseConnection#digital_twins_id}.</summary>
        [JsiiProperty(name: "digitalTwinsId", typeJson: "{\"primitive\":\"string\"}")]
        string DigitalTwinsId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#eventhub_name DigitalTwinsTimeSeriesDatabaseConnection#eventhub_name}.</summary>
        [JsiiProperty(name: "eventhubName", typeJson: "{\"primitive\":\"string\"}")]
        string EventhubName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#eventhub_namespace_endpoint_uri DigitalTwinsTimeSeriesDatabaseConnection#eventhub_namespace_endpoint_uri}.</summary>
        [JsiiProperty(name: "eventhubNamespaceEndpointUri", typeJson: "{\"primitive\":\"string\"}")]
        string EventhubNamespaceEndpointUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#eventhub_namespace_id DigitalTwinsTimeSeriesDatabaseConnection#eventhub_namespace_id}.</summary>
        [JsiiProperty(name: "eventhubNamespaceId", typeJson: "{\"primitive\":\"string\"}")]
        string EventhubNamespaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#kusto_cluster_id DigitalTwinsTimeSeriesDatabaseConnection#kusto_cluster_id}.</summary>
        [JsiiProperty(name: "kustoClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string KustoClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#kusto_cluster_uri DigitalTwinsTimeSeriesDatabaseConnection#kusto_cluster_uri}.</summary>
        [JsiiProperty(name: "kustoClusterUri", typeJson: "{\"primitive\":\"string\"}")]
        string KustoClusterUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#kusto_database_name DigitalTwinsTimeSeriesDatabaseConnection#kusto_database_name}.</summary>
        [JsiiProperty(name: "kustoDatabaseName", typeJson: "{\"primitive\":\"string\"}")]
        string KustoDatabaseName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#name DigitalTwinsTimeSeriesDatabaseConnection#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#eventhub_consumer_group_name DigitalTwinsTimeSeriesDatabaseConnection#eventhub_consumer_group_name}.</summary>
        [JsiiProperty(name: "eventhubConsumerGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventhubConsumerGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#id DigitalTwinsTimeSeriesDatabaseConnection#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#kusto_table_name DigitalTwinsTimeSeriesDatabaseConnection#kusto_table_name}.</summary>
        [JsiiProperty(name: "kustoTableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KustoTableName
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#timeouts DigitalTwinsTimeSeriesDatabaseConnection#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.digitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnectionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DigitalTwinsTimeSeriesDatabaseConnection.IDigitalTwinsTimeSeriesDatabaseConnectionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDigitalTwinsTimeSeriesDatabaseConnectionConfig), fullyQualifiedName: "azurerm.digitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnectionConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DigitalTwinsTimeSeriesDatabaseConnection.IDigitalTwinsTimeSeriesDatabaseConnectionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#digital_twins_id DigitalTwinsTimeSeriesDatabaseConnection#digital_twins_id}.</summary>
            [JsiiProperty(name: "digitalTwinsId", typeJson: "{\"primitive\":\"string\"}")]
            public string DigitalTwinsId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#eventhub_name DigitalTwinsTimeSeriesDatabaseConnection#eventhub_name}.</summary>
            [JsiiProperty(name: "eventhubName", typeJson: "{\"primitive\":\"string\"}")]
            public string EventhubName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#eventhub_namespace_endpoint_uri DigitalTwinsTimeSeriesDatabaseConnection#eventhub_namespace_endpoint_uri}.</summary>
            [JsiiProperty(name: "eventhubNamespaceEndpointUri", typeJson: "{\"primitive\":\"string\"}")]
            public string EventhubNamespaceEndpointUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#eventhub_namespace_id DigitalTwinsTimeSeriesDatabaseConnection#eventhub_namespace_id}.</summary>
            [JsiiProperty(name: "eventhubNamespaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string EventhubNamespaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#kusto_cluster_id DigitalTwinsTimeSeriesDatabaseConnection#kusto_cluster_id}.</summary>
            [JsiiProperty(name: "kustoClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string KustoClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#kusto_cluster_uri DigitalTwinsTimeSeriesDatabaseConnection#kusto_cluster_uri}.</summary>
            [JsiiProperty(name: "kustoClusterUri", typeJson: "{\"primitive\":\"string\"}")]
            public string KustoClusterUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#kusto_database_name DigitalTwinsTimeSeriesDatabaseConnection#kusto_database_name}.</summary>
            [JsiiProperty(name: "kustoDatabaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string KustoDatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#name DigitalTwinsTimeSeriesDatabaseConnection#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#eventhub_consumer_group_name DigitalTwinsTimeSeriesDatabaseConnection#eventhub_consumer_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventhubConsumerGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventhubConsumerGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#id DigitalTwinsTimeSeriesDatabaseConnection#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#kusto_table_name DigitalTwinsTimeSeriesDatabaseConnection#kusto_table_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kustoTableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KustoTableName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/digital_twins_time_series_database_connection#timeouts DigitalTwinsTimeSeriesDatabaseConnection#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.digitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnectionTimeouts\"}", isOptional: true)]
            public azurerm.DigitalTwinsTimeSeriesDatabaseConnection.IDigitalTwinsTimeSeriesDatabaseConnectionTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DigitalTwinsTimeSeriesDatabaseConnection.IDigitalTwinsTimeSeriesDatabaseConnectionTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
