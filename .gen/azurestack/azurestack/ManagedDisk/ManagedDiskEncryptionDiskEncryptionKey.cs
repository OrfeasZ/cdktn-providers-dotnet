using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.ManagedDisk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKey")]
    public class ManagedDiskEncryptionDiskEncryptionKey : azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#secret_url ManagedDisk#secret_url}.</summary>
        [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/managed_disk#source_vault_id ManagedDisk#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceVaultId
        {
            get;
            set;
        }
    }
}
