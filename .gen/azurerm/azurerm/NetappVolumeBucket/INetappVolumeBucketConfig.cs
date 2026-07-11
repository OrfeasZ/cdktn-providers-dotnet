using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucket
{
    [JsiiInterface(nativeType: typeof(INetappVolumeBucketConfig), fullyQualifiedName: "azurerm.netappVolumeBucket.NetappVolumeBucketConfig")]
    public interface INetappVolumeBucketConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#name NetappVolumeBucket#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#volume_id NetappVolumeBucket#volume_id}.</summary>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#file_system_cifs_username NetappVolumeBucket#file_system_cifs_username}.</summary>
        [JsiiProperty(name: "fileSystemCifsUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileSystemCifsUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system_nfs_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#file_system_nfs_user NetappVolumeBucket#file_system_nfs_user}
        /// </remarks>
        [JsiiProperty(name: "fileSystemNfsUser", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucket.NetappVolumeBucketFileSystemNfsUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappVolumeBucket.INetappVolumeBucketFileSystemNfsUser? FileSystemNfsUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#id NetappVolumeBucket#id}.</summary>
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

        /// <summary>key_vault block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#key_vault NetappVolumeBucket#key_vault}
        /// </remarks>
        [JsiiProperty(name: "keyVault", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucket.NetappVolumeBucketKeyVault\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappVolumeBucket.INetappVolumeBucketKeyVault? KeyVault
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#path NetappVolumeBucket#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#permissions NetappVolumeBucket#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Permissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#timeouts NetappVolumeBucket#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucket.NetappVolumeBucketTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappVolumeBucket.INetappVolumeBucketTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeBucketConfig), fullyQualifiedName: "azurerm.netappVolumeBucket.NetappVolumeBucketConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeBucket.INetappVolumeBucketConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#name NetappVolumeBucket#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#volume_id NetappVolumeBucket#volume_id}.</summary>
            [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#file_system_cifs_username NetappVolumeBucket#file_system_cifs_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemCifsUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileSystemCifsUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>file_system_nfs_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#file_system_nfs_user NetappVolumeBucket#file_system_nfs_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemNfsUser", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucket.NetappVolumeBucketFileSystemNfsUser\"}", isOptional: true)]
            public azurerm.NetappVolumeBucket.INetappVolumeBucketFileSystemNfsUser? FileSystemNfsUser
            {
                get => GetInstanceProperty<azurerm.NetappVolumeBucket.INetappVolumeBucketFileSystemNfsUser?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#id NetappVolumeBucket#id}.</summary>
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

            /// <summary>key_vault block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#key_vault NetappVolumeBucket#key_vault}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVault", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucket.NetappVolumeBucketKeyVault\"}", isOptional: true)]
            public azurerm.NetappVolumeBucket.INetappVolumeBucketKeyVault? KeyVault
            {
                get => GetInstanceProperty<azurerm.NetappVolumeBucket.INetappVolumeBucketKeyVault?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#path NetappVolumeBucket#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#permissions NetappVolumeBucket#permissions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Permissions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_bucket#timeouts NetappVolumeBucket#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucket.NetappVolumeBucketTimeouts\"}", isOptional: true)]
            public azurerm.NetappVolumeBucket.INetappVolumeBucketTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.NetappVolumeBucket.INetappVolumeBucketTimeouts?>();
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
