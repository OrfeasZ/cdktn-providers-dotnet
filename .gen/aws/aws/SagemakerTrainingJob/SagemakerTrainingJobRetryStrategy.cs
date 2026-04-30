using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobRetryStrategy")]
    public class SagemakerTrainingJobRetryStrategy : aws.SagemakerTrainingJob.ISagemakerTrainingJobRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#maximum_retry_attempts SagemakerTrainingJob#maximum_retry_attempts}.</summary>
        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumRetryAttempts
        {
            get;
            set;
        }
    }
}
