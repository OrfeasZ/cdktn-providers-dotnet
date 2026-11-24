using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    [JsiiInterface(nativeType: typeof(IHorizondbClusterReadWritePool), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterReadWritePool")]
    public interface IHorizondbClusterReadWritePool
    {
        /// <summary>compute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#compute HorizondbCluster#compute}
        /// </remarks>
        [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute\"}")]
        azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute Compute
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#high_availability_mode HorizondbCluster#high_availability_mode}.</summary>
        [JsiiProperty(name: "highAvailabilityMode", typeJson: "{\"primitive\":\"string\"}")]
        string HighAvailabilityMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#name HorizondbCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#node_count HorizondbCluster#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double NodeCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHorizondbClusterReadWritePool), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterReadWritePool")]
        internal sealed class _Proxy : DeputyBase, azurerm.HorizondbCluster.IHorizondbClusterReadWritePool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>compute block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#compute HorizondbCluster#compute}
            /// </remarks>
            [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute\"}")]
            public azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute Compute
            {
                get => GetInstanceProperty<azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#high_availability_mode HorizondbCluster#high_availability_mode}.</summary>
            [JsiiProperty(name: "highAvailabilityMode", typeJson: "{\"primitive\":\"string\"}")]
            public string HighAvailabilityMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#name HorizondbCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/horizondb_cluster#node_count HorizondbCluster#node_count}.</summary>
            [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double NodeCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
