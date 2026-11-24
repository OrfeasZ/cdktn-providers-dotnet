using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    [JsiiInterface(nativeType: typeof(IHorizondbClusterPointInTimeRestore), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterPointInTimeRestore")]
    public interface IHorizondbClusterPointInTimeRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#point_in_time_utc HorizondbCluster#point_in_time_utc}.</summary>
        [JsiiProperty(name: "pointInTimeUtc", typeJson: "{\"primitive\":\"string\"}")]
        string PointInTimeUtc
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#source_horizondb_cluster_id HorizondbCluster#source_horizondb_cluster_id}.</summary>
        [JsiiProperty(name: "sourceHorizondbClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceHorizondbClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#source_location HorizondbCluster#source_location}.</summary>
        [JsiiProperty(name: "sourceLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHorizondbClusterPointInTimeRestore), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterPointInTimeRestore")]
        internal sealed class _Proxy : DeputyBase, azurerm.HorizondbCluster.IHorizondbClusterPointInTimeRestore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#point_in_time_utc HorizondbCluster#point_in_time_utc}.</summary>
            [JsiiProperty(name: "pointInTimeUtc", typeJson: "{\"primitive\":\"string\"}")]
            public string PointInTimeUtc
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#source_horizondb_cluster_id HorizondbCluster#source_horizondb_cluster_id}.</summary>
            [JsiiProperty(name: "sourceHorizondbClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceHorizondbClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#source_location HorizondbCluster#source_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceLocation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
