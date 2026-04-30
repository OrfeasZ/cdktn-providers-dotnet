using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig")]
    public interface ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#training_repository_credentials_provider_arn SagemakerTrainingJob#training_repository_credentials_provider_arn}.</summary>
        [JsiiProperty(name: "trainingRepositoryCredentialsProviderArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrainingRepositoryCredentialsProviderArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#training_repository_credentials_provider_arn SagemakerTrainingJob#training_repository_credentials_provider_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trainingRepositoryCredentialsProviderArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrainingRepositoryCredentialsProviderArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
