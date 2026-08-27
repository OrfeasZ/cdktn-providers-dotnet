using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence")]
    public interface IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence
    {
        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_spark_cluster#schedule HdinsightSparkCluster#schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule\"},\"kind\":\"array\"}}]}}")]
        object Schedule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_spark_cluster#timezone HdinsightSparkCluster#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_spark_cluster#schedule HdinsightSparkCluster#schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule\"},\"kind\":\"array\"}}]}}")]
            public object Schedule
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_spark_cluster#timezone HdinsightSparkCluster#timezone}.</summary>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
