using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiByValue(fqn: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat : aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat
    {
        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#csv SagemakerMonitoringSchedule#csv}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatCsv\"}", isOptional: true)]
        public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatCsv? Csv
        {
            get;
            set;
        }

        /// <summary>json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#json SagemakerMonitoringSchedule#json}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatJson\"}", isOptional: true)]
        public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatJson? Json
        {
            get;
            set;
        }
    }
}
