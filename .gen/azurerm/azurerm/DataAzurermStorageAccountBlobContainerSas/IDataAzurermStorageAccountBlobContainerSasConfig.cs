using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccountBlobContainerSas
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageAccountBlobContainerSasConfig), fullyQualifiedName: "azurerm.dataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasConfig")]
    public interface IDataAzurermStorageAccountBlobContainerSasConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#connection_string DataAzurermStorageAccountBlobContainerSas#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionString
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#container_name DataAzurermStorageAccountBlobContainerSas#container_name}.</summary>
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#expiry DataAzurermStorageAccountBlobContainerSas#expiry}.</summary>
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
        string Expiry
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#start DataAzurermStorageAccountBlobContainerSas#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        string Start
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#cache_control DataAzurermStorageAccountBlobContainerSas#cache_control}.</summary>
        [JsiiProperty(name: "cacheControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#content_disposition DataAzurermStorageAccountBlobContainerSas#content_disposition}.</summary>
        [JsiiProperty(name: "contentDisposition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentDisposition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#content_encoding DataAzurermStorageAccountBlobContainerSas#content_encoding}.</summary>
        [JsiiProperty(name: "contentEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentEncoding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#content_language DataAzurermStorageAccountBlobContainerSas#content_language}.</summary>
        [JsiiProperty(name: "contentLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#content_type DataAzurermStorageAccountBlobContainerSas#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#https_only DataAzurermStorageAccountBlobContainerSas#https_only}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpsOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#id DataAzurermStorageAccountBlobContainerSas#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#ip_address DataAzurermStorageAccountBlobContainerSas#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#permissions DataAzurermStorageAccountBlobContainerSas#permissions}
        /// </remarks>
        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasPermissions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataAzurermStorageAccountBlobContainerSas.IDataAzurermStorageAccountBlobContainerSasPermissions? Permissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#timeouts DataAzurermStorageAccountBlobContainerSas#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataAzurermStorageAccountBlobContainerSas.IDataAzurermStorageAccountBlobContainerSasTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageAccountBlobContainerSasConfig), fullyQualifiedName: "azurerm.dataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageAccountBlobContainerSas.IDataAzurermStorageAccountBlobContainerSasConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#connection_string DataAzurermStorageAccountBlobContainerSas#connection_string}.</summary>
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionString
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#container_name DataAzurermStorageAccountBlobContainerSas#container_name}.</summary>
            [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#expiry DataAzurermStorageAccountBlobContainerSas#expiry}.</summary>
            [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
            public string Expiry
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#start DataAzurermStorageAccountBlobContainerSas#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
            public string Start
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#cache_control DataAzurermStorageAccountBlobContainerSas#cache_control}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheControl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#content_disposition DataAzurermStorageAccountBlobContainerSas#content_disposition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentDisposition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentDisposition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#content_encoding DataAzurermStorageAccountBlobContainerSas#content_encoding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentEncoding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#content_language DataAzurermStorageAccountBlobContainerSas#content_language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#content_type DataAzurermStorageAccountBlobContainerSas#content_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#https_only DataAzurermStorageAccountBlobContainerSas#https_only}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HttpsOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#id DataAzurermStorageAccountBlobContainerSas#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#ip_address DataAzurermStorageAccountBlobContainerSas#ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#permissions DataAzurermStorageAccountBlobContainerSas#permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasPermissions\"}", isOptional: true)]
            public azurerm.DataAzurermStorageAccountBlobContainerSas.IDataAzurermStorageAccountBlobContainerSasPermissions? Permissions
            {
                get => GetInstanceProperty<azurerm.DataAzurermStorageAccountBlobContainerSas.IDataAzurermStorageAccountBlobContainerSasPermissions?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_blob_container_sas#timeouts DataAzurermStorageAccountBlobContainerSas#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasTimeouts\"}", isOptional: true)]
            public azurerm.DataAzurermStorageAccountBlobContainerSas.IDataAzurermStorageAccountBlobContainerSasTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DataAzurermStorageAccountBlobContainerSas.IDataAzurermStorageAccountBlobContainerSasTimeouts?>();
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
