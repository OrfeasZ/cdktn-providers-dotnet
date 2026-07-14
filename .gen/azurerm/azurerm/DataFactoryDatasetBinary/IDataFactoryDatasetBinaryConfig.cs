using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDatasetBinary
{
    [JsiiInterface(nativeType: typeof(IDataFactoryDatasetBinaryConfig), fullyQualifiedName: "azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryConfig")]
    public interface IDataFactoryDatasetBinaryConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#data_factory_id DataFactoryDatasetBinary#data_factory_id}.</summary>
        [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DataFactoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#linked_service_name DataFactoryDatasetBinary#linked_service_name}.</summary>
        [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
        string LinkedServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#name DataFactoryDatasetBinary#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#additional_properties DataFactoryDatasetBinary#additional_properties}.</summary>
        [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdditionalProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#annotations DataFactoryDatasetBinary#annotations}.</summary>
        [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Annotations
        {
            get
            {
                return null;
            }
        }

        /// <summary>azure_blob_storage_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#azure_blob_storage_location DataFactoryDatasetBinary#azure_blob_storage_location}
        /// </remarks>
        [JsiiProperty(name: "azureBlobStorageLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryAzureBlobStorageLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryAzureBlobStorageLocation? AzureBlobStorageLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>compression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#compression DataFactoryDatasetBinary#compression}
        /// </remarks>
        [JsiiProperty(name: "compression", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryCompression\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryCompression? Compression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#description DataFactoryDatasetBinary#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#folder DataFactoryDatasetBinary#folder}.</summary>
        [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Folder
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_server_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#http_server_location DataFactoryDatasetBinary#http_server_location}
        /// </remarks>
        [JsiiProperty(name: "httpServerLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryHttpServerLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryHttpServerLocation? HttpServerLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#id DataFactoryDatasetBinary#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#parameters DataFactoryDatasetBinary#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>sftp_server_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#sftp_server_location DataFactoryDatasetBinary#sftp_server_location}
        /// </remarks>
        [JsiiProperty(name: "sftpServerLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinarySftpServerLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinarySftpServerLocation? SftpServerLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#timeouts DataFactoryDatasetBinary#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryDatasetBinaryConfig), fullyQualifiedName: "azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#data_factory_id DataFactoryDatasetBinary#data_factory_id}.</summary>
            [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataFactoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#linked_service_name DataFactoryDatasetBinary#linked_service_name}.</summary>
            [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
            public string LinkedServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#name DataFactoryDatasetBinary#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#additional_properties DataFactoryDatasetBinary#additional_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdditionalProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#annotations DataFactoryDatasetBinary#annotations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Annotations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>azure_blob_storage_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#azure_blob_storage_location DataFactoryDatasetBinary#azure_blob_storage_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureBlobStorageLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryAzureBlobStorageLocation\"}", isOptional: true)]
            public azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryAzureBlobStorageLocation? AzureBlobStorageLocation
            {
                get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryAzureBlobStorageLocation?>();
            }

            /// <summary>compression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#compression DataFactoryDatasetBinary#compression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compression", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryCompression\"}", isOptional: true)]
            public azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryCompression? Compression
            {
                get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryCompression?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#description DataFactoryDatasetBinary#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#folder DataFactoryDatasetBinary#folder}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Folder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>http_server_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#http_server_location DataFactoryDatasetBinary#http_server_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpServerLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryHttpServerLocation\"}", isOptional: true)]
            public azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryHttpServerLocation? HttpServerLocation
            {
                get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryHttpServerLocation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#id DataFactoryDatasetBinary#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#parameters DataFactoryDatasetBinary#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>sftp_server_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#sftp_server_location DataFactoryDatasetBinary#sftp_server_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sftpServerLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinarySftpServerLocation\"}", isOptional: true)]
            public azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinarySftpServerLocation? SftpServerLocation
            {
                get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinarySftpServerLocation?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_dataset_binary#timeouts DataFactoryDatasetBinary#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryTimeouts\"}", isOptional: true)]
            public azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryTimeouts?>();
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
