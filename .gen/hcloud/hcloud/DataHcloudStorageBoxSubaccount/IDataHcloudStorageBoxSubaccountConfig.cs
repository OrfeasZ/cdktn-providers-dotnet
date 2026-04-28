using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudStorageBoxSubaccount
{
    [JsiiInterface(nativeType: typeof(IDataHcloudStorageBoxSubaccountConfig), fullyQualifiedName: "hcloud.dataHcloudStorageBoxSubaccount.DataHcloudStorageBoxSubaccountConfig")]
    public interface IDataHcloudStorageBoxSubaccountConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the Storage Box.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#storage_box_id DataHcloudStorageBoxSubaccount#storage_box_id}
        /// </remarks>
        [JsiiProperty(name: "storageBoxId", typeJson: "{\"primitive\":\"number\"}")]
        double StorageBoxId
        {
            get;
        }

        /// <summary>ID of the Storage Box Subaccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#id DataHcloudStorageBoxSubaccount#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Storage Box Subaccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#name DataHcloudStorageBoxSubaccount#name}
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

        /// <summary>Username of the Storage Box Subaccount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#username DataHcloudStorageBoxSubaccount#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/hetzner#label-selector).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#with_selector DataHcloudStorageBoxSubaccount#with_selector}
        /// </remarks>
        [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WithSelector
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataHcloudStorageBoxSubaccountConfig), fullyQualifiedName: "hcloud.dataHcloudStorageBoxSubaccount.DataHcloudStorageBoxSubaccountConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.DataHcloudStorageBoxSubaccount.IDataHcloudStorageBoxSubaccountConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the Storage Box.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#storage_box_id DataHcloudStorageBoxSubaccount#storage_box_id}
            /// </remarks>
            [JsiiProperty(name: "storageBoxId", typeJson: "{\"primitive\":\"number\"}")]
            public double StorageBoxId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>ID of the Storage Box Subaccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#id DataHcloudStorageBoxSubaccount#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Id
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Name of the Storage Box Subaccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#name DataHcloudStorageBoxSubaccount#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Username of the Storage Box Subaccount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#username DataHcloudStorageBoxSubaccount#username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/hetzner#label-selector).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_subaccount#with_selector DataHcloudStorageBoxSubaccount#with_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WithSelector
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
