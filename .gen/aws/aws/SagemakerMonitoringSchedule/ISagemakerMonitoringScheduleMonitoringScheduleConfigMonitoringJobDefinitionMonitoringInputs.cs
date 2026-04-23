using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiInterface(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs")]
    public interface ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs
    {
        /// <summary>batch_transform_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#batch_transform_input SagemakerMonitoringSchedule#batch_transform_input}
        /// </remarks>
        [JsiiProperty(name: "batchTransformInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput? BatchTransformInput
        {
            get
            {
                return null;
            }
        }

        /// <summary>endpoint_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#endpoint_input SagemakerMonitoringSchedule#endpoint_input}
        /// </remarks>
        [JsiiProperty(name: "endpointInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput? EndpointInput
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>batch_transform_input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#batch_transform_input SagemakerMonitoringSchedule#batch_transform_input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "batchTransformInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput\"}", isOptional: true)]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput? BatchTransformInput
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput?>();
            }

            /// <summary>endpoint_input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#endpoint_input SagemakerMonitoringSchedule#endpoint_input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpointInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput\"}", isOptional: true)]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput? EndpointInput
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput?>();
            }
        }
    }
}
