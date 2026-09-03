using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccountSas
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageAccountSasConfig), fullyQualifiedName: "azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasConfig")]
    public interface IDataAzurermStorageAccountSasConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#connection_string DataAzurermStorageAccountSas#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionString
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#expiry DataAzurermStorageAccountSas#expiry}.</summary>
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
        string Expiry
        {
            get;
        }

        /// <summary>resource_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#resource_types DataAzurermStorageAccountSas#resource_types}
        /// </remarks>
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypes\"}")]
        azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasResourceTypes ResourceTypes
        {
            get;
        }

        /// <summary>services block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#services DataAzurermStorageAccountSas#services}
        /// </remarks>
        [JsiiProperty(name: "services", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasServices\"}")]
        azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasServices Services
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#start DataAzurermStorageAccountSas#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        string Start
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#https_only DataAzurermStorageAccountSas#https_only}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#id DataAzurermStorageAccountSas#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#ip_addresses DataAzurermStorageAccountSas#ip_addresses}.</summary>
        [JsiiProperty(name: "ipAddresses", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#permissions DataAzurermStorageAccountSas#permissions}
        /// </remarks>
        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasPermissions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasPermissions? Permissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#signed_version DataAzurermStorageAccountSas#signed_version}.</summary>
        [JsiiProperty(name: "signedVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignedVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#timeouts DataAzurermStorageAccountSas#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageAccountSasConfig), fullyQualifiedName: "azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#connection_string DataAzurermStorageAccountSas#connection_string}.</summary>
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionString
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#expiry DataAzurermStorageAccountSas#expiry}.</summary>
            [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
            public string Expiry
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>resource_types block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#resource_types DataAzurermStorageAccountSas#resource_types}
            /// </remarks>
            [JsiiProperty(name: "resourceTypes", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypes\"}")]
            public azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasResourceTypes ResourceTypes
            {
                get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasResourceTypes>()!;
            }

            /// <summary>services block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#services DataAzurermStorageAccountSas#services}
            /// </remarks>
            [JsiiProperty(name: "services", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasServices\"}")]
            public azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasServices Services
            {
                get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasServices>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#start DataAzurermStorageAccountSas#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
            public string Start
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#https_only DataAzurermStorageAccountSas#https_only}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HttpsOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#id DataAzurermStorageAccountSas#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#ip_addresses DataAzurermStorageAccountSas#ip_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddresses", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddresses
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#permissions DataAzurermStorageAccountSas#permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasPermissions\"}", isOptional: true)]
            public azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasPermissions? Permissions
            {
                get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasPermissions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#signed_version DataAzurermStorageAccountSas#signed_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signedVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignedVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/storage_account_sas#timeouts DataAzurermStorageAccountSas#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeouts\"}", isOptional: true)]
            public azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasTimeouts?>();
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
