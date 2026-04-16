using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.StorageBoxSubaccount
{
    [JsiiInterface(nativeType: typeof(IStorageBoxSubaccountAccessSettings), fullyQualifiedName: "hcloud.storageBoxSubaccount.StorageBoxSubaccountAccessSettings")]
    public interface IStorageBoxSubaccountAccessSettings
    {
        /// <summary>Whether access from outside the Hetzner network is allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#reachable_externally StorageBoxSubaccount#reachable_externally}
        /// </remarks>
        [JsiiProperty(name: "reachableExternally", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReachableExternally
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the Subaccount is read-only.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#readonly StorageBoxSubaccount#readonly}
        /// </remarks>
        [JsiiProperty(name: "readonly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Readonly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the Samba subsystem is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#samba_enabled StorageBoxSubaccount#samba_enabled}
        /// </remarks>
        [JsiiProperty(name: "sambaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SambaEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the SSH subsystem is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#ssh_enabled StorageBoxSubaccount#ssh_enabled}
        /// </remarks>
        [JsiiProperty(name: "sshEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SshEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the WebDAV subsystem is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#webdav_enabled StorageBoxSubaccount#webdav_enabled}
        /// </remarks>
        [JsiiProperty(name: "webdavEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebdavEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBoxSubaccountAccessSettings), fullyQualifiedName: "hcloud.storageBoxSubaccount.StorageBoxSubaccountAccessSettings")]
        internal sealed class _Proxy : DeputyBase, hcloud.StorageBoxSubaccount.IStorageBoxSubaccountAccessSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether access from outside the Hetzner network is allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#reachable_externally StorageBoxSubaccount#reachable_externally}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reachableExternally", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReachableExternally
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the Subaccount is read-only.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#readonly StorageBoxSubaccount#readonly}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readonly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Readonly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the Samba subsystem is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#samba_enabled StorageBoxSubaccount#samba_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sambaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SambaEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the SSH subsystem is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#ssh_enabled StorageBoxSubaccount#ssh_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sshEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SshEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the WebDAV subsystem is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box_subaccount#webdav_enabled StorageBoxSubaccount#webdav_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webdavEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WebdavEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
