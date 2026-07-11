using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.ManagedDisk
{
    [JsiiInterface(nativeType: typeof(IManagedDiskEncryption), fullyQualifiedName: "azurestack.managedDisk.ManagedDiskEncryption")]
    public interface IManagedDiskEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#enabled ManagedDisk#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>disk_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#disk_encryption_key ManagedDisk#disk_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey? DiskEncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#key_encryption_key ManagedDisk#key_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionKeyEncryptionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey? KeyEncryptionKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDiskEncryption), fullyQualifiedName: "azurestack.managedDisk.ManagedDiskEncryption")]
        internal sealed class _Proxy : DeputyBase, azurestack.ManagedDisk.IManagedDiskEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#enabled ManagedDisk#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>disk_encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#disk_encryption_key ManagedDisk#disk_encryption_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKey\"}", isOptional: true)]
            public azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey? DiskEncryptionKey
            {
                get => GetInstanceProperty<azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey?>();
            }

            /// <summary>key_encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#key_encryption_key ManagedDisk#key_encryption_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionKeyEncryptionKey\"}", isOptional: true)]
            public azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey? KeyEncryptionKey
            {
                get => GetInstanceProperty<azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey?>();
            }
        }
    }
}
