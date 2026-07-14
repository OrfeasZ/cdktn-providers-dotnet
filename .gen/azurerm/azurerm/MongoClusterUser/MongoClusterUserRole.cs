using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MongoClusterUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mongoClusterUser.MongoClusterUserRole")]
    public class MongoClusterUserRole : azurerm.MongoClusterUser.IMongoClusterUserRole
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/mongo_cluster_user#database MongoClusterUser#database}.</summary>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        public string Database
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/mongo_cluster_user#name MongoClusterUser#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
