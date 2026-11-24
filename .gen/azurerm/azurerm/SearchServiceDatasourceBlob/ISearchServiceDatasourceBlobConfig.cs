using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SearchServiceDatasourceBlob
{
    [JsiiInterface(nativeType: typeof(ISearchServiceDatasourceBlobConfig), fullyQualifiedName: "azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobConfig")]
    public interface ISearchServiceDatasourceBlobConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#connection_string_wo SearchServiceDatasourceBlob#connection_string_wo}.</summary>
        [JsiiProperty(name: "connectionStringWo", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionStringWo
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#connection_string_wo_version SearchServiceDatasourceBlob#connection_string_wo_version}.</summary>
        [JsiiProperty(name: "connectionStringWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        double ConnectionStringWoVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#container_name SearchServiceDatasourceBlob#container_name}.</summary>
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#name SearchServiceDatasourceBlob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#search_service_endpoint SearchServiceDatasourceBlob#search_service_endpoint}.</summary>
        [JsiiProperty(name: "searchServiceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string SearchServiceEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#container_query SearchServiceDatasourceBlob#container_query}.</summary>
        [JsiiProperty(name: "containerQuery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerQuery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#description SearchServiceDatasourceBlob#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#encryption_key SearchServiceDatasourceBlob#encryption_key}
        /// </remarks>
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobEncryptionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobEncryptionKey? EncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#id SearchServiceDatasourceBlob#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#soft_delete_column_name SearchServiceDatasourceBlob#soft_delete_column_name}.</summary>
        [JsiiProperty(name: "softDeleteColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SoftDeleteColumnName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#soft_delete_marker_value SearchServiceDatasourceBlob#soft_delete_marker_value}.</summary>
        [JsiiProperty(name: "softDeleteMarkerValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SoftDeleteMarkerValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#timeouts SearchServiceDatasourceBlob#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISearchServiceDatasourceBlobConfig), fullyQualifiedName: "azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#connection_string_wo SearchServiceDatasourceBlob#connection_string_wo}.</summary>
            [JsiiProperty(name: "connectionStringWo", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionStringWo
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#connection_string_wo_version SearchServiceDatasourceBlob#connection_string_wo_version}.</summary>
            [JsiiProperty(name: "connectionStringWoVersion", typeJson: "{\"primitive\":\"number\"}")]
            public double ConnectionStringWoVersion
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#container_name SearchServiceDatasourceBlob#container_name}.</summary>
            [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#name SearchServiceDatasourceBlob#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#search_service_endpoint SearchServiceDatasourceBlob#search_service_endpoint}.</summary>
            [JsiiProperty(name: "searchServiceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string SearchServiceEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#container_query SearchServiceDatasourceBlob#container_query}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerQuery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerQuery
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#description SearchServiceDatasourceBlob#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#encryption_key SearchServiceDatasourceBlob#encryption_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobEncryptionKey\"}", isOptional: true)]
            public azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobEncryptionKey? EncryptionKey
            {
                get => GetInstanceProperty<azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobEncryptionKey?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#id SearchServiceDatasourceBlob#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#soft_delete_column_name SearchServiceDatasourceBlob#soft_delete_column_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "softDeleteColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SoftDeleteColumnName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#soft_delete_marker_value SearchServiceDatasourceBlob#soft_delete_marker_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "softDeleteMarkerValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SoftDeleteMarkerValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#timeouts SearchServiceDatasourceBlob#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobTimeouts\"}", isOptional: true)]
            public azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobTimeouts?>();
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
