using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigResourceLimits")]
    public class SagemakerHyperParameterTuningJobConfigResourceLimits : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigResourceLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_parallel_training_jobs SagemakerHyperParameterTuningJob#max_parallel_training_jobs}.</summary>
        [JsiiProperty(name: "maxParallelTrainingJobs", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxParallelTrainingJobs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_number_of_training_jobs SagemakerHyperParameterTuningJob#max_number_of_training_jobs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNumberOfTrainingJobs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxNumberOfTrainingJobs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_runtime_in_seconds SagemakerHyperParameterTuningJob#max_runtime_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRuntimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRuntimeInSeconds
        {
            get;
            set;
        }
    }
}
