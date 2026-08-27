using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceAzureBlobStorage
{
    [JsiiInterface(nativeType: typeof(IDataFactoryLinkedServiceAzureBlobStorageConfig), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageConfig")]
    public interface IDataFactoryLinkedServiceAzureBlobStorageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#data_factory_id DataFactoryLinkedServiceAzureBlobStorage#data_factory_id}.</summary>
        [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DataFactoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#name DataFactoryLinkedServiceAzureBlobStorage#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#additional_properties DataFactoryLinkedServiceAzureBlobStorage#additional_properties}.</summary>
        [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdditionalProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#annotations DataFactoryLinkedServiceAzureBlobStorage#annotations}.</summary>
        [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Annotations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#connection_string DataFactoryLinkedServiceAzureBlobStorage#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#connection_string_insecure DataFactoryLinkedServiceAzureBlobStorage#connection_string_insecure}.</summary>
        [JsiiProperty(name: "connectionStringInsecure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionStringInsecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#description DataFactoryLinkedServiceAzureBlobStorage#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#id DataFactoryLinkedServiceAzureBlobStorage#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#integration_runtime_name DataFactoryLinkedServiceAzureBlobStorage#integration_runtime_name}.</summary>
        [JsiiProperty(name: "integrationRuntimeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntegrationRuntimeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#parameters DataFactoryLinkedServiceAzureBlobStorage#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>sas_token_linked_key_vault_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#sas_token_linked_key_vault_key DataFactoryLinkedServiceAzureBlobStorage#sas_token_linked_key_vault_key}
        /// </remarks>
        [JsiiProperty(name: "sasTokenLinkedKeyVaultKey", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageSasTokenLinkedKeyVaultKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageSasTokenLinkedKeyVaultKey? SasTokenLinkedKeyVaultKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#sas_uri DataFactoryLinkedServiceAzureBlobStorage#sas_uri}.</summary>
        [JsiiProperty(name: "sasUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SasUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_endpoint DataFactoryLinkedServiceAzureBlobStorage#service_endpoint}.</summary>
        [JsiiProperty(name: "serviceEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_id DataFactoryLinkedServiceAzureBlobStorage#service_principal_id}.</summary>
        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServicePrincipalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_key DataFactoryLinkedServiceAzureBlobStorage#service_principal_key}.</summary>
        [JsiiProperty(name: "servicePrincipalKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServicePrincipalKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_principal_linked_key_vault_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_linked_key_vault_key DataFactoryLinkedServiceAzureBlobStorage#service_principal_linked_key_vault_key}
        /// </remarks>
        [JsiiProperty(name: "servicePrincipalLinkedKeyVaultKey", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKey? ServicePrincipalLinkedKeyVaultKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#storage_kind DataFactoryLinkedServiceAzureBlobStorage#storage_kind}.</summary>
        [JsiiProperty(name: "storageKind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageKind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#tenant_id DataFactoryLinkedServiceAzureBlobStorage#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#timeouts DataFactoryLinkedServiceAzureBlobStorage#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#use_managed_identity DataFactoryLinkedServiceAzureBlobStorage#use_managed_identity}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseManagedIdentity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryLinkedServiceAzureBlobStorageConfig), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#data_factory_id DataFactoryLinkedServiceAzureBlobStorage#data_factory_id}.</summary>
            [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataFactoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#name DataFactoryLinkedServiceAzureBlobStorage#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#additional_properties DataFactoryLinkedServiceAzureBlobStorage#additional_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdditionalProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#annotations DataFactoryLinkedServiceAzureBlobStorage#annotations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Annotations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#connection_string DataFactoryLinkedServiceAzureBlobStorage#connection_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#connection_string_insecure DataFactoryLinkedServiceAzureBlobStorage#connection_string_insecure}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionStringInsecure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionStringInsecure
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#description DataFactoryLinkedServiceAzureBlobStorage#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#id DataFactoryLinkedServiceAzureBlobStorage#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#integration_runtime_name DataFactoryLinkedServiceAzureBlobStorage#integration_runtime_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "integrationRuntimeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IntegrationRuntimeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#parameters DataFactoryLinkedServiceAzureBlobStorage#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>sas_token_linked_key_vault_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#sas_token_linked_key_vault_key DataFactoryLinkedServiceAzureBlobStorage#sas_token_linked_key_vault_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sasTokenLinkedKeyVaultKey", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageSasTokenLinkedKeyVaultKey\"}", isOptional: true)]
            public azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageSasTokenLinkedKeyVaultKey? SasTokenLinkedKeyVaultKey
            {
                get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageSasTokenLinkedKeyVaultKey?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#sas_uri DataFactoryLinkedServiceAzureBlobStorage#sas_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sasUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SasUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_endpoint DataFactoryLinkedServiceAzureBlobStorage#service_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_id DataFactoryLinkedServiceAzureBlobStorage#service_principal_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServicePrincipalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_key DataFactoryLinkedServiceAzureBlobStorage#service_principal_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "servicePrincipalKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServicePrincipalKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>service_principal_linked_key_vault_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_linked_key_vault_key DataFactoryLinkedServiceAzureBlobStorage#service_principal_linked_key_vault_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "servicePrincipalLinkedKeyVaultKey", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKey\"}", isOptional: true)]
            public azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKey? ServicePrincipalLinkedKeyVaultKey
            {
                get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKey?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#storage_kind DataFactoryLinkedServiceAzureBlobStorage#storage_kind}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageKind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageKind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#tenant_id DataFactoryLinkedServiceAzureBlobStorage#tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#timeouts DataFactoryLinkedServiceAzureBlobStorage#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageTimeouts\"}", isOptional: true)]
            public azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceAzureBlobStorage.IDataFactoryLinkedServiceAzureBlobStorageTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_azure_blob_storage#use_managed_identity DataFactoryLinkedServiceAzureBlobStorage#use_managed_identity}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseManagedIdentity
            {
                get => GetInstanceProperty<object?>();
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
