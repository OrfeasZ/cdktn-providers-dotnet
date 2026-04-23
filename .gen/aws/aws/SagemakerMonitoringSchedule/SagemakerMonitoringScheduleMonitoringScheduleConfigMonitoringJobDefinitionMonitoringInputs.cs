using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiByValue(fqn: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs : aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs
    {
        /// <summary>batch_transform_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#batch_transform_input SagemakerMonitoringSchedule#batch_transform_input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "batchTransformInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput\"}", isOptional: true)]
        public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput? BatchTransformInput
        {
            get;
            set;
        }

        /// <summary>endpoint_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#endpoint_input SagemakerMonitoringSchedule#endpoint_input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput\"}", isOptional: true)]
        public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput? EndpointInput
        {
            get;
            set;
        }
    }
}
