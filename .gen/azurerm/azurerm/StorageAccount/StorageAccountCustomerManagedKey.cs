using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountCustomerManagedKey")]
    public class StorageAccountCustomerManagedKey : azurerm.StorageAccount.IStorageAccountCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account#key_vault_key_id StorageAccount#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account#user_assigned_identity_id StorageAccount#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
