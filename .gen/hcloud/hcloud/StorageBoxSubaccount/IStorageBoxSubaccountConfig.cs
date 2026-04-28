using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.StorageBoxSubaccount
{
    [JsiiInterface(nativeType: typeof(IStorageBoxSubaccountConfig), fullyQualifiedName: "hcloud.storageBoxSubaccount.StorageBoxSubaccountConfig")]
    public interface IStorageBoxSubaccountConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Home directory of the Storage Box Subaccount.</summary>
        /// <remarks>
        /// The directory will be created if it doesn't exist yet. Must not include a leading slash (<c>/</c>).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#home_directory StorageBoxSubaccount#home_directory}
        /// </remarks>
        [JsiiProperty(name: "homeDirectory", typeJson: "{\"primitive\":\"string\"}")]
        string HomeDirectory
        {
            get;
        }

        /// <summary>Password of the Storage Box. For more details, see the [Storage Boxes password policy](https://docs.hetzner.cloud/reference/hetzner#storage-boxes-password-policy).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#password StorageBoxSubaccount#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>ID of the Storage Box.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#storage_box_id StorageBoxSubaccount#storage_box_id}
        /// </remarks>
        [JsiiProperty(name: "storageBoxId", typeJson: "{\"primitive\":\"number\"}")]
        double StorageBoxId
        {
            get;
        }

        /// <summary>Access settings for the Subaccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#access_settings StorageBoxSubaccount#access_settings}
        /// </remarks>
        [JsiiProperty(name: "accessSettings", typeJson: "{\"fqn\":\"hcloud.storageBoxSubaccount.StorageBoxSubaccountAccessSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        hcloud.StorageBoxSubaccount.IStorageBoxSubaccountAccessSettings? AccessSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>A description of the Storage Box Subaccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#description StorageBoxSubaccount#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#labels StorageBoxSubaccount#labels}
        /// </remarks>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Storage Box Subaccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#name StorageBoxSubaccount#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBoxSubaccountConfig), fullyQualifiedName: "hcloud.storageBoxSubaccount.StorageBoxSubaccountConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.StorageBoxSubaccount.IStorageBoxSubaccountConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Home directory of the Storage Box Subaccount.</summary>
            /// <remarks>
            /// The directory will be created if it doesn't exist yet. Must not include a leading slash (<c>/</c>).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#home_directory StorageBoxSubaccount#home_directory}
            /// </remarks>
            [JsiiProperty(name: "homeDirectory", typeJson: "{\"primitive\":\"string\"}")]
            public string HomeDirectory
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Password of the Storage Box. For more details, see the [Storage Boxes password policy](https://docs.hetzner.cloud/reference/hetzner#storage-boxes-password-policy).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#password StorageBoxSubaccount#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the Storage Box.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#storage_box_id StorageBoxSubaccount#storage_box_id}
            /// </remarks>
            [JsiiProperty(name: "storageBoxId", typeJson: "{\"primitive\":\"number\"}")]
            public double StorageBoxId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Access settings for the Subaccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#access_settings StorageBoxSubaccount#access_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessSettings", typeJson: "{\"fqn\":\"hcloud.storageBoxSubaccount.StorageBoxSubaccountAccessSettings\"}", isOptional: true)]
            public hcloud.StorageBoxSubaccount.IStorageBoxSubaccountAccessSettings? AccessSettings
            {
                get => GetInstanceProperty<hcloud.StorageBoxSubaccount.IStorageBoxSubaccountAccessSettings?>();
            }

            /// <summary>A description of the Storage Box Subaccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#description StorageBoxSubaccount#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#labels StorageBoxSubaccount#labels}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Name of the Storage Box Subaccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box_subaccount#name StorageBoxSubaccount#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
