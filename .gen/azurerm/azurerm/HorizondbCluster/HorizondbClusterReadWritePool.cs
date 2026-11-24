using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.horizondbCluster.HorizondbClusterReadWritePool")]
    public class HorizondbClusterReadWritePool : azurerm.HorizondbCluster.IHorizondbClusterReadWritePool
    {
        /// <summary>compute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#compute HorizondbCluster#compute}
        /// </remarks>
        [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute\"}")]
        public azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute Compute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#high_availability_mode HorizondbCluster#high_availability_mode}.</summary>
        [JsiiProperty(name: "highAvailabilityMode", typeJson: "{\"primitive\":\"string\"}")]
        public string HighAvailabilityMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#name HorizondbCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#node_count HorizondbCluster#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double NodeCount
        {
            get;
            set;
        }
    }
}
