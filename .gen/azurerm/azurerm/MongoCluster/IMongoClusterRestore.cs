using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MongoCluster
{
    [JsiiInterface(nativeType: typeof(IMongoClusterRestore), fullyQualifiedName: "azurerm.mongoCluster.MongoClusterRestore")]
    public interface IMongoClusterRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mongo_cluster#point_in_time_utc MongoCluster#point_in_time_utc}.</summary>
        [JsiiProperty(name: "pointInTimeUtc", typeJson: "{\"primitive\":\"string\"}")]
        string PointInTimeUtc
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mongo_cluster#source_id MongoCluster#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMongoClusterRestore), fullyQualifiedName: "azurerm.mongoCluster.MongoClusterRestore")]
        internal sealed class _Proxy : DeputyBase, azurerm.MongoCluster.IMongoClusterRestore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mongo_cluster#point_in_time_utc MongoCluster#point_in_time_utc}.</summary>
            [JsiiProperty(name: "pointInTimeUtc", typeJson: "{\"primitive\":\"string\"}")]
            public string PointInTimeUtc
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/mongo_cluster#source_id MongoCluster#source_id}.</summary>
            [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
