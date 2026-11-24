using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute")]
    public class HorizondbClusterReadWritePoolCompute : azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#generation HorizondbCluster#generation}.</summary>
        [JsiiProperty(name: "generation", typeJson: "{\"primitive\":\"number\"}")]
        public double Generation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#processor HorizondbCluster#processor}.</summary>
        [JsiiProperty(name: "processor", typeJson: "{\"primitive\":\"string\"}")]
        public string Processor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#vcores HorizondbCluster#vcores}.</summary>
        [JsiiProperty(name: "vcores", typeJson: "{\"primitive\":\"number\"}")]
        public double Vcores
        {
            get;
            set;
        }
    }
}
