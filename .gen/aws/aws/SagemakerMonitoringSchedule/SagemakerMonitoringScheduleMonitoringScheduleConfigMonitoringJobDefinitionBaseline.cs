using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiByValue(fqn: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline : aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#baselining_job_name SagemakerMonitoringSchedule#baselining_job_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseliningJobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseliningJobName
        {
            get;
            set;
        }

        /// <summary>constraints_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#constraints_resource SagemakerMonitoringSchedule#constraints_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "constraintsResource", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource\"}", isOptional: true)]
        public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource? ConstraintsResource
        {
            get;
            set;
        }

        /// <summary>statistics_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#statistics_resource SagemakerMonitoringSchedule#statistics_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statisticsResource", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource\"}", isOptional: true)]
        public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource? StatisticsResource
        {
            get;
            set;
        }
    }
}
