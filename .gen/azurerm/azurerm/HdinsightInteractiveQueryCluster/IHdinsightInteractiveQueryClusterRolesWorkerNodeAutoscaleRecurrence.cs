using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence")]
    public interface IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence
    {
        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_interactive_query_cluster#schedule HdinsightInteractiveQueryCluster#schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule\"},\"kind\":\"array\"}}]}}")]
        object Schedule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_interactive_query_cluster#timezone HdinsightInteractiveQueryCluster#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_interactive_query_cluster#schedule HdinsightInteractiveQueryCluster#schedule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule\"},\"kind\":\"array\"}}]}}")]
            public object Schedule
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_interactive_query_cluster#timezone HdinsightInteractiveQueryCluster#timezone}.</summary>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
