using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfig")]
    public class SagemakerTrainingJobResourceConfigInstancePlacementConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobResourceConfigInstancePlacementConfig
    {
        private object? _enableMultipleJobs;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#enable_multiple_jobs SagemakerTrainingJob#enable_multiple_jobs}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#placement_specifications SagemakerTrainingJob#placement_specifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerTrainingJob.SagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerTrainingJob.ISagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerTrainingJob.ISagemakerTrainingJobResourceConfigInstancePlacementConfigPlacementSpecifications).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _placementSpecifications = value;
            }
        }
    }
}
