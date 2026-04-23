using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiInterface(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources")]
    public interface ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources
    {
        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#cluster_config SagemakerMonitoringSchedule#cluster_config}
        /// </remarks>
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig\"}")]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig ClusterConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cluster_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#cluster_config SagemakerMonitoringSchedule#cluster_config}
            /// </remarks>
            [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig\"}")]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig ClusterConfig
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig>()!;
            }
        }
    }
}
