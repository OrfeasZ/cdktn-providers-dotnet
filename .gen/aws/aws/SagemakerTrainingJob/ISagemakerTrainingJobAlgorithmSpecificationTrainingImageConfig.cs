using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig")]
    public interface ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#training_repository_access_mode SagemakerTrainingJob#training_repository_access_mode}.</summary>
        [JsiiProperty(name: "trainingRepositoryAccessMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrainingRepositoryAccessMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>training_repository_auth_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#training_repository_auth_config SagemakerTrainingJob#training_repository_auth_config}
        /// </remarks>
        [JsiiProperty(name: "trainingRepositoryAuthConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrainingRepositoryAuthConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobAlgorithmSpecificationTrainingImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#training_repository_access_mode SagemakerTrainingJob#training_repository_access_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trainingRepositoryAccessMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrainingRepositoryAccessMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>training_repository_auth_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#training_repository_auth_config SagemakerTrainingJob#training_repository_auth_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trainingRepositoryAuthConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobAlgorithmSpecificationTrainingImageConfigTrainingRepositoryAuthConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrainingRepositoryAuthConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
