using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiInterface(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfig), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfig")]
    public interface ISagemakerMonitoringScheduleMonitoringScheduleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#monitoring_type SagemakerMonitoringSchedule#monitoring_type}.</summary>
        [JsiiProperty(name: "monitoringType", typeJson: "{\"primitive\":\"string\"}")]
        string MonitoringType
        {
            get;
        }

        /// <summary>monitoring_job_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#monitoring_job_definition SagemakerMonitoringSchedule#monitoring_job_definition}
        /// </remarks>
        [JsiiProperty(name: "monitoringJobDefinition", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition? MonitoringJobDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#monitoring_job_definition_name SagemakerMonitoringSchedule#monitoring_job_definition_name}.</summary>
        [JsiiProperty(name: "monitoringJobDefinitionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MonitoringJobDefinitionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>schedule_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#schedule_config SagemakerMonitoringSchedule#schedule_config}
        /// </remarks>
        [JsiiProperty(name: "scheduleConfig", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig? ScheduleConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfig), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#monitoring_type SagemakerMonitoringSchedule#monitoring_type}.</summary>
            [JsiiProperty(name: "monitoringType", typeJson: "{\"primitive\":\"string\"}")]
            public string MonitoringType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>monitoring_job_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#monitoring_job_definition SagemakerMonitoringSchedule#monitoring_job_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitoringJobDefinition", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition\"}", isOptional: true)]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition? MonitoringJobDefinition
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinition?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#monitoring_job_definition_name SagemakerMonitoringSchedule#monitoring_job_definition_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monitoringJobDefinitionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MonitoringJobDefinitionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>schedule_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#schedule_config SagemakerMonitoringSchedule#schedule_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleConfig", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig\"}", isOptional: true)]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig? ScheduleConfig
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigScheduleConfig?>();
            }
        }
    }
}
