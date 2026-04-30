using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsRetryStrategy")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitionsRetryStrategy : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#maximum_retry_attempts SagemakerHyperParameterTuningJob#maximum_retry_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumRetryAttempts
        {
            get;
            set;
        }
    }
}
