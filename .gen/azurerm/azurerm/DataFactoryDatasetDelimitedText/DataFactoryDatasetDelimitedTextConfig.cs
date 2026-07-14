using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDatasetDelimitedText
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextConfig")]
    public class DataFactoryDatasetDelimitedTextConfig : azurerm.DataFactoryDatasetDelimitedText.IDataFactoryDatasetDelimitedTextConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#data_factory_id DataFactoryDatasetDelimitedText#data_factory_id}.</summary>
        [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
        public string DataFactoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#linked_service_name DataFactoryDatasetDelimitedText#linked_service_name}.</summary>
        [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public string LinkedServiceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#name DataFactoryDatasetDelimitedText#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#additional_properties DataFactoryDatasetDelimitedText#additional_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? AdditionalProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#annotations DataFactoryDatasetDelimitedText#annotations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Annotations
        {
            get;
            set;
        }

        /// <summary>azure_blob_fs_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#azure_blob_fs_location DataFactoryDatasetDelimitedText#azure_blob_fs_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobFsLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextAzureBlobFsLocation\"}", isOptional: true)]
        public azurerm.DataFactoryDatasetDelimitedText.IDataFactoryDatasetDelimitedTextAzureBlobFsLocation? AzureBlobFsLocation
        {
            get;
            set;
        }

        /// <summary>azure_blob_storage_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#azure_blob_storage_location DataFactoryDatasetDelimitedText#azure_blob_storage_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorageLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextAzureBlobStorageLocation\"}", isOptional: true)]
        public azurerm.DataFactoryDatasetDelimitedText.IDataFactoryDatasetDelimitedTextAzureBlobStorageLocation? AzureBlobStorageLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#column_delimiter DataFactoryDatasetDelimitedText#column_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columnDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColumnDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#compression_codec DataFactoryDatasetDelimitedText#compression_codec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionCodec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionCodec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#compression_level DataFactoryDatasetDelimitedText#compression_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#description DataFactoryDatasetDelimitedText#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#encoding DataFactoryDatasetDelimitedText#encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Encoding
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#escape_character DataFactoryDatasetDelimitedText#escape_character}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "escapeCharacter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EscapeCharacter
        {
            get;
            set;
        }

        private object? _firstRowAsHeader;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#first_row_as_header DataFactoryDatasetDelimitedText#first_row_as_header}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstRowAsHeader", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FirstRowAsHeader
        {
            get => _firstRowAsHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _firstRowAsHeader = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#folder DataFactoryDatasetDelimitedText#folder}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Folder
        {
            get;
            set;
        }

        /// <summary>http_server_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#http_server_location DataFactoryDatasetDelimitedText#http_server_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpServerLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextHttpServerLocation\"}", isOptional: true)]
        public azurerm.DataFactoryDatasetDelimitedText.IDataFactoryDatasetDelimitedTextHttpServerLocation? HttpServerLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#id DataFactoryDatasetDelimitedText#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#null_value DataFactoryDatasetDelimitedText#null_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nullValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NullValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#parameters DataFactoryDatasetDelimitedText#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#quote_character DataFactoryDatasetDelimitedText#quote_character}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "quoteCharacter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QuoteCharacter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#row_delimiter DataFactoryDatasetDelimitedText#row_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rowDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RowDelimiter
        {
            get;
            set;
        }

        private object? _schemaColumn;

        /// <summary>schema_column block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#schema_column DataFactoryDatasetDelimitedText#schema_column}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataFactoryDatasetDelimitedText.IDataFactoryDatasetDelimitedTextSchemaColumn" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemaColumn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextSchemaColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SchemaColumn
        {
            get => _schemaColumn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.DataFactoryDatasetDelimitedText.IDataFactoryDatasetDelimitedTextSchemaColumn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DataFactoryDatasetDelimitedText.IDataFactoryDatasetDelimitedTextSchemaColumn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schemaColumn = value;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_delimited_text#timeouts DataFactoryDatasetDelimitedText#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextTimeouts\"}", isOptional: true)]
        public azurerm.DataFactoryDatasetDelimitedText.IDataFactoryDatasetDelimitedTextTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
