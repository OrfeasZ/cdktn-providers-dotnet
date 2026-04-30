using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionStoppingCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_pending_time_in_seconds SagemakerHyperParameterTuningJob#max_pending_time_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPendingTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPendingTimeInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_runtime_in_seconds SagemakerHyperParameterTuningJob#max_runtime_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRuntimeInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_wait_time_in_seconds SagemakerHyperParameterTuningJob#max_wait_time_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxWaitTimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxWaitTimeInSeconds
        {
            get;
            set;
        }
    }
}
