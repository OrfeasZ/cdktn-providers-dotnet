using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiInterface(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputs), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputs")]
    public interface ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputs
    {
        /// <summary>s3_output block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#s3_output SagemakerMonitoringSchedule#s3_output}
        /// </remarks>
        [JsiiProperty(name: "s3Output", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output\"}")]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output S3Output
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputs), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputs")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_output block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#s3_output SagemakerMonitoringSchedule#s3_output}
            /// </remarks>
            [JsiiProperty(name: "s3Output", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output\"}")]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output S3Output
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output>()!;
            }
        }
    }
}
