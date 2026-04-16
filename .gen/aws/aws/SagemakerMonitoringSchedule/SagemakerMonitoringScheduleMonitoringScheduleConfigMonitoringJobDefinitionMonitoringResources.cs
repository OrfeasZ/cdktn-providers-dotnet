using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources : aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources
    {
        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#cluster_config SagemakerMonitoringSchedule#cluster_config}
        /// </remarks>
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig\"}")]
        public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig ClusterConfig
        {
            get;
            set;
        }
    }
}
