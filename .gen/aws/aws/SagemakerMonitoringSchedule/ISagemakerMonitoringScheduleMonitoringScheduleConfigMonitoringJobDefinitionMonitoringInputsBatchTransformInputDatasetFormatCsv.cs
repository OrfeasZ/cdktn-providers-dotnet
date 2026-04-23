using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiInterface(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatCsv), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatCsv")]
    public interface ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatCsv
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#header SagemakerMonitoringSchedule#header}.</summary>
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Header
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatCsv), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatCsv")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatCsv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#header SagemakerMonitoringSchedule#header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Header
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
