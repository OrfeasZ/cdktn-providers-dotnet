using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MongoCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mongoCluster.MongoClusterRestore")]
    public class MongoClusterRestore : azurerm.MongoCluster.IMongoClusterRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mongo_cluster#point_in_time_utc MongoCluster#point_in_time_utc}.</summary>
        [JsiiProperty(name: "pointInTimeUtc", typeJson: "{\"primitive\":\"string\"}")]
        public string PointInTimeUtc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mongo_cluster#source_id MongoCluster#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceId
        {
            get;
            set;
        }
    }
}
