using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.ManagedDisk
{
    [JsiiInterface(nativeType: typeof(IManagedDiskEncryptionDiskEncryptionKey), fullyQualifiedName: "azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKey")]
    public interface IManagedDiskEncryptionDiskEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#secret_url ManagedDisk#secret_url}.</summary>
        [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SecretUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#source_vault_id ManagedDisk#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDiskEncryptionDiskEncryptionKey), fullyQualifiedName: "azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#secret_url ManagedDisk#secret_url}.</summary>
            [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretUrl
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
