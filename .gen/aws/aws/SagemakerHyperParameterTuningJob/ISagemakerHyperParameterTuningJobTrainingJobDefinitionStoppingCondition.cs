using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_pending_time_in_seconds SagemakerHyperParameterTuningJob#max_pending_time_in_seconds}.</summary>
        [JsiiProperty(name: "maxPendingTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPendingTimeInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_runtime_in_seconds SagemakerHyperParameterTuningJob#max_runtime_in_seconds}.</summary>
        [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRuntimeInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_wait_time_in_seconds SagemakerHyperParameterTuningJob#max_wait_time_in_seconds}.</summary>
        [JsiiProperty(name: "maxWaitTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxWaitTimeInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_pending_time_in_seconds SagemakerHyperParameterTuningJob#max_pending_time_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPendingTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPendingTimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_runtime_in_seconds SagemakerHyperParameterTuningJob#max_runtime_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRuntimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_wait_time_in_seconds SagemakerHyperParameterTuningJob#max_wait_time_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxWaitTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxWaitTimeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
