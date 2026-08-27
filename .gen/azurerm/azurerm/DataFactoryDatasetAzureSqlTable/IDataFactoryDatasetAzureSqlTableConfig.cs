using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDatasetAzureSqlTable
{
    [JsiiInterface(nativeType: typeof(IDataFactoryDatasetAzureSqlTableConfig), fullyQualifiedName: "azurerm.dataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableConfig")]
    public interface IDataFactoryDatasetAzureSqlTableConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#data_factory_id DataFactoryDatasetAzureSqlTable#data_factory_id}.</summary>
        [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DataFactoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#linked_service_id DataFactoryDatasetAzureSqlTable#linked_service_id}.</summary>
        [JsiiProperty(name: "linkedServiceId", typeJson: "{\"primitive\":\"string\"}")]
        string LinkedServiceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#name DataFactoryDatasetAzureSqlTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#additional_properties DataFactoryDatasetAzureSqlTable#additional_properties}.</summary>
        [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdditionalProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#annotations DataFactoryDatasetAzureSqlTable#annotations}.</summary>
        [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Annotations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#description DataFactoryDatasetAzureSqlTable#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#folder DataFactoryDatasetAzureSqlTable#folder}.</summary>
        [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Folder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#id DataFactoryDatasetAzureSqlTable#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#parameters DataFactoryDatasetAzureSqlTable#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#schema DataFactoryDatasetAzureSqlTable#schema}.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Schema
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema_column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#schema_column DataFactoryDatasetAzureSqlTable#schema_column}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataFactoryDatasetAzureSqlTable.IDataFactoryDatasetAzureSqlTableSchemaColumn" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "schemaColumn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableSchemaColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SchemaColumn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#table DataFactoryDatasetAzureSqlTable#table}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#timeouts DataFactoryDatasetAzureSqlTable#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDatasetAzureSqlTable.IDataFactoryDatasetAzureSqlTableTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryDatasetAzureSqlTableConfig), fullyQualifiedName: "azurerm.dataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryDatasetAzureSqlTable.IDataFactoryDatasetAzureSqlTableConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#data_factory_id DataFactoryDatasetAzureSqlTable#data_factory_id}.</summary>
            [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataFactoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#linked_service_id DataFactoryDatasetAzureSqlTable#linked_service_id}.</summary>
            [JsiiProperty(name: "linkedServiceId", typeJson: "{\"primitive\":\"string\"}")]
            public string LinkedServiceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#name DataFactoryDatasetAzureSqlTable#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#additional_properties DataFactoryDatasetAzureSqlTable#additional_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdditionalProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#annotations DataFactoryDatasetAzureSqlTable#annotations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Annotations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#description DataFactoryDatasetAzureSqlTable#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#folder DataFactoryDatasetAzureSqlTable#folder}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Folder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#id DataFactoryDatasetAzureSqlTable#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#parameters DataFactoryDatasetAzureSqlTable#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#schema DataFactoryDatasetAzureSqlTable#schema}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Schema
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>schema_column block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#schema_column DataFactoryDatasetAzureSqlTable#schema_column}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataFactoryDatasetAzureSqlTable.IDataFactoryDatasetAzureSqlTableSchemaColumn" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemaColumn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableSchemaColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SchemaColumn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#table DataFactoryDatasetAzureSqlTable#table}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "table", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Table
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_dataset_azure_sql_table#timeouts DataFactoryDatasetAzureSqlTable#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableTimeouts\"}", isOptional: true)]
            public azurerm.DataFactoryDatasetAzureSqlTable.IDataFactoryDatasetAzureSqlTableTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DataFactoryDatasetAzureSqlTable.IDataFactoryDatasetAzureSqlTableTimeouts?>();
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
