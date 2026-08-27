using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedRedis.ManagedRedisCustomerManagedKey")]
    public class ManagedRedisCustomerManagedKey : azurerm.ManagedRedis.IManagedRedisCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis#key_vault_key_id ManagedRedis#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis#user_assigned_identity_id ManagedRedis#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
