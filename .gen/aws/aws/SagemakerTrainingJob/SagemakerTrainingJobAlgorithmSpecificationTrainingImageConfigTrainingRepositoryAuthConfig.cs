using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig")]
    public class SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#training_repository_credentials_provider_arn SagemakerTrainingJob#training_repository_credentials_provider_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingRepositoryCredentialsProviderArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingRepositoryCredentialsProviderArn
        {
            get;
            set;
        }
    }
}
