using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.StorageBox
{
    [JsiiInterface(nativeType: typeof(IStorageBoxAccessSettings), fullyQualifiedName: "hcloud.storageBox.StorageBoxAccessSettings")]
    public interface IStorageBoxAccessSettings
    {
        /// <summary>Whether access from outside the Hetzner network is allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#reachable_externally StorageBox#reachable_externally}
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

        /// <summary>Whether the Samba subsystem is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#samba_enabled StorageBox#samba_enabled}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#ssh_enabled StorageBox#ssh_enabled}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#webdav_enabled StorageBox#webdav_enabled}
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

        /// <summary>Whether the ZFS snapshot folder is visible.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#zfs_enabled StorageBox#zfs_enabled}
        /// </remarks>
        [JsiiProperty(name: "zfsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ZfsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBoxAccessSettings), fullyQualifiedName: "hcloud.storageBox.StorageBoxAccessSettings")]
        internal sealed class _Proxy : DeputyBase, hcloud.StorageBox.IStorageBoxAccessSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether access from outside the Hetzner network is allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#reachable_externally StorageBox#reachable_externally}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reachableExternally", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReachableExternally
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the Samba subsystem is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#samba_enabled StorageBox#samba_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sambaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SambaEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the SSH subsystem is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#ssh_enabled StorageBox#ssh_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sshEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SshEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the WebDAV subsystem is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#webdav_enabled StorageBox#webdav_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webdavEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WebdavEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the ZFS snapshot folder is visible.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/storage_box#zfs_enabled StorageBox#zfs_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zfsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ZfsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
