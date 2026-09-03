using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MongoCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mongoCluster.MongoClusterCustomerManagedKey")]
    public class MongoClusterCustomerManagedKey : azurerm.MongoCluster.IMongoClusterCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster#key_vault_key_id MongoCluster#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster#user_assigned_identity_id MongoCluster#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
