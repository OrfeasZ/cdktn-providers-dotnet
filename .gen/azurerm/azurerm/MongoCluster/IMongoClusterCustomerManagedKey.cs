using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MongoCluster
{
    [JsiiInterface(nativeType: typeof(IMongoClusterCustomerManagedKey), fullyQualifiedName: "azurerm.mongoCluster.MongoClusterCustomerManagedKey")]
    public interface IMongoClusterCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mongo_cluster#key_vault_key_id MongoCluster#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mongo_cluster#user_assigned_identity_id MongoCluster#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        string UserAssignedIdentityId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMongoClusterCustomerManagedKey), fullyQualifiedName: "azurerm.mongoCluster.MongoClusterCustomerManagedKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.MongoCluster.IMongoClusterCustomerManagedKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mongo_cluster#key_vault_key_id MongoCluster#key_vault_key_id}.</summary>
            [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mongo_cluster#user_assigned_identity_id MongoCluster#user_assigned_identity_id}.</summary>
            [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserAssignedIdentityId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
