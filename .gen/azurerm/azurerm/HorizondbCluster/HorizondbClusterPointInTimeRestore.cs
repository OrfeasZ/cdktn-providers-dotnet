using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.horizondbCluster.HorizondbClusterPointInTimeRestore")]
    public class HorizondbClusterPointInTimeRestore : azurerm.HorizondbCluster.IHorizondbClusterPointInTimeRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#point_in_time_utc HorizondbCluster#point_in_time_utc}.</summary>
        [JsiiProperty(name: "pointInTimeUtc", typeJson: "{\"primitive\":\"string\"}")]
        public string PointInTimeUtc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#source_horizondb_cluster_id HorizondbCluster#source_horizondb_cluster_id}.</summary>
        [JsiiProperty(name: "sourceHorizondbClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceHorizondbClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#source_location HorizondbCluster#source_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceLocation
        {
            get;
            set;
        }
    }
}
