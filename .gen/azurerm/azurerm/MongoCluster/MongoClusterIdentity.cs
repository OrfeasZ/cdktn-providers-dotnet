using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MongoCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mongoCluster.MongoClusterIdentity")]
    public class MongoClusterIdentity : azurerm.MongoCluster.IMongoClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster#identity_ids MongoCluster#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] IdentityIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster#type MongoCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
