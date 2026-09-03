using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageSyncServerEndpoint
{
    [JsiiInterface(nativeType: typeof(IStorageSyncServerEndpointConfig), fullyQualifiedName: "azurerm.storageSyncServerEndpoint.StorageSyncServerEndpointConfig")]
    public interface IStorageSyncServerEndpointConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#name StorageSyncServerEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#registered_server_id StorageSyncServerEndpoint#registered_server_id}.</summary>
        [JsiiProperty(name: "registeredServerId", typeJson: "{\"primitive\":\"string\"}")]
        string RegisteredServerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#server_local_path StorageSyncServerEndpoint#server_local_path}.</summary>
        [JsiiProperty(name: "serverLocalPath", typeJson: "{\"primitive\":\"string\"}")]
        string ServerLocalPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#storage_sync_group_id StorageSyncServerEndpoint#storage_sync_group_id}.</summary>
        [JsiiProperty(name: "storageSyncGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageSyncGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#cloud_tiering_enabled StorageSyncServerEndpoint#cloud_tiering_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "cloudTieringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudTieringEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#id StorageSyncServerEndpoint#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#initial_download_policy StorageSyncServerEndpoint#initial_download_policy}.</summary>
        [JsiiProperty(name: "initialDownloadPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitialDownloadPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#local_cache_mode StorageSyncServerEndpoint#local_cache_mode}.</summary>
        [JsiiProperty(name: "localCacheMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalCacheMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#tier_files_older_than_days StorageSyncServerEndpoint#tier_files_older_than_days}.</summary>
        [JsiiProperty(name: "tierFilesOlderThanDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TierFilesOlderThanDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#timeouts StorageSyncServerEndpoint#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.storageSyncServerEndpoint.StorageSyncServerEndpointTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageSyncServerEndpoint.IStorageSyncServerEndpointTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#volume_free_space_percent StorageSyncServerEndpoint#volume_free_space_percent}.</summary>
        [JsiiProperty(name: "volumeFreeSpacePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumeFreeSpacePercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageSyncServerEndpointConfig), fullyQualifiedName: "azurerm.storageSyncServerEndpoint.StorageSyncServerEndpointConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageSyncServerEndpoint.IStorageSyncServerEndpointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#name StorageSyncServerEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#registered_server_id StorageSyncServerEndpoint#registered_server_id}.</summary>
            [JsiiProperty(name: "registeredServerId", typeJson: "{\"primitive\":\"string\"}")]
            public string RegisteredServerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#server_local_path StorageSyncServerEndpoint#server_local_path}.</summary>
            [JsiiProperty(name: "serverLocalPath", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerLocalPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#storage_sync_group_id StorageSyncServerEndpoint#storage_sync_group_id}.</summary>
            [JsiiProperty(name: "storageSyncGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageSyncGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#cloud_tiering_enabled StorageSyncServerEndpoint#cloud_tiering_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudTieringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CloudTieringEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#id StorageSyncServerEndpoint#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#initial_download_policy StorageSyncServerEndpoint#initial_download_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialDownloadPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitialDownloadPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#local_cache_mode StorageSyncServerEndpoint#local_cache_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localCacheMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalCacheMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#tier_files_older_than_days StorageSyncServerEndpoint#tier_files_older_than_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tierFilesOlderThanDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TierFilesOlderThanDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#timeouts StorageSyncServerEndpoint#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.storageSyncServerEndpoint.StorageSyncServerEndpointTimeouts\"}", isOptional: true)]
            public azurerm.StorageSyncServerEndpoint.IStorageSyncServerEndpointTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.StorageSyncServerEndpoint.IStorageSyncServerEndpointTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_sync_server_endpoint#volume_free_space_percent StorageSyncServerEndpoint#volume_free_space_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeFreeSpacePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumeFreeSpacePercent
            {
                get => GetInstanceProperty<double?>();
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
