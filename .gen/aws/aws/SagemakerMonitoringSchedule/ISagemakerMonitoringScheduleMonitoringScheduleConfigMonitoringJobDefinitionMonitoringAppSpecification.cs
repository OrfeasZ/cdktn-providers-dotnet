using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiInterface(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringAppSpecification), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringAppSpecification")]
    public interface ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringAppSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#image_uri SagemakerMonitoringSchedule#image_uri}.</summary>
        [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
        string ImageUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#container_arguments SagemakerMonitoringSchedule#container_arguments}.</summary>
        [JsiiProperty(name: "containerArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ContainerArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#container_entrypoint SagemakerMonitoringSchedule#container_entrypoint}.</summary>
        [JsiiProperty(name: "containerEntrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ContainerEntrypoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#post_analytics_processor_source_uri SagemakerMonitoringSchedule#post_analytics_processor_source_uri}.</summary>
        [JsiiProperty(name: "postAnalyticsProcessorSourceUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostAnalyticsProcessorSourceUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#record_preprocessor_source_uri SagemakerMonitoringSchedule#record_preprocessor_source_uri}.</summary>
        [JsiiProperty(name: "recordPreprocessorSourceUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordPreprocessorSourceUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringAppSpecification), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringAppSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringAppSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#image_uri SagemakerMonitoringSchedule#image_uri}.</summary>
            [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#container_arguments SagemakerMonitoringSchedule#container_arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ContainerArguments
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#container_entrypoint SagemakerMonitoringSchedule#container_entrypoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerEntrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ContainerEntrypoint
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#post_analytics_processor_source_uri SagemakerMonitoringSchedule#post_analytics_processor_source_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postAnalyticsProcessorSourceUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostAnalyticsProcessorSourceUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#record_preprocessor_source_uri SagemakerMonitoringSchedule#record_preprocessor_source_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recordPreprocessorSourceUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordPreprocessorSourceUri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
