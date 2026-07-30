using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence")]
    public class HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence : azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrence
    {
        private object _schedule;

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_interactive_query_cluster#schedule HdinsightInteractiveQueryCluster#schedule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule\"},\"kind\":\"array\"}}]}}")]
        public object Schedule
        {
            get => _schedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRolesWorkerNodeAutoscaleRecurrenceSchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schedule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_interactive_query_cluster#timezone HdinsightInteractiveQueryCluster#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public string Timezone
        {
            get;
            set;
        }
    }
}
