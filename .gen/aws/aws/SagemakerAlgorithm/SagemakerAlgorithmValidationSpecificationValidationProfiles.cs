using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfiles")]
    public class SagemakerAlgorithmValidationSpecificationValidationProfiles : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfiles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#profile_name SagemakerAlgorithm#profile_name}.</summary>
        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
        public string ProfileName
        {
            get;
            set;
        }

        private object? _trainingJobDefinition;

        /// <summary>training_job_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#training_job_definition SagemakerAlgorithm#training_job_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trainingJobDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrainingJobDefinition
        {
            get => _trainingJobDefinition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trainingJobDefinition = value;
            }
        }

        private object? _transformJobDefinition;

        /// <summary>transform_job_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#transform_job_definition SagemakerAlgorithm#transform_job_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transformJobDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TransformJobDefinition
        {
            get => _transformJobDefinition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTransformJobDefinition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transformJobDefinition = value;
            }
        }
    }
}
