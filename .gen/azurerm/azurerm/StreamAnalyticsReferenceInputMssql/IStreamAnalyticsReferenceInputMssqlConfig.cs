using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StreamAnalyticsReferenceInputMssql
{
    [JsiiInterface(nativeType: typeof(IStreamAnalyticsReferenceInputMssqlConfig), fullyQualifiedName: "azurerm.streamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssqlConfig")]
    public interface IStreamAnalyticsReferenceInputMssqlConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#database StreamAnalyticsReferenceInputMssql#database}.</summary>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        string Database
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#full_snapshot_query StreamAnalyticsReferenceInputMssql#full_snapshot_query}.</summary>
        [JsiiProperty(name: "fullSnapshotQuery", typeJson: "{\"primitive\":\"string\"}")]
        string FullSnapshotQuery
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#name StreamAnalyticsReferenceInputMssql#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#password StreamAnalyticsReferenceInputMssql#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#refresh_type StreamAnalyticsReferenceInputMssql#refresh_type}.</summary>
        [JsiiProperty(name: "refreshType", typeJson: "{\"primitive\":\"string\"}")]
        string RefreshType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#resource_group_name StreamAnalyticsReferenceInputMssql#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#server StreamAnalyticsReferenceInputMssql#server}.</summary>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        string Server
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#stream_analytics_job_name StreamAnalyticsReferenceInputMssql#stream_analytics_job_name}.</summary>
        [JsiiProperty(name: "streamAnalyticsJobName", typeJson: "{\"primitive\":\"string\"}")]
        string StreamAnalyticsJobName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#username StreamAnalyticsReferenceInputMssql#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#delta_snapshot_query StreamAnalyticsReferenceInputMssql#delta_snapshot_query}.</summary>
        [JsiiProperty(name: "deltaSnapshotQuery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeltaSnapshotQuery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#id StreamAnalyticsReferenceInputMssql#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#refresh_interval_duration StreamAnalyticsReferenceInputMssql#refresh_interval_duration}.</summary>
        [JsiiProperty(name: "refreshIntervalDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefreshIntervalDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#table StreamAnalyticsReferenceInputMssql#table}.</summary>
        [JsiiProperty(name: "table", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Table
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#timeouts StreamAnalyticsReferenceInputMssql#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssqlTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StreamAnalyticsReferenceInputMssql.IStreamAnalyticsReferenceInputMssqlTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamAnalyticsReferenceInputMssqlConfig), fullyQualifiedName: "azurerm.streamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssqlConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.StreamAnalyticsReferenceInputMssql.IStreamAnalyticsReferenceInputMssqlConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#database StreamAnalyticsReferenceInputMssql#database}.</summary>
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
            public string Database
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#full_snapshot_query StreamAnalyticsReferenceInputMssql#full_snapshot_query}.</summary>
            [JsiiProperty(name: "fullSnapshotQuery", typeJson: "{\"primitive\":\"string\"}")]
            public string FullSnapshotQuery
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#name StreamAnalyticsReferenceInputMssql#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#password StreamAnalyticsReferenceInputMssql#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#refresh_type StreamAnalyticsReferenceInputMssql#refresh_type}.</summary>
            [JsiiProperty(name: "refreshType", typeJson: "{\"primitive\":\"string\"}")]
            public string RefreshType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#resource_group_name StreamAnalyticsReferenceInputMssql#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#server StreamAnalyticsReferenceInputMssql#server}.</summary>
            [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
            public string Server
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#stream_analytics_job_name StreamAnalyticsReferenceInputMssql#stream_analytics_job_name}.</summary>
            [JsiiProperty(name: "streamAnalyticsJobName", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamAnalyticsJobName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#username StreamAnalyticsReferenceInputMssql#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#delta_snapshot_query StreamAnalyticsReferenceInputMssql#delta_snapshot_query}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deltaSnapshotQuery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeltaSnapshotQuery
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#id StreamAnalyticsReferenceInputMssql#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#refresh_interval_duration StreamAnalyticsReferenceInputMssql#refresh_interval_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshIntervalDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshIntervalDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#table StreamAnalyticsReferenceInputMssql#table}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "table", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Table
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_reference_input_mssql#timeouts StreamAnalyticsReferenceInputMssql#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsReferenceInputMssql.StreamAnalyticsReferenceInputMssqlTimeouts\"}", isOptional: true)]
            public azurerm.StreamAnalyticsReferenceInputMssql.IStreamAnalyticsReferenceInputMssqlTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.StreamAnalyticsReferenceInputMssql.IStreamAnalyticsReferenceInputMssqlTimeouts?>();
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
