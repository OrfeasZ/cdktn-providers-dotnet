using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.ManagedDisk
{
    [JsiiInterface(nativeType: typeof(IManagedDiskEncryptionKeyEncryptionKey), fullyQualifiedName: "azurestack.managedDisk.ManagedDiskEncryptionKeyEncryptionKey")]
    public interface IManagedDiskEncryptionKeyEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#key_url ManagedDisk#key_url}.</summary>
        [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
        string KeyUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#source_vault_id ManagedDisk#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDiskEncryptionKeyEncryptionKey), fullyQualifiedName: "azurestack.managedDisk.ManagedDiskEncryptionKeyEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#key_url ManagedDisk#key_url}.</summary>
            [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#source_vault_id ManagedDisk#source_vault_id}.</summary>
            [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
