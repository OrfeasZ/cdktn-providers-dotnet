using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig")]
    public class SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig : aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfig
    {
        private object? _enableMultipleJobs;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#enable_multiple_jobs SagemakerAlgorithm#enable_multiple_jobs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableMultipleJobs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableMultipleJobs
        {
            get => _enableMultipleJobs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableMultipleJobs = value;
            }
        }

        private object? _placementSpecifications;

        /// <summary>placement_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#placement_specifications SagemakerAlgorithm#placement_specifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PlacementSpecifications
        {
            get => _placementSpecifications;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _placementSpecifications = value;
            }
        }
    }
}
