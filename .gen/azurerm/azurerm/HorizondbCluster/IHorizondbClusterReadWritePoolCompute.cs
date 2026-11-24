using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    [JsiiInterface(nativeType: typeof(IHorizondbClusterReadWritePoolCompute), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute")]
    public interface IHorizondbClusterReadWritePoolCompute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#generation HorizondbCluster#generation}.</summary>
        [JsiiProperty(name: "generation", typeJson: "{\"primitive\":\"number\"}")]
        double Generation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#processor HorizondbCluster#processor}.</summary>
        [JsiiProperty(name: "processor", typeJson: "{\"primitive\":\"string\"}")]
        string Processor
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#vcores HorizondbCluster#vcores}.</summary>
        [JsiiProperty(name: "vcores", typeJson: "{\"primitive\":\"number\"}")]
        double Vcores
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHorizondbClusterReadWritePoolCompute), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute")]
        internal sealed class _Proxy : DeputyBase, azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#generation HorizondbCluster#generation}.</summary>
            [JsiiProperty(name: "generation", typeJson: "{\"primitive\":\"number\"}")]
            public double Generation
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#processor HorizondbCluster#processor}.</summary>
            [JsiiProperty(name: "processor", typeJson: "{\"primitive\":\"string\"}")]
            public string Processor
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#vcores HorizondbCluster#vcores}.</summary>
            [JsiiProperty(name: "vcores", typeJson: "{\"primitive\":\"number\"}")]
            public double Vcores
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
