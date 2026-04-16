using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig")]
    public class SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#training_repository_access_mode SagemakerTrainingJob#training_repository_access_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingRepositoryAccessMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingRepositoryAccessMode
        {
            get;
            set;
        }

        private object? _trainingRepositoryAuthConfig;

        /// <summary>training_repository_auth_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#training_repository_auth_config SagemakerTrainingJob#training_repository_auth_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trainingRepositoryAuthConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrainingRepositoryAuthConfig
        {
            get => _trainingRepositoryAuthConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trainingRepositoryAuthConfig = value;
            }
        }
    }
}
