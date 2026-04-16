using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiInterface(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline")]
    public interface ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#baselining_job_name SagemakerMonitoringSchedule#baselining_job_name}.</summary>
        [JsiiProperty(name: "baseliningJobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseliningJobName
        {
            get
            {
                return null;
            }
        }

        /// <summary>constraints_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#constraints_resource SagemakerMonitoringSchedule#constraints_resource}
        /// </remarks>
        [JsiiProperty(name: "constraintsResource", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource? ConstraintsResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>statistics_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#statistics_resource SagemakerMonitoringSchedule#statistics_resource}
        /// </remarks>
        [JsiiProperty(name: "statisticsResource", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource? StatisticsResource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaseline
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#baselining_job_name SagemakerMonitoringSchedule#baselining_job_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baseliningJobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseliningJobName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>constraints_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#constraints_resource SagemakerMonitoringSchedule#constraints_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "constraintsResource", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource\"}", isOptional: true)]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource? ConstraintsResource
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineConstraintsResource?>();
            }

            /// <summary>statistics_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_monitoring_schedule#statistics_resource SagemakerMonitoringSchedule#statistics_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statisticsResource", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource\"}", isOptional: true)]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource? StatisticsResource
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionBaselineStatisticsResource?>();
            }
        }
    }
}
